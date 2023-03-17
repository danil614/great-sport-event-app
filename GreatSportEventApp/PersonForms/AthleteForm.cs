using GreatSportEventApp.Entities;
using System;
using System.ComponentModel;
using System.Data;
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

            teamId = _teamId;
            AthleteId = _athleteId;
            AthleteString = "";

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

        private void GetAthleteById()
        {
            using GreatSportEventContext context = new();
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
            dateBirth.Value = athlete.BithDate;
            comboPosition.SelectedValue = athlete.PositionId;
            textRating.Text = athlete.Rating.ToString();
            textDescription.Text = athlete.Description;

            teamId = athlete.TeamId;
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
                textPatronymic.Text == "" || textPhoneNumber.Text == "")
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
                    athlete = new Athlete
                    {
                        TeamId = teamId
                    };
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
                athlete.BithDate = dateBirth.Value;
                athlete.PositionId = (int)comboPosition.SelectedValue;

                _ = int.TryParse(textRating.Text, out int rating);
                athlete.Rating = rating;

                athlete.Description = textDescription.Text;

                _ = context.SaveChanges();

                AthleteId = athlete.Id;
                AthleteString = Query.GetAthleteStringById(out isConnected, AthleteId);
            }

            if (!isConnected)
            {
                _ = MessageBox.Show(@"Отсутствует подключение!");
                return;
            }

            Close();
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
    }
}