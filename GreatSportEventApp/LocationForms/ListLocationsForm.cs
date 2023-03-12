using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.LocationForms
{
    public partial class ListLocationsForm : DockContent
    {
        public ListLocationsForm()
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

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                Close();
            }
            else
            {
                dataLocations.DataSource = listLocations;
                dataLocations.Columns["Номер"].Visible = false;
            }

            // Растягиваем колонки
            dataLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DataLocations_Click(null, null);
        }

        private void DataLocations_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditToolStripButton_Click(sender, e);
        }

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            var locationForm = new LocationForm(false);
            locationForm.ShowDialog();
            UpdateListLocations();
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
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

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            UpdateListLocations();
        }

        private void DataLocations_Click(object sender, EventArgs e)
        {
            var isEnabled = dataLocations.CurrentRow != null;

            CreateToolStripButton.Enabled = isEnabled;
            EditToolStripButton.Enabled = isEnabled;
            DeleteToolStripButton.Enabled = isEnabled;
        }

        private void DataLocations_CurrentCellChanged(object sender, EventArgs e)
        {
            DataLocations_Click(null, null);
        }
    }
}