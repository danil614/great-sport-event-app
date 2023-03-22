using GreatSportEventApp.Entities;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.TeamForms
{
    public partial class ListTeamsForm : DockContent
    {
        public DataGridViewRow SelectedItem { get; set; }

        public ListTeamsForm(bool isSelectionMode)
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
            DataTable dataTable = Query.GetListTeams(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                Close();
            }
            else
            {
                DataGridView.DataSource = dataTable;
                DataGridView.Columns["team_id"].Visible = false;
                DataGridView.Columns["team_name"].HeaderText = "Название";
                DataGridView.Columns["location_name"].HeaderText = "Место расположения";
                DataGridView.Columns["rating"].HeaderText = "Рейтинг";
            }

            // Растягиваем колонки
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            TeamForm teamForm = new(false, -1, -1);
            _ = teamForm.ShowDialog();

            if (teamForm.TeamId != -1)
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
            TeamForm teamForm = new(true, currentRowId, -1);
            _ = teamForm.ShowDialog();

            UpdateDataGridView();
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
                Team team = context.Teams.Find(currentRowId);

                if (team is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }

                _ = context.Teams.Remove(team);

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
                _ = MessageBox.Show(@"Выделите нужную строку с командой!");
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