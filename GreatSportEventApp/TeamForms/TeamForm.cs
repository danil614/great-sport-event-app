﻿using GreatSportEventApp.Entities;
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
        private int sportEventId;
        private int locationId;

        public string TeamString { get; set; }
        public int TeamId { get => teamId; set => teamId = value; }

        public TeamForm(bool isChanging, int _teamId, int _sportEventId)
        {
            InitializeComponent();

            teamId = _teamId;
            sportEventId = _sportEventId;
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
            var dataTable = Query.GetTeamById(out var isConnected, teamId, sportEventId);

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
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
            var listLocationsForm = new ListLocationsForm(true);
            listLocationsForm.ShowDialog();

            var selectedLocation = listLocationsForm.SelectedLocation;

            if (selectedLocation == null) return;

            locationId = (int)selectedLocation.Cells["Номер"].Value;
            textLocationName.Text = $"{selectedLocation.Cells["Город"].Value}, {selectedLocation.Cells["Название"].Value}";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            int.TryParse(textRating.Text, out int rating);
            if (locationId == 0 || textTeamName.Text == "")
            {
                MessageBox.Show(@"Неправильно заполнены поля!");
                return;
            }

            bool isConnected;

            using (var context = new GreatSportEventContext())
            {
                Team team;

                if (teamId == -1) // При создании новой команды
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
                team.Rating = rating;

                team.Description = textDescription.Text;
                context.SaveChanges();

                teamId = team.Id;
                UpdateParticipationEvent(context);

                TeamString = Query.GetTeamStringById(out isConnected, teamId, sportEventId);
            }

            if (!isConnected)
            {
                MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            Close();
        }

        private void UpdateParticipationEvent(GreatSportEventContext context)
        {
            var paticipationEvent = context.ParticipationEvents.Find(sportEventId, teamId);
            if (paticipationEvent is null)
            {
                paticipationEvent = new ParticipationEvent();
            }

            paticipationEvent.SportEventId = sportEventId;
            paticipationEvent.TeamId = teamId;

            int.TryParse(textScore.Text, out int score);
            paticipationEvent.Score = score;

            context.SaveChanges();
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