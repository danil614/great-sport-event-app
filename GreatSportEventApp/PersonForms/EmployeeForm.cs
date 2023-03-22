using GreatSportEventApp.Entities;
using GreatSportEventApp.TeamForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GreatSportEventApp.PersonForms
{
    public partial class EmployeeForm : Form
    {
        private int? teamId;

        public int EmployeeId { get; set; }

        public EmployeeForm(bool isChanging, int _employeeId)
        {
            InitializeComponent();

            teamId = null;
            EmployeeId = _employeeId;

            // Запрещаем редактирование пола и должности
            comboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPosition.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateGenderList();
            UpdatePositionsList();

            if (isChanging)
            {
                Text = @"Изменение сотрудника";
                labelTitle.Text = @"Изменение сотрудника";
                GetEmployeeById();
            }
        }

        private void GetEmployeeById()
        {
            using (GreatSportEventContext context = new())
            {
                Employee employee = context.Employees.Find(EmployeeId);

                if (employee is null)
                {
                    _ = MessageBox.Show(@"Отсутствует подключение!");
                    return;
                }

                textSurname.Text = employee.Surname;
                textSurname.Text = employee.Name;
                textPatronymic.Text = employee.Patronymic;
                comboGender.SelectedValue = employee.GenderId;
                textPhoneNumber.Text = employee.PhoneNumber;
                dateBirth.Value = employee.BirthDate;
                comboPosition.SelectedValue = employee.PositionId;

                teamId = employee.TeamId;
                textTeamName.Text = teamId == null ? "" : context.Teams.Find(teamId).ToString();
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
        ///     Обновляет список должностей.
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
            if (textSurname.Text == "" || textSurname.Text == "" ||
                textPatronymic.Text == "" || textPhoneNumber.Text == "")
            {
                _ = MessageBox.Show(@"Неправильно заполнены поля!");
                return;
            }

            using (GreatSportEventContext context = new())
            {
                Employee employee;

                if (EmployeeId == -1) // При создании нового сотрудника
                {
                    employee = new Employee();
                    _ = context.Employees.Add(employee);
                }
                else
                {
                    employee = context.Employees.Find(EmployeeId);
                }

                employee.Surname = textSurname.Text;
                employee.Name = textSurname.Text;
                employee.Patronymic = textPatronymic.Text;
                employee.GenderId = (int)comboGender.SelectedValue;
                employee.PhoneNumber = textPhoneNumber.Text;
                employee.BirthDate = dateBirth.Value;
                employee.PositionId = (int)comboPosition.SelectedValue;
                employee.TeamId = teamId;

                _ = context.SaveChanges();

                EmployeeId = employee.Id;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        #region Validating

        private void TextLength_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetTextLengthError(sender, errorProvider1, 30);
        }

        #endregion

        private void SelectTeamButton_Click(object sender, EventArgs e)
        {
            ListTeamsForm teamsForm = new(true);
            teamsForm.ShowDialog();

            if (teamsForm.SelectedItem == null)
            {
                MessageBox.Show(@"Команда не выбрана!");
                teamId = null;
                return;
            }

            using (GreatSportEventContext context = new())
            {
                teamId = (int)teamsForm.SelectedItem.Cells[0].Value;
                textTeamName.Text = teamId == null ? "" : context.Teams.Find(teamId).ToString();
            }
        }
    }
}