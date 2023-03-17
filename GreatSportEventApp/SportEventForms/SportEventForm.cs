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
        private int locationId;

        public string SportEventString { get; set; }
        public int SportEventId { get; set; }

        public SportEventForm(bool isChanging, int _sportEventId)
        {
            InitializeComponent();

            SportEventId = _sportEventId;
            SportEventString = "";

            // Запрещаем редактирование типа места
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateTypeList();

            if (isChanging)
            {
                Text = @"Изменение спортивного мероприятия";
                labelTitle.Text = @"Изменение спортивного мероприятия";
                GetSportEventById(SportEventId);
            }

            dateTimeEvent.Format = DateTimePickerFormat.Custom;
            dateTimeEvent.CustomFormat = "dd.MM.yyyy HH:mm";

            duration.Format = DateTimePickerFormat.Custom;
            duration.CustomFormat = "HH:mm";
            duration.ShowUpDown = true;
        }

        private void GetSportEventById(int sportEventId)
        {
            DataRow dataTable = Query.GetSportEventById(out bool isConnected, sportEventId);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            int typeId = Query.GetTypeIdByName(out bool isConnected, comboType.Text);
            if (typeId == -1 || locationId == 0 || (duration.Value.Hour == 0 && duration.Value.Minute == 0))
            {
                _ = MessageBox.Show(@"Неправильно заполнены поля!");
                return;
            }

            using (GreatSportEventContext context = new())
            {
                SportEvent sportEvent;

                if (SportEventId == -1)
                {
                    sportEvent = new SportEvent();
                    _ = context.SportEvents.Add(sportEvent);
                }
                else
                {
                    sportEvent = context.SportEvents.Find(SportEventId);
                }

                sportEvent.TypeId = typeId;
                sportEvent.LocationId = locationId;
                sportEvent.DateTime = dateTimeEvent.Value;
                sportEvent.Duration = new TimeSpan(duration.Value.Hour, duration.Value.Minute, 0);
                sportEvent.Description = textDescription.Text;
                _ = context.SaveChanges();

                SportEventId = sportEvent.Id;
                SportEventString = Query.GetSportEventStringById(out isConnected, SportEventId);
            }

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
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