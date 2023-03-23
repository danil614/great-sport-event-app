using GreatSportEventApp.Entities;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.SimpleForms
{
    public partial class PositionsForm : DockContent
    {
        public PositionsForm()
        {
            InitializeComponent();
            UpdateListPositions();
            dataView.EditMode = DataGridViewEditMode.EditOnKeystroke;
        }

        /// <summary>
        ///     Обновляет список должностей.
        /// </summary>
        private void UpdateListPositions()
        {
            DataTable listPositions = Query.GetListPositions(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }
            else
            {
                dataView.DataSource = listPositions;
            }

            // Растягиваем колонки
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataView.Columns["position_id"].Visible = false;
            dataView.Columns["position_name"].HeaderText = "Название";
        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            UpdateListPositions();
        }

        private void DataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataView.CurrentRow == null)
            {
                return;
            }

            _ = long.TryParse(dataView.CurrentRow.Cells[0].Value.ToString(), out long id);
            string name = dataView.CurrentRow.Cells[1].Value.ToString();

            if (name != "")
            {
                using GreatSportEventContext context = new();
                Position position = context.Positions.Find(id);

                if (position is null)
                {
                    position = new Position();
                    _ = context.Positions.Add(position);
                }

                position.Name = name;
                _ = context.SaveChanges();

                UpdateListPositions();
            }
        }

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            int n = dataView.Rows.Count;
            dataView.CurrentCell = dataView.Rows[n - 1].Cells[1];
            _ = dataView.BeginEdit(true);
        }
        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataView.CurrentRow.Cells[1];
            dataView.CurrentCell = cell;
            _ = dataView.BeginEdit(true);
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataView.CurrentRow == null)
            {
                return;
            }

            using GreatSportEventContext context = new();
            bool isIdFill = int.TryParse(dataView.CurrentRow.Cells[0].Value.ToString(), out int id);
            string name = dataView.CurrentRow.Cells[1].Value.ToString();

            if (isIdFill && name != "")
            {
                Position position = context.Positions.Find(id);

                if (position is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                }
                else
                {
                    _ = context.Positions.Remove(position);

                    try
                    {
                        _ = context.SaveChanges();
                    }
                    catch (DbUpdateException)
                    {
                        _ = MessageBox.Show(@"Невозможно удалить запись!");
                    }

                    UpdateListPositions();
                }
            }
        }
    }
}