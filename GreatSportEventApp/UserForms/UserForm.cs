using GreatSportEventApp.BasicForms;
using GreatSportEventApp.Entities;
using GreatSportEventApp.LocationForms;
using GreatSportEventApp.PersonForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace GreatSportEventApp.UserForms
{
    public partial class UserForm : Form
    {
        private int? athleteId;
        private int? employeeId;
        private int? viewerId;

        public string UserLogin { get; set; }

        public UserForm(bool isChanging, string _userLogin)
        {
            InitializeComponent();

            UserLogin = _userLogin;

            athleteId = null;
            employeeId = null;
            viewerId = null;

            if (isChanging)
            {
                Text = @"Изменение пользователя";
                labelTitle.Text = @"Изменение пользователя";
                GetUserById();
            }
        }

        private void GetUserById()
        {
            using (GreatSportEventContext context = new())
            {
                var user = context.Users.Find(UserLogin);

                if (user is null)
                {
                    _ = MessageBox.Show(@"Отсутствует подключение!");
                    return;
                }

                athleteId = user.AthleteId;
                var athlete = context.Athletes.Find(athleteId);
                textAthleteName.Text = athlete is null ? "" : athlete.ToString();

                employeeId = user.EmployeeId;
                var employee = context.Employees.Find(employeeId);
                textEmployeeName.Text = employee is null ? "" : employee.ToString();

                viewerId = user.ViewerId;
                var viewer = context.Viewers.Find(viewerId);
                textViewerName.Text = viewer is null ? "" : viewer.ToString();

                comboMode.SelectedIndex = user.GetAccessMode() - 1;

                textLogin.Text = user.Login;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if ((athleteId == null && employeeId == null && viewerId == null) ||
                textLogin.Text == "" || comboMode.SelectedIndex < 0)
            {
                _ = MessageBox.Show(@"Неправильно заполнены поля!");
                return;
            }

            using (GreatSportEventContext context = new())
            {
                User user;

                if (string.IsNullOrEmpty(UserLogin)) // При создании нового пользователя
                {
                    user = new User();
                    _ = context.Users.Add(user);
                }
                else
                {
                    user = context.Users.Find(UserLogin);
                }

                user.Login = textLogin.Text;
                user.Password = Query.GetHash(textPassword.Text);
                user.AccessMode = (comboMode.SelectedIndex + 1).ToString();
                user.AthleteId = athleteId > 0 ? user.AthleteId : null;
                user.EmployeeId = employeeId > 0 ? employeeId : null;
                user.ViewerId = viewerId > 0 ? viewerId : null;

                _ = context.SaveChanges();

                UserLogin = user.Login;
            }

            Close();
        }

        #region Validating

        private void TextLogin_Validating(object sender, CancelEventArgs e)
        {
            ValidatingControls.SetTextLengthError(sender, errorProvider1, 30);
        }

        #endregion


        #region Выбор человека

        private void SelectAthleteButton_Click(object sender, EventArgs e)
        {
            ListAthletesForm athletesForm = new(true);
            athletesForm.ShowDialog();

            var selectedAthlete = athletesForm.SelectedItem;

            if (selectedAthlete == null)
            {
                return;
            }

            athleteId = (int)selectedAthlete.Cells["Номер"].Value;
            textAthleteName.Text = selectedAthlete.Cells["ФИО"].Value.ToString();

            employeeId = null;
            textEmployeeName.Text = "";

            viewerId = null;
            textViewerName.Text = "";
        }

        private void SelectEmployeeButton_Click(object sender, EventArgs e)
        {
            ListEmployeesForm employeesForm = new(true);
            employeesForm.ShowDialog();

            var selectedEmployee = employeesForm.SelectedItem;

            if (selectedEmployee == null)
            {
                return;
            }

            athleteId = null;
            textAthleteName.Text = "";

            employeeId = (int)selectedEmployee.Cells["Номер"].Value;
            textEmployeeName.Text = selectedEmployee.Cells["ФИО"].Value.ToString();

            viewerId = null;
            textViewerName.Text = "";
        }

        private void SelectViewerButton_Click(object sender, EventArgs e)
        {
            ListViewersForm viewersForm = new(true);
            viewersForm.ShowDialog();

            var selectedViewer = viewersForm.SelectedItem;

            if (selectedViewer == null)
            {
                return;
            }

            athleteId = null;
            textAthleteName.Text = "";

            employeeId = null;
            textEmployeeName.Text = "";

            viewerId = (int)selectedViewer.Cells["Номер"].Value;
            textViewerName.Text = selectedViewer.Cells["ФИО"].Value.ToString();
        }

        #endregion
    }
}