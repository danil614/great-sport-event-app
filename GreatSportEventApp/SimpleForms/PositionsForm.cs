using GreatSportEventApp.Entities;
using MySql.Data.MySqlClient;
using System;
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
            // Получаем запрос со зрителями
            var listPositions = Query.GetListPositions(out var isConnected);

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                Close();
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
            if (dataView.CurrentRow == null) return;

            long.TryParse(dataView.CurrentRow.Cells[0].Value.ToString(), out long id);
            string name = dataView.CurrentRow.Cells[1].Value.ToString();

            if (name != "")
            {
                using (var context = new GreatSportEventContext())
                {
                    var position = context.Positions.Find(id);

                    if (position is null)
                    {
                        position = new Position();
                        context.Positions.Add(position);
                    }

                    position.Name = name;
                    context.SaveChanges();

                    UpdateListPositions();
                }
            }
        }

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            int n = dataView.Rows.Count;
            dataView.CurrentCell = dataView.Rows[n - 1].Cells[1];
            dataView.BeginEdit(true);
        }
        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataView.CurrentRow.Cells[1];
            dataView.CurrentCell = cell;
            dataView.BeginEdit(true);
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataView.CurrentRow == null) return;

            using (var context = new GreatSportEventContext())
            {
                bool isIdFill = long.TryParse(dataView.CurrentRow.Cells[0].Value.ToString(), out long id);
                string name = dataView.CurrentRow.Cells[1].Value.ToString();

                if (isIdFill && name != "")
                {
                    var position = context.Positions.Find(id);

                    if (position is null)
                    {
                        MessageBox.Show(@"Невозможно удалить запись!");
                    }
                    else
                    {
                        context.Positions.Remove(position);

                        try
                        {
                            context.SaveChanges();
                        }
                        catch (DbUpdateException)
                        {
                            MessageBox.Show(@"Невозможно удалить запись!");
                        }

                        UpdateListPositions();
                    }
                }
            }
        }
    }
}