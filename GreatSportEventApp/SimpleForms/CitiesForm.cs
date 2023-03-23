using GreatSportEventApp.Entities;
using System;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.SimpleForms
{
    public partial class CitiesForm : DockContent
    {
        public CitiesForm()
        {
            InitializeComponent();
            UpdateListCities();
            dataView.EditMode = DataGridViewEditMode.EditOnKeystroke;
        }

        /// <summary>
        ///     Обновляет список городов.
        /// </summary>
        private void UpdateListCities()
        {
            // Получаем запрос со зрителями
            System.Data.DataTable listCities = Query.GetListCitiesAndId(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }
            else
            {
                dataView.DataSource = listCities;
            }

            // Растягиваем колонки
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            UpdateListCities();
        }

        private void DataView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                _ = MessageBox.Show(@"Неправльно заполнен id города!");
                return;
            }
        }

        private void DataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataView.CurrentRow == null)
            {
                return;
            }

            using GreatSportEventContext context = new();
            string name = dataView.CurrentRow.Cells[1].Value.ToString();
            bool isIdFill = long.TryParse(dataView.CurrentRow.Cells[0].Value.ToString(), out long id);

            if (isIdFill && name != "")
            {
                City city = context.Cities.Find(id);

                if (city is null)
                {
                    city = new City
                    {
                        Id = id
                    };
                    _ = context.Cities.Add(city);
                }

                city.Name = name;
                _ = context.SaveChanges();

                UpdateListCities();
            }
        }

        private void DataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataView.CurrentRow == null)
            {
                return;
            }

            string stringId = dataView.CurrentRow.Cells[0].Value.ToString();
            if (e.ColumnIndex == 0 && stringId != "")
            {
                _ = MessageBox.Show(@"Нельзя менять id города!");
                e.Cancel = true;
            }
        }

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            int n = dataView.Rows.Count;
            dataView.CurrentCell = dataView.Rows[n - 1].Cells[0];
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
            string name = dataView.CurrentRow.Cells[1].Value.ToString();
            bool isIdFill = long.TryParse(dataView.CurrentRow.Cells[0].Value.ToString(), out long id);

            if (isIdFill && name != "")
            {
                City city = context.Cities.Find(id);

                if (city is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                }
                else
                {
                    _ = context.Cities.Remove(city);

                    try
                    {
                        _ = context.SaveChanges();
                    }
                    catch (DbUpdateException)
                    {
                        _ = MessageBox.Show(@"Невозможно удалить запись!");
                    }

                    UpdateListCities();
                }
            }
        }
    }
}