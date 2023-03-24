using GreatSportEventApp.BasicForms;
using GreatSportEventApp.Entities;
using GreatSportEventApp.LocationForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GreatSportEventApp.SearchForms
{
    public partial class SearchSportEventForm : Form
    {
        public BindingSource BindingSource { get; set; }

        private int locationId;

        public SearchSportEventForm()
        {
            InitializeComponent();

            // Запрещаем редактирование типа места
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateTypeList();

            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "dd.MM.yyyy HH:mm";

            dateTimeStop.Format = DateTimePickerFormat.Custom;
            dateTimeStop.CustomFormat = "dd.MM.yyyy HH:mm";

            duration.Format = DateTimePickerFormat.Custom;
            duration.CustomFormat = "HH:mm";
            duration.ShowUpDown = true;
        }

        /// <summary>
        ///     Обновляет список типов мест.
        /// </summary>
        private void UpdateTypeList()
        {
            comboType.Items.Clear();

            DataTable dataTable = Query.GetListTypes(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            foreach (DataRow row in dataTable.Rows)
            {
                _ = comboType.Items.Add(row[0]);
            }
        }

        private void SelectLocationButton_Click(object sender, EventArgs e)
        {
            ListLocationsForm listLocationsForm = new(true);
            _ = listLocationsForm.ShowDialog();

            DataGridViewRow selectedLocation = listLocationsForm.SelectedLocation;

            if (selectedLocation == null)
            {
                return;
            }

            locationId = (int)selectedLocation.Cells["Номер"].Value;
            textLocationName.Text = $"{selectedLocation.Cells["Город"].Value}, {selectedLocation.Cells["Название"].Value}";
        }


        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var bindingSource = new BindingSource();

            bindingSource.Filter = "";

            if (comparisonType.SelectedIndex > 0 && !string.IsNullOrEmpty(comboType.Text))
            {
                bindingSource.Filter +=
                    @$"[Тип мероприятия] {GetNameComparison(comparisonType.Text)} '{comboType.Text}'";
            }

            if (comparisonLocation.SelectedIndex > 0 && !string.IsNullOrEmpty(textLocationName.Text))
            {
                if (!string.IsNullOrEmpty(bindingSource.Filter))
                {
                    bindingSource.Filter += " AND ";
                }

                bindingSource.Filter +=
                    @$"[Место] {GetNameComparison(comparisonLocation.Text)} '{textLocationName.Text}'";
            }

            if (comparisonDateStart.SelectedIndex > 0)
            {
                if (!string.IsNullOrEmpty(bindingSource.Filter))
                {
                    bindingSource.Filter += " AND ";
                }

                bindingSource.Filter +=
                    @$"[Начало] {comparisonDateStart.Text} '{dateTimeStart.Value}'";
            }

            BindingSource = bindingSource;

            DialogResult = DialogResult.OK;
            Close();
        }

        private static string GetNameComparison(string comparison)
        {
            comparison = comparison.ToLower();

            switch (comparison)
            {
                case "подобно":
                    return "LIKE";
                case "не подобно":
                    return "NOT LIKE";
                case "равно":
                    return "=";
                case "не равно":
                    return "NOT =";
                default:
                    return null;
            }
        }
    }
}