using GreatSportEventApp.BasicForms;
using GreatSportEventApp.Entities;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
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
            SetVisibleItems();
            dataView.EditMode = DataGridViewEditMode.EditOnKeystroke;
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
                bool isNew = false;

                if (position is null)
                {
                    isNew = true;
                    position = new Position();
                    _ = context.Positions.Add(position);
                }

                position.Name = name;

                if (IsDuplicate(context, position, isNew))
                {
                    MessageBox.Show(@"Должность с таким названием уже существует!");
                    int currentRowIndex = dataView.CurrentRow.Index;
                    dataView.Rows.Remove(dataView.Rows[currentRowIndex]);
                    return;
                }

                _ = context.SaveChanges();

                UpdateListPositions();
            }
        }

        private static bool IsDuplicate(GreatSportEventContext context, Position position, bool isNew)
        {
            if (isNew)
            {
                var foundDuplicates = context.Positions.Where(
                    item => item.Name == position.Name);

                if (foundDuplicates.Any())
                {
                    return true;
                }
            }

            return false;
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

        private void ToolStripTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataView.DataSource;
            bindingSource.Filter = dataView.Columns[1].Name.ToString() + " LIKE '%" + toolStripTextBoxFilter.Text + "%'";
            dataView.DataSource = bindingSource;
        }

        private void ExportToolStripButton_Click(object sender, EventArgs e)
        {
            ExportToExcel.Do(dataView);
        }
    }
}