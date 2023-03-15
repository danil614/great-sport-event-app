using GreatSportEventApp.Entities;
using GreatSportEventApp.LocationForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GreatSportEventApp.SportEventForms
{
    public partial class SportEventForm : Form
    {
        private int sportEventId;
        private int locationId;

        public string SportEventString { get; set; }
        public int SportEventId { get => sportEventId; set => sportEventId = value; }

        public SportEventForm(bool isChanging, int _sportEventId)
        {
            InitializeComponent();

            sportEventId = _sportEventId;
            SportEventString = "";

            // Запрещаем редактирование типа места
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateTypeList();

            if (isChanging)
            {
                Text = @"Изменение спортивного мероприятия";
                labelTitle.Text = @"Изменение спортивного мероприятия";
                GetSportEventById(sportEventId);
            }

            dateTimeEvent.Format = DateTimePickerFormat.Custom;
            dateTimeEvent.CustomFormat = "dd.MM.yyyy HH:mm";

            duration.Format = DateTimePickerFormat.Custom;
            duration.CustomFormat = "HH:mm";
            duration.ShowUpDown = true;
        }

        private void GetSportEventById(int sportEventId)
        {
            var dataTable = Query.GetSportEventById(out var isConnected, sportEventId);

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            comboType.SelectedItem = dataTable["type_name"].ToString();
            textLocationName.Text = dataTable["location_full_name"].ToString();
            locationId = (int)dataTable["location_id"];
            dateTimeEvent.Value = (DateTime)dataTable["dateTimeEvent"];
            duration.Value = new DateTime(2011, 11, 11) + (TimeSpan)dataTable["duration"];
            textDescription.Text = dataTable["description"].ToString();
        }
        
        /// <summary>
        ///     Обновляет список типов мест.
        /// </summary>
        private void UpdateTypeList()
        {
            comboType.Items.Clear();

            var dataTable = Query.GetListTypes(out var isConnected);

            if (!isConnected) 
            { 
                MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            foreach (DataRow row in dataTable.Rows) comboType.Items.Add(row[0]);
        }

        private void SelectLocationButton_Click(object sender, EventArgs e)
        {
            var listLocationsForm = new ListLocationsForm(true);
            listLocationsForm.ShowDialog();

            var selectedLocation = listLocationsForm.SelectedLocation;

            if (selectedLocation == null) return;

            locationId = (int)selectedLocation.Cells["Номер"].Value;
            textLocationName.Text = $"{selectedLocation.Cells["Город"].Value}, {selectedLocation.Cells["Название"].Value}";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var typeId = Query.GetTypeIdByName(out bool isConnected, comboType.Text);

            using (var context = new GreatSportEventContext())
            {
                SportEvent sportEvent;

                if (sportEventId == -1)
                {
                    sportEvent = new SportEvent();
                    context.SportEvents.Add(sportEvent);
                }
                else
                {
                    sportEvent = context.SportEvents.Find(sportEventId);
                }

                sportEvent.TypeId = typeId;
                sportEvent.LocationId = locationId;
                sportEvent.DateTime = dateTimeEvent.Value;
                sportEvent.Duration = new TimeSpan(duration.Value.Hour, duration.Value.Minute, 0);
                sportEvent.Description = textDescription.Text;
                context.SaveChanges();

                SportEventId = sportEvent.Id;
                SportEventString = Query.GetSportEventStringById(out isConnected, SportEventId);
            }

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            Close();
        }

        #region Validating

        private void TextDescription_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetTextLengthError(sender, errorProvider1, 60000);
        }

        #endregion
    }
}