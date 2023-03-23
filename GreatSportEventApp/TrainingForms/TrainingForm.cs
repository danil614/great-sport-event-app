using GreatSportEventApp.Entities;
using GreatSportEventApp.LocationForms;
using GreatSportEventApp.TeamForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace GreatSportEventApp.TrainingForms
{
    public partial class TrainingForm : Form
    {
        private int locationId;
        private int teamId;

        public int TrainingId { get; set; }

        public TrainingForm(bool isChanging, int _trainingId)
        {
            InitializeComponent();

            locationId = -1;
            teamId = -1;

            TrainingId = _trainingId;

            if (isChanging)
            {
                Text = @"Изменение тренировки";
                labelTitle.Text = @"Изменение тренировки";
                GetTrainingById(TrainingId);
            }

            dateTimeEvent.Format = DateTimePickerFormat.Custom;
            dateTimeEvent.CustomFormat = "dd.MM.yyyy HH:mm";

            duration.Format = DateTimePickerFormat.Custom;
            duration.CustomFormat = "HH:mm";
            duration.ShowUpDown = true;
        }

        private void GetTrainingById(int trainingId)
        {
            DataRow dataTable = Query.GetTrainingById(out bool isConnected, trainingId);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            textLocationName.Text = dataTable["location_name"].ToString();
            locationId = (int)dataTable["location_id"];

            textTeamName.Text = dataTable["team_name"].ToString();
            teamId = (int)dataTable["team_id"];

            dateTimeEvent.Value = (DateTime)dataTable["date_time"];
            duration.Value = new DateTime(2011, 11, 11) + (TimeSpan)dataTable["duration"];
            textDescription.Text = dataTable["description"].ToString();
        }

        private void SelectTeamButton_Click(object sender, EventArgs e)
        {
            ListTeamsForm listTeamsForm = new(true); ;
            listTeamsForm.ShowDialog();

            var selectedTeam = listTeamsForm.SelectedItem;

            if (selectedTeam == null)
            {
                return;
            }

            teamId = (int)selectedTeam.Cells[0].Value;
            textTeamName.Text = teamId == -1 ? "" : selectedTeam.Cells["team_name"].Value.ToString();
        }

        private void SelectLocationButton_Click(object sender, EventArgs e)
        {
            ListLocationsForm listLocationsForm = new(true);
            listLocationsForm.ShowDialog();

            var selectedLocation = listLocationsForm.SelectedLocation;

            if (selectedLocation == null)
            {
                return;
            }

            locationId = (int)selectedLocation.Cells["Номер"].Value;
            textLocationName.Text = $"{selectedLocation.Cells["Город"].Value}, {selectedLocation.Cells["Название"].Value}";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (teamId <= 0 || locationId <= 0 || (duration.Value.Hour == 0 && duration.Value.Minute == 0))
            {
                _ = MessageBox.Show(@"Неправильно заполнены поля!");
                return;
            }

            using (GreatSportEventContext context = new())
            {
                Training training;

                if (TrainingId == -1)
                {
                    training = new Training();
                    _ = context.Trainings.Add(training);
                }
                else
                {
                    training = context.Trainings.Find(TrainingId);
                }

                training.LocationId = locationId;
                training.TeamId = teamId;
                training.DateTime = dateTimeEvent.Value;
                training.Duration = new TimeSpan(duration.Value.Hour, duration.Value.Minute, 0);
                training.Description = textDescription.Text;
                _ = context.SaveChanges();

                TrainingId = training.Id;
            }

            DialogResult = DialogResult.OK;
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