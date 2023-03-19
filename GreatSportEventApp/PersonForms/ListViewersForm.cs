using GreatSportEventApp.Entities;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.PersonForms
{
    public partial class ListViewersForm : DockContent
    {
        public DataGridViewRow SelectedItem { get; set; }

        public ListViewersForm(bool isSelectionMode)
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
            DataTable dataTable = Query.GetListViewers(out bool isConnected);

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
            PersonForm personForm = new(false);
            _ = personForm.ShowDialog();
            UpdateDataGridView();
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null)
            {
                return;
            }

            int currentRowId = (int)DataGridView.CurrentRow.Cells[0].Value;
            DataRow person = Query.GetViewerById(out bool isConnected, currentRowId);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
            }
            else
            {
                PersonForm personForm = new(true)
                {
                    PersonId = currentRowId,
                    Surname = person["surname"].ToString(),
                    PersonName = person["name"].ToString(),
                    Patronymic = person["patronymic"].ToString(),
                    Gender = person["gender_name"].ToString(),
                    PhoneNumber = person["phone_number"].ToString(),
                    BirthDate = (DateTime)person["birth_date"]
                };
                _ = personForm.ShowDialog();
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
                var viewer = context.Viewers.Find(currentRowId);

                if (viewer is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }

                _ = context.Viewers.Remove(viewer);

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
                _ = MessageBox.Show(@"Выделите нужную строку со зрителем!");
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