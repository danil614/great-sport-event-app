using GreatSportEventApp.Entities;
using System;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using GreatSportEventApp.BasicForms;

namespace GreatSportEventApp.LocationForms
{
    public partial class ListLocationsForm : DockContent
    {
        public DataGridViewRow SelectedLocation { get; set; }

        public ListLocationsForm(bool isSelectionMode)
        {
            InitializeComponent();
            UpdateListLocations();
            SetVisibleItems();

            if (!isSelectionMode)
            {
                SelectToolStripButton.Visible = false;
            }

            SelectedLocation = null;
        }

        private void SetVisibleItems()
        {
            if (MainForm.CurrentUserType == UserType.Admin)
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
        ///     Обновляет список мест.
        /// </summary>
        private void UpdateListLocations()
        {
            // Получаем запрос со зрителями
            System.Data.DataTable listLocations = Query.GetListLocations(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
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
            LocationForm locationForm = new(false);
            _ = locationForm.ShowDialog();
            UpdateListLocations();
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
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

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataLocations.CurrentRow == null)
            {
                return;
            }

            using GreatSportEventContext context = new();
            bool isIdFill = int.TryParse(dataLocations.CurrentRow.Cells[0].Value.ToString(), out int id);

            if (isIdFill)
            {
                var location = context.Locations.Find(id);

                if (location is null)
                {
                    _ = MessageBox.Show(@"Невозможно удалить запись!");
                }
                else
                {
                    _ = context.Locations.Remove(location);

                    try
                    {
                        _ = context.SaveChanges();
                    }
                    catch (DbUpdateException)
                    {
                        _ = MessageBox.Show(@"Невозможно удалить запись!");
                    }

                    UpdateListLocations();
                }
            }
        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            UpdateListLocations();
        }

        private void DataLocations_Click(object sender, EventArgs e)
        {
            bool isEnabled = dataLocations.CurrentRow != null;

            CreateToolStripButton.Enabled = isEnabled;
            EditToolStripButton.Enabled = isEnabled;
            DeleteToolStripButton.Enabled = isEnabled;
        }

        private void DataLocations_CurrentCellChanged(object sender, EventArgs e)
        {
            DataLocations_Click(null, null);
        }

        private void SelectToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataLocations.CurrentRow == null)
            {
                _ = MessageBox.Show(@"Выделите нужную строку с местом расположения!");
                return;
            }
            else
            {
                SelectedLocation = dataLocations.CurrentRow;
                Close();
            }
        }
    }
}