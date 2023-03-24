using GreatSportEventApp.BasicForms;
using GreatSportEventApp.Entities;
using GreatSportEventApp.TeamForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GreatSportEventApp.PersonForms
{
    public partial class AthleteForm : Form
    {
        private int teamId;

        public string AthleteString { get; set; }
        public int AthleteId { get; set; }

        public AthleteForm(bool isChanging, int _athleteId, int _teamId)
        {
            InitializeComponent();
            SetVisibleItems();

            teamId = _teamId;
            AthleteId = _athleteId;
            AthleteString = "";

            if (teamId != -1)
            {
                SelectTeamButton.Visible = false;
            }

            // Запрещаем редактирование пола и должности
            comboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPosition.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateGenderList();
            UpdatePositionsList();

            if (isChanging)
            {
                Text = @"Изменение спортсмена";
                labelTitle.Text = @"Изменение спортсмена";
                GetAthleteById();
            }
        }

        private void SetVisibleItems()
        {
            if (MainForm.CurrentUser.UserType == UserType.Athlete)
            {
                textSurname.ReadOnly = true;
                textName.ReadOnly = true;
                textPatronymic.ReadOnly = true;

                comboGender.Enabled = false;
                dateBirth.Enabled = false;
                comboPosition.Enabled = false;

                textPhoneNumber.ReadOnly = true;
                textRating.ReadOnly = true;
                SelectTeamButton.Enabled = false;
                textDescription.ReadOnly = true;

                buttonSave.Enabled = false;
            }
        }

        private void GetAthleteById()
        {
            using (GreatSportEventContext context = new())
            {
                Athlete athlete = context.Athletes.Find(AthleteId);

                if (athlete is null)
                {
                    _ = MessageBox.Show(@"Отсутствует подключение!");
                    return;
                }

                textSurname.Text = athlete.Surname;
                textName.Text = athlete.Name;
                textPatronymic.Text = athlete.Patronymic;
                comboGender.SelectedValue = athlete.GenderId;
                textPhoneNumber.Text = athlete.PhoneNumber;
                dateBirth.Value = athlete.BirthDate;
                comboPosition.SelectedValue = athlete.PositionId;
                textRating.Text = athlete.Rating.ToString();
                textDescription.Text = athlete.Description;

                teamId = athlete.TeamId;
                textTeamName.Text = teamId == -1 ? "" : context.Teams.Find(teamId).ToString();
            }
        }

        /// <summary>
        ///     Обновляет список полов.
        /// </summary>
        private void UpdateGenderList()
        {
            comboGender.Items.Clear();

            DataTable dataTable = Query.GetListGenderAndId(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
            }

            comboGender.DataSource = dataTable;
            comboGender.DisplayMember = "gender_name";
            comboGender.ValueMember = "gender_id";
        }

        /// <summary>
        ///     Обновляет список городов.
        /// </summary>
        private void UpdatePositionsList()
        {
            comboPosition.Items.Clear();

            DataTable dataTable = Query.GetListPositions(out bool isConnected);

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            comboPosition.DataSource = dataTable;
            comboPosition.DisplayMember = "position_name";
            comboPosition.ValueMember = "position_id";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textSurname.Text == "" || textName.Text == "" ||
                textPatronymic.Text == "" || textPhoneNumber.Text == "" || teamId <= 0)
            {
                _ = MessageBox.Show(@"Неправильно заполнены поля!");
                return;
            }

            bool isConnected;

            using (GreatSportEventContext context = new())
            {
                Athlete athlete;

                if (AthleteId == -1) // При создании нового спортсмена
                {
                    athlete = new Athlete();
                    _ = context.Athletes.Add(athlete);
                }
                else
                {
                    athlete = context.Athletes.Find(AthleteId);
                }

                athlete.Surname = textSurname.Text;
                athlete.Name = textName.Text;
                athlete.Patronymic = textPatronymic.Text;
                athlete.GenderId = (int)comboGender.SelectedValue;
                athlete.PhoneNumber = textPhoneNumber.Text;
                athlete.BirthDate = dateBirth.Value;
                athlete.PositionId = (int)comboPosition.SelectedValue;

                _ = int.TryParse(textRating.Text, out int rating);
                athlete.Rating = rating;

                athlete.Description = textDescription.Text;

                athlete.TeamId = teamId;

                if (IsDuplicate(context, athlete, AthleteId == -1))
                {
                    MessageBox.Show(@"Спортсмен с такими данными уже существует!");
                    return;
                }

                _ = context.SaveChanges();

                AthleteId = athlete.Id;
                AthleteString = Query.GetAthleteStringById(out isConnected, AthleteId);
            }

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private static bool IsDuplicate(GreatSportEventContext context, Athlete athlete, bool isNew)
        {
            if (isNew)
            {
                var foundDuplicates = context.Athletes.Where(
                    item =>
                    item.Surname == athlete.Surname &&
                    item.Name == athlete.Name &&
                    item.Patronymic == athlete.Patronymic &&
                    item.GenderId == athlete.GenderId &&
                    item.BirthDate == athlete.BirthDate
                    );

                if (foundDuplicates.Any())
                {
                    return true;
                }
            }

            return false;
        }

        #region Validating

        private void TextRating_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetIntError(sender, errorProvider1);
        }

        private void TextLength_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetTextLengthError(sender, errorProvider1, 30);
        }

        private void TextDescription_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetTextLengthError(sender, errorProvider1, 60000);
        }

        #endregion

        private void SelectTeamButton_Click(object sender, EventArgs e)
        {
            ListTeamsForm teamsForm = new(true);
            teamsForm.ShowDialog();

            if (teamsForm.SelectedItem == null)
            {
                MessageBox.Show(@"Команда не выбрана!");
                teamId = -1;
                return;
            }

            using (GreatSportEventContext context = new())
            {
                teamId = (int)teamsForm.SelectedItem.Cells[0].Value;
                textTeamName.Text = teamId == -1 ? "" : teamsForm.SelectedItem.Cells["team_name"].Value.ToString();
            }
        }
    }
}