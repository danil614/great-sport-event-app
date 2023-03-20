using GreatSportEventApp.LocationForms;
using GreatSportEventApp.PersonForms;
using GreatSportEventApp.SimpleForms;
using GreatSportEventApp.TeamForms;
using GreatSportEventApp.TicketForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.BasicForms
{
    public partial class MainForm : Form
    {
        public static CurrentUser CurrentUser { get => _currentUser; }
        private static CurrentUser _currentUser;

        public MainForm()
        {
            InitializeComponent();
            _currentUser = new CurrentUser();

            // Тема для Dock
            mainDockPanel.Theme = new VS2015LightTheme();

            LoginToolStripButton_Click(null, null);
        }

        private void SetMainToolStripVisible(bool isVisible)
        {
            var openedWindows = new List<DockContent>();

            foreach (DockContent item in mainDockPanel.Documents)
            {
                openedWindows.Add(item);
            }

            foreach (DockContent item in openedWindows)
            {
                item.Close();
            }

            foreach (ToolStripItem item in MainToolStrip.Items)
            {
                item.Visible = isVisible;
            }

            toolStripSeparatorLeft.Visible = true;

            ModeToolStripLabel.Visible = true;
            toolStripSeparatorMode.Visible = true;

            LoginToolStripButton.Visible = true;
            toolStripSeparatorLogin.Visible = true;

            AboutFormToolStripButton.Visible = true;

            toolStripSeparatorRight.Visible = true;
        }

        #region MainToolStrip

        private void LoginToolStripButton_Click(object sender, EventArgs e)
        {
            // Открываем форму входа
            LoginForm loginForm = new();
            _ = loginForm.ShowDialog();

            if (!(string.IsNullOrWhiteSpace(loginForm.Login) || string.IsNullOrWhiteSpace(loginForm.Password)))
            {
                // Получаем режим доступа по логину и паролю
                _currentUser = Query.GetAccessMode(loginForm.Login, loginForm.Password, out bool isConnected);

                if (!isConnected)
                {
                    _ = MessageBox.Show(@"Отсутствует подключение!");
                    return;
                }

                SetMainToolStripVisible(false);

                switch (CurrentUser.UserType)
                {
                    case UserType.Admin:
                        // Создаем форму администратора
                        ModeToolStripLabel.Text = "Администратор";
                        SetMainToolStripVisible(true);
                        break;
                    case UserType.Seller:
                        // Создаем форму продавца
                        ModeToolStripLabel.Text = "Продавец";
                        // Билеты
                        TicketsToolStripButton.Visible = true;
                        toolStripSeparatorTickets.Visible = true;

                        // Зрители
                        ViewersToolStripButton.Visible = true;
                        toolStripSeparatorViewers.Visible = true;
                        break;
                    case UserType.Organizer:
                        // Создаем форму организатора
                        ModeToolStripLabel.Text = "Организатор";
                        // Мероприятия и участники
                        TreeFormToolStripButton.Visible = true;
                        toolStripSeparatorTreeForm.Visible = true;

                        // Места расположения
                        ListLocationsFormToolStripButton.Visible = true;
                        toolStripSeparatorLocations.Visible = true;

                        // Города
                        CitiesToolStripButton.Visible = true;
                        toolStripSeparatorCities.Visible = true;

                        // Команды
                        TeamsToolStripButton.Visible = true;
                        toolStripSeparatorTeams.Visible = true;

                        // Спортсмены
                        AthletesToolStripButton.Visible = true;
                        toolStripSeparatorAthletes.Visible = true;
                        break;
                    case UserType.HR:
                        ModeToolStripLabel.Text = "HR менеджер";
                        // Должности
                        PositionsToolStripButton.Visible = true;
                        toolStripSeparatorPositions.Visible = true;

                        // Сотрудники
                        EmployeesToolStripButton.Visible = true;
                        toolStripSeparatorEmployees.Visible = true;
                        break;
                    case UserType.Trainer:
                        ModeToolStripLabel.Text = "Тренер";
                        // Команды
                        TeamsToolStripButton.Visible = true;
                        toolStripSeparatorTeams.Visible = true;

                        // Спортсмены
                        AthletesToolStripButton.Visible = true;
                        toolStripSeparatorAthletes.Visible = true;
                        break;
                    default:
                        _ = MessageBox.Show($@"Неправильный логин или пароль!");
                        ModeToolStripLabel.Text = "—";
                        break;
                }
            }
        }

        private void TreeFormToolStripButton_Click(object sender, EventArgs e)
        {
            Forms.OpenEventsParticipantsForm(mainDockPanel);
        }

        private void ListLocationsFormToolStripButton_Click(object sender, EventArgs e)
        {
            Forms.OpenLocationsForm(mainDockPanel);
        }

        private void AboutFormToolStripButton_Click(object sender, EventArgs e)
        {
            Forms.OpenAboutForm();
        }

        private void CitiesToolStripButton_Click(object sender, EventArgs e)
        {
            Forms.OpenCitiesForm(mainDockPanel);
        }

        private void PositionsToolStripButton_Click(object sender, EventArgs e)
        {
            Forms.OpenPositionsForm(mainDockPanel);
        }

        private void TeamsToolStripButton_Click(object sender, EventArgs e)
        {
            Forms.OpenTeamsForm(mainDockPanel);
        }

        private void ViewersToolStripButton_Click(object sender, EventArgs e)
        {
            Forms.OpenViewersForm(mainDockPanel);
        }

        private void TicketsToolStripButton_Click(object sender, EventArgs e)
        {
            Forms.OpenTicketsForm(mainDockPanel);
        }

        private void EmployeesToolStripButton_Click(object sender, EventArgs e)
        {
            Forms.OpenEmployeesForm(mainDockPanel);
        }

        private void AthletesToolStripButton_Click(object sender, EventArgs e)
        {
            Forms.OpenAthletesForm(mainDockPanel);
        }

        private void UsersToolStripButton_Click(object sender, EventArgs e)
        {
            Forms.OpenUsersForm(mainDockPanel);
        }

        #endregion
    }
}
