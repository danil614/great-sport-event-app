using GreatSportEventApp.Entities;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.PersonForms
{
    public partial class ListEmployeesForm : DockContent
    {
        public DataGridViewRow SelectedItem { get; set; }

        public ListEmployeesForm(bool isSelectionMode)
        {
            InitializeComponent();
            UpdateDataGridView();

            if (!isSelectionMode)
            {
                SelectToolStripButton.Visible = false;
            }

            SelectedItem = null;
        }

        /// <summary>
        ///     Обновляет список.
        /// </summary>
        private void UpdateDataGridView()
        {
            // Получаем запрос
            DataTable dataTable = Query.GetListEmployees(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                Close();
            }
            else
            {
                DataGridView.DataSource = dataTable;
                DataGridView.Columns["Номер"].Visible = false;
            }

            // Растягиваем колонки
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new(false, -1);
            var dialogResult = employeeForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                UpdateDataGridView();
            }
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null)
            {
                return;
            }

            int currentRowId = (int)DataGridView.CurrentRow.Cells[0].Value;

            EmployeeForm employeeForm = new(true, currentRowId);
            var dialogResult = employeeForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                UpdateDataGridView();
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null)
            {
                return;
            }

            using (GreatSportEventContext context = new())
            {
                int currentRowId = (int)DataGridView.CurrentRow.Cells[0].Value;
                var employee = context.Employees.Find(currentRowId);

                if (employee is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }

                _ = context.Employees.Remove(employee);

                try
                {
                    _ = context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }
            }

            UpdateDataGridView();
        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void SelectToolStripButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null)
            {
                _ = MessageBox.Show(@"Выделите нужную строку с сотрудником!");
                return;
            }
            else
            {
                SelectedItem = DataGridView.CurrentRow;
                Close();
            }
        }

        private void DataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            bool isEnabled = DataGridView.CurrentRow != null;

            CreateToolStripButton.Enabled = isEnabled;
            EditToolStripButton.Enabled = isEnabled;
            DeleteToolStripButton.Enabled = isEnabled;
        }

        private void DataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditToolStripButton_Click(sender, e);
        }
    }
}