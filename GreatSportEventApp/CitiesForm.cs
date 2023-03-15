using GreatSportEventApp.Entities;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp
{
    public partial class CitiesForm : DockContent
    {
        private City oldCity;

        public CitiesForm()
        {
            InitializeComponent();
            UpdateListCities();
            oldCity = null;
        }

        /// <summary>
        ///     Обновляет список городов.
        /// </summary>
        private void UpdateListCities()
        {
            // Получаем запрос со зрителями
            var listLocations = Query.GetListCitiesAndId(out var isConnected);

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                Close();
            }
            else
            {
                dataView.DataSource = listLocations;
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
                MessageBox.Show(@"Неправльно заполнен id города!");
                return;
            }
        }

        private void DataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataView.CurrentRow == null) return;
            // Тут надо запретить смену id---------------------------
            using (var context = new GreatSportEventContext())
            {
                string name = dataView.CurrentRow.Cells[1].Value.ToString();
                bool isIdFill = long.TryParse(dataView.CurrentRow.Cells[0].Value.ToString(), out long id);

                if (isIdFill && name != "")
                {
                    var city = context.Cities.Find(oldCity.Id);

                    if (city is null)
                    {
                        city = new City();
                        context.Cities.Add(city);
                    }

                    city.Id = id;
                    city.Name = name;
                    context.SaveChanges();

                    UpdateListCities();
                }
            }
        }

        private void DataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldCity = null;
            if (dataView.CurrentRow == null) return;

            using (var context = new GreatSportEventContext())
            {
                bool isIdFill = long.TryParse(dataView.CurrentRow.Cells[0].Value.ToString(), out long id);

                if (isIdFill)
                {
                    oldCity = context.Cities.Find(id);
                }
            }
        }
    }
}