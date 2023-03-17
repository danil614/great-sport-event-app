using GreatSportEventApp.LocationForms;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp
{
    public partial class OrganizerForm : DockContent
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
            System.Data.DataTable listLocations = Query.GetListLocations(out bool isConnected);
            System.Data.DataTable listLocationsGroup = Query.GetListLocationsGroup(out bool isConnectedGroup);

            if (!isConnected || !isConnectedGroup)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
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
            LocationForm locationForm = new(false);
            _ = locationForm.ShowDialog();
            UpdateListLocations();
        }

        private void buttonChangeLocation_Click(object sender, EventArgs e)
        {
            if (dataLocations.CurrentRow == null)
            {
                return;
            }

            int currentRowId = (int)dataLocations.CurrentRow.Cells[0].Value;
            System.Data.DataRow location = Query.GetLocationById(out bool isConnected, currentRowId);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
            }
            else
            {
                LocationForm locationForm = new(true)
                {
                    LocationId = currentRowId,
                    LocationName = location["location_name"].ToString(),
                    City = location["city_name"].ToString(),
                    Address = location["address"].ToString(),
                    Type = location["location_type"].ToString(),
                    Capacity = (int)location["capacity"],
                    Description = location["description"].ToString()
                };
                _ = locationForm.ShowDialog();
                UpdateListLocations();
            }
        }

        private void dataLocations_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonChangeLocation_Click(sender, e);
        }
    }
}