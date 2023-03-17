using GreatSportEventApp.Entities;
using GreatSportEventApp.LocationForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GreatSportEventApp.TeamForms
{
    public partial class TeamForm : Form
    {
        private readonly int sportEventId;
        private int locationId;

        public string TeamString { get; set; }
        public int TeamId { get; set; }

        public TeamForm(bool isChanging, int _teamId, int _sportEventId)
        {
            InitializeComponent();

            TeamId = _teamId;
            sportEventId = _sportEventId;
            TeamString = "";

            if (isChanging)
            {
                Text = @"Изменение команды";
                labelTitle.Text = @"Изменение команды";
                GetTeamById(TeamId);
            }
        }

        private void GetTeamById(int teamId)
        {
            DataRow dataTable = Query.GetTeamById(out bool isConnected, teamId, sportEventId);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            textTeamName.Text = dataTable["team_name"].ToString();
            textLocationName.Text = dataTable["location_full_name"].ToString();
            locationId = (int)dataTable["location_id"];
            textRating.Text = dataTable["rating"].ToString();
            textScore.Text = dataTable["score"].ToString();
            textDescription.Text = dataTable["description"].ToString();
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
            if (locationId == 0 || textTeamName.Text == "")
            {
                _ = MessageBox.Show(@"Неправильно заполнены поля!");
                return;
            }

            bool isConnected;

            using (GreatSportEventContext context = new())
            {
                Team team;

                if (TeamId == -1) // При создании новой команды
                {
                    team = new Team();
                    _ = context.Teams.Add(team);
                }
                else
                {
                    team = context.Teams.Find(TeamId);
                }

                team.LocationId = locationId;
                team.Name = textTeamName.Text;

                _ = int.TryParse(textRating.Text, out int rating);
                team.Rating = rating;

                team.Description = textDescription.Text;
                _ = context.SaveChanges();

                TeamId = team.Id;
                UpdateParticipationEvent(context);

                TeamString = Query.GetTeamStringById(out isConnected, TeamId, sportEventId);
            }

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            Close();
        }

        private void UpdateParticipationEvent(GreatSportEventContext context)
        {
            ParticipationEvent paticipationEvent = context.ParticipationEvents.Find(sportEventId, TeamId);
            if (paticipationEvent is null)
            {
                paticipationEvent = new ParticipationEvent();
                _ = context.ParticipationEvents.Add(paticipationEvent);
            }

            paticipationEvent.SportEventId = sportEventId;
            paticipationEvent.TeamId = TeamId;

            _ = int.TryParse(textScore.Text, out int score);
            paticipationEvent.Score = score;

            _ = context.SaveChanges();
        }

        #region Validating

        private void TextTeamName_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetTextLengthError(sender, errorProvider1, 60);
        }

        private void TextDescription_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetTextLengthError(sender, errorProvider1, 60000);
        }

        private void TextRating_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetIntError(sender, errorProvider1);
        }

        private void TextScore_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetIntError(sender, errorProvider1);
        }

        #endregion
    }
}