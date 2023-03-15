using GreatSportEventApp.Entities;
using GreatSportEventApp.LocationForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using GreatSportEventApp;

namespace GreatSportEventApp.TeamForms
{
    public partial class TeamForm : Form
    {
        private int teamId;
        private int locationId;

        public string TeamString { get; set; }
        public int TeamId { get => teamId; set => teamId = value; }

        public TeamForm(bool isChanging, int _teamId)
        {
            InitializeComponent();

            teamId = _teamId;
            TeamString = "";

            if (isChanging)
            {
                Text = @"Изменение команды";
                labelTitle.Text = @"Изменение команды";
                GetTeamById(teamId);
            }
        }

        private void GetTeamById(int teamId)
        {
            var dataTable = Query.GetTeamById(out var isConnected, teamId);

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            textTeamName.Text = dataTable["team_name"].ToString();
            textLocationName.Text = dataTable["location_full_name"].ToString();
            locationId = (int)dataTable["location_id"];
            textRating.Text = dataTable["rating"].ToString();
            textDescription.Text = dataTable["description"].ToString();
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
            bool isConnected;

            using (var context = new GreatSportEventContext())
            {
                Team team;

                if (teamId == -1)
                {
                    team = new Team();
                    context.Teams.Add(team);
                }
                else
                {
                    team = context.Teams.Find(teamId);
                }

                team.LocationId = locationId;
                team.Name = textTeamName.Text;

                int.TryParse(textRating.Text, out int rating);
                team.Rating = rating;

                team.Description = textDescription.Text;
                context.SaveChanges();

                TeamId = team.Id;
                TeamString = Query.GetTeamStringById(out isConnected, TeamId);
            }

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            Close();
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

        #endregion
    }
}