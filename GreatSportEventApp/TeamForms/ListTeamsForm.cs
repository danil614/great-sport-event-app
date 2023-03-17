﻿using GreatSportEventApp.LocationForms;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.TeamForms
{
    public partial class ListTeamsForm : DockContent
    {
        public DataGridViewRow SelectedLocation { get; set; }

        public ListTeamsForm(bool isSelectionMode)
        {
            InitializeComponent();
            UpdateListLocations();

            if (!isSelectionMode)
            {
                SelectToolStripButton.Visible = false;
            }

            SelectedLocation = null;
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