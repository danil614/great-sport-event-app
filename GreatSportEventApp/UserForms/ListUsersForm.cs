using GreatSportEventApp.Entities;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.UserForms
{
    public partial class ListUsersForm : DockContent
    {
        public DataGridViewRow SelectedItem { get; set; }

        public ListUsersForm(bool isSelectionMode)
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
        ///     Обновляет список мест.
        /// </summary>
        private void UpdateDataGridView()
        {
            // Получаем запрос со зрителями
            DataTable dataTable = Query.GetListUsers(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                Close();
            }
            else
            {
                DataGridView.DataSource = dataTable;
            }

            // Растягиваем колонки
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            UserForm userForm = new(false, null);
            _ = userForm.ShowDialog();
            UpdateDataGridView();
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null)
            {
                return;
            }

            string currentRowId = DataGridView.CurrentRow.Cells[0].Value.ToString();

            UserForm userForm = new(true, currentRowId);
            userForm.ShowDialog();

            UpdateDataGridView();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null)
            {
                return;
            }

            string currentRowLogin = DataGridView.CurrentRow.Cells[0].Value.ToString();
            bool isConnected = Query.DeleteUserByLogin(currentRowLogin);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Невозможно удалить запись!");
                return;
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
                _ = MessageBox.Show(@"Выделите нужную строку с пользователем!");
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