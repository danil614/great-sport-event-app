using GreatSportEventApp.BasicForms;
using GreatSportEventApp.Entities;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.TicketForms
{
    public partial class ListTicketsForm : DockContent
    {
        public DataGridViewRow SelectedItem { get; set; }

        public ListTicketsForm(bool isSelectionMode)
        {
            InitializeComponent();
            UpdateDataGridView();
            SetVisibleItems();

            if (!isSelectionMode)
            {
                SelectToolStripButton.Visible = false;
            }

            SelectedItem = null;
        }

        private void SetVisibleItems()
        {
            if (MainForm.CurrentUser.UserType == UserType.Admin)
            {
                DeleteToolStripButton.Visible = true;
                toolStripSeparator4.Visible = true;
            }
            else
            {
                DeleteToolStripButton.Visible = false;
                toolStripSeparator4.Visible = false;
            }
        }

        private void UpdateDataGridView()
        {
            DataTable dataTable = Query.GetListTickets(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
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
            TicketForm ticketForm = new(false, -1);
            var dialogResult = ticketForm.ShowDialog();
            
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

            TicketForm ticketForm = new TicketForm(true, currentRowId);
            var dialogResult = ticketForm.ShowDialog();

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
                var ticket = context.Tickets.Find(currentRowId);

                if (ticket is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                    return;
                }

                _ = context.Tickets.Remove(ticket);

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
                _ = MessageBox.Show(@"Выделите нужную строку с билетом!");
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