using GreatSportEventApp.LocationForms;
using GreatSportEventApp.PersonForms;
using GreatSportEventApp.SimpleForms;
using GreatSportEventApp.TeamForms;
using GreatSportEventApp.TicketForms;
using System;
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

                switch (CurrentUser.UserType)
                {
                    case UserType.Admin:
                        // Создаем форму администратора
                        //AdminForm adminForm = new();
                        //adminForm.Show(mainDockPanel, DockState.Document);
                        break;
                    case UserType.Seller:
                        // Создаем форму продавца
                        // SellerForm sellerForm = new();
                        // sellerForm.Show(mainDockPanel, DockState.Document);
                        break;
                    case UserType.Organizer:
                        // Создаем форму организатора
                        // OrganizerForm organizerForm = new();
                        // organizerForm.Show(mainDockPanel, DockState.Document);
                        break;
                    case UserType.HR:
                        break;
                    default:
                        _ = MessageBox.Show($@"Неправильный логин или пароль!");
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
