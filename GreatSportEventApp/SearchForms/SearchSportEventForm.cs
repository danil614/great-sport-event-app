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

        public SearchSportEventForm()
        {
            InitializeComponent();
            UpdateTypeList();

            logicLocation.SelectedIndex = 0;
            logicDateStart.SelectedIndex = 0;
            logicDateStop.SelectedIndex = 0;
            logicDuration.SelectedIndex = 0;

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

            textLocationName.Text = $"{selectedLocation.Cells["Город"].Value}, {selectedLocation.Cells["Название"].Value}";
        }


        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var filter = "";

            if (comparisonType.SelectedIndex > 0 && !string.IsNullOrEmpty(comboType.Text))
            {
                filter +=
                    @$"[Тип мероприятия] {GetNameComparison(comparisonType.Text)} '{comboType.Text}'";
            }

            if (comparisonLocation.SelectedIndex > 0 && !string.IsNullOrEmpty(textLocationName.Text))
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += GetNameComparison(logicLocation.Text);
                }

                filter +=
                    @$"[Место] {GetNameComparison(comparisonLocation.Text)} '{textLocationName.Text}'";
            }

            if (comparisonDateStart.SelectedIndex > 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += GetNameComparison(logicDateStart.Text);
                }

                filter +=
                    @$"[Начало] {comparisonDateStart.Text} '{dateTimeStart.Value}'";
            }

            if (comparisonDateStop.SelectedIndex > 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += GetNameComparison(logicDateStop.Text);
                }

                filter +=
                    @$"[Начало] {comparisonDateStop.Text} '{dateTimeStop.Value}'";
            }

            if (comparisonDuration.SelectedIndex > 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += GetNameComparison(logicDuration.Text);
                }

                filter +=
                    @$"[Длительность] {GetNameComparison(comparisonDuration.Text)} '{duration.Value:HH ч. mm мин.}'";
            }

            BindingSource.Filter = filter;

            DialogResult = DialogResult.OK;
            Close();
        }

        private static string GetNameComparison(string comparison)
        {
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
                case "И":
                    return " AND ";
                case "ИЛИ":
                    return " OR ";
                default:
                    return null;
            }
        }
    }
}