using Google.Protobuf.WellKnownTypes;
using GreatSportEventApp.BasicForms;
using GreatSportEventApp.Entities;
using GreatSportEventApp.LocationForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
            SetVisibleItems();

            TeamId = _teamId;
            sportEventId = _sportEventId;
            TeamString = "";

            if (isChanging)
            {
                Text = @"Изменение команды";
                labelTitle.Text = @"Изменение команды";
                GetTeamById();
            }

            if (sportEventId == -1)
            {
                textScore.Visible = false;
                label2.Visible = false;
            }
            else
            {
                textScore.Visible = true;
                label2.Visible = true;
            }
        }

        private void SetVisibleItems()
        {
            if (MainForm.CurrentUser.UserType == UserType.Athlete)
            {
                textTeamName.ReadOnly = true;
                SelectLocationButton.Enabled = false;
                textComeFrom.ReadOnly = true;
                textRating.ReadOnly = true;
                textScore.ReadOnly = true;
                textDescription.ReadOnly = true;
                buttonSave.Enabled = false;
            }
        }

        private void GetTeamById()
        {
            DataRow dataTable = Query.GetTeamById(out bool isConnected, TeamId, sportEventId);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            textTeamName.Text = dataTable["team_name"].ToString();
            textLocationName.Text = dataTable["location_full_name"].ToString();
            locationId = (int)dataTable["location_id"];
            textRating.Text = dataTable["rating"].ToString();
            textComeFrom.Text = dataTable["come_from"].ToString();

            if (sportEventId != -1)
            {
                textScore.Text = dataTable["score"].ToString();
            }

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

                team.ComeFrom = textComeFrom.Text;

                _ = int.TryParse(textRating.Text, out int rating);
                team.Rating = rating;

                team.Description = textDescription.Text;

                if (IsDuplicate(context, team, TeamId == -1))
                {
                    MessageBox.Show(@"Команда с такими данными уже существует!");
                    return;
                }

                _ = context.SaveChanges();

                TeamId = team.Id;

                if (sportEventId != -1)
                {
                    _ = int.TryParse(textScore.Text, out int score);
                    UpdateParticipationEvent(context, sportEventId, TeamId, score);
                    TeamString = Query.GetTeamStringById(out isConnected, TeamId, sportEventId);

                    if (!isConnected)
                    {
                        _ = MessageBox.Show(@"Отсутствует подключение!");
                        return;
                    }
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private static bool IsDuplicate(GreatSportEventContext context, Team team, bool isNew)
        {
            if (isNew)
            {
                var foundDuplicates = context.Teams.Where(
                    item =>
                    item.LocationId == team.LocationId &&
                    item.Name == team.Name &&
                    item.ComeFrom == team.ComeFrom &&
                    item.Rating == team.Rating
                    );

                if (foundDuplicates.Any())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool UpdateParticipationEvent(GreatSportEventContext context, int sportEventId, int teamId, int score)
        {
            bool isNew = false;

            ParticipationEvent paticipationEvent = context.ParticipationEvents.Find(sportEventId, teamId);
            if (paticipationEvent is null)
            {
                isNew = true;

                paticipationEvent = new ParticipationEvent();
                paticipationEvent.SportEventId = sportEventId;
                paticipationEvent.TeamId = teamId;

                _ = context.ParticipationEvents.Add(paticipationEvent);
            }

            paticipationEvent.Score = score;
            _ = context.SaveChanges();

            return isNew;
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

        private void TextComeFrom_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetTextLengthError(sender, errorProvider1, 60);
        }

        #endregion

    }
}