using GreatSportEventApp.Entities;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Type = GreatSportEventApp.Entities.Type;

namespace GreatSportEventApp.SimpleForms
{
    public partial class TypesForm : DockContent
    {
        public TypesForm()
        {
            InitializeComponent();
            UpdateListTypes();
            dataView.EditMode = DataGridViewEditMode.EditOnKeystroke;
        }

        /// <summary>
        ///     Обновляет список должностей.
        /// </summary>
        private void UpdateListTypes()
        {
            // Получаем запрос со зрителями
            DataTable listTypes = Query.GetListTypesIdName(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                Close();
            }
            else
            {
                dataView.DataSource = listTypes;
            }

            // Растягиваем колонки
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataView.Columns["type_id"].Visible = false;
            dataView.Columns["type_name"].HeaderText = "Название";
        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            UpdateListTypes();
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
                Type type = context.Types.Find(id);

                if (type is null)
                {
                    type = new Type();
                    _ = context.Types.Add(type);
                }

                type.Name = name;
                _ = context.SaveChanges();

                UpdateListTypes();
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
                Type type = context.Types.Find(id);

                if (type is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                }
                else
                {
                    _ = context.Types.Remove(type);

                    try
                    {
                        _ = context.SaveChanges();
                    }
                    catch (DbUpdateException)
                    {
                        _ = MessageBox.Show(@"Невозможно удалить запись!");
                    }

                    UpdateListTypes();
                }
            }
        }
    }
}