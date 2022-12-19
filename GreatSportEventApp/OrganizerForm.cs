using System;
using System.Windows.Forms;

namespace GreatSportEventApp
{
    public partial class OrganizerForm : Form
    {
        public OrganizerForm()
        {
            InitializeComponent();
            UpdateListLocations();
        }

        /// <summary>
        ///     Обновляет список мест.
        /// </summary>
        private void UpdateListLocations()
        {
            // Получаем запрос со зрителями
            var listLocations = Query.GetListLocations(out var isConnected);
            var listLocationsGroup = Query.GetListLocationsGroup(out var isConnectedGroup);

            if (!isConnected || !isConnectedGroup)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                Close();
            }
            else
            {
                dataLocations.DataSource = listLocations;
                dataLocationsGroup.DataSource = listLocationsGroup;
            }

            // Растягиваем колонки
            dataLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataLocationsGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonAddLocation_Click(object sender, EventArgs e)
        {
            var locationForm = new LocationForm(false);
            locationForm.ShowDialog();
            UpdateListLocations();
        }

        private void buttonChangeLocation_Click(object sender, EventArgs e)
        {
            if (dataLocations.CurrentRow == null) return;

            var currentRowId = (int)dataLocations.CurrentRow.Cells[0].Value;
            var location = Query.GetLocationById(out var isConnected, currentRowId);

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
            }
            else
            {
                var locationForm = new LocationForm(true);
                locationForm.LocationId = currentRowId;
                locationForm.LocationName = location["location_name"].ToString();
                locationForm.City = location["city_name"].ToString();
                locationForm.Address = location["address"].ToString();
                locationForm.Type = location["location_type"].ToString();
                locationForm.Capacity = (int)location["capacity"];
                locationForm.Description = location["description"].ToString();
                locationForm.ShowDialog();
                UpdateListLocations();
            }
        }

        private void dataLocations_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonChangeLocation_Click(sender, e);
        }
    }
}