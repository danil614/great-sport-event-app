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
                        AdminForm adminForm = new();
                        adminForm.Show(mainDockPanel, DockState.Document);
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
                    default:
                        _ = MessageBox.Show($@"Неправильный логин или пароль!");
                        break;
                }
            }
        }

        private void TreeFormToolStripButton_Click(object sender, EventArgs e)
        {
            TreeForm treeForm = new();
            treeForm.Show(mainDockPanel, DockState.Document);
        }

        private void ListLocationsFormToolStripButton_Click(object sender, EventArgs e)
        {
            ListLocationsForm locationsForm = new(false);
            locationsForm.Show(mainDockPanel, DockState.Document);
        }

        private void AboutFormToolStripButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new();
            _ = aboutForm.ShowDialog();
        }

        private void CitiesToolStripButton_Click(object sender, EventArgs e)
        {
            CitiesForm citiesForm = new();
            citiesForm.Show(mainDockPanel, DockState.Document);
        }

        private void PositionsToolStripButton_Click(object sender, EventArgs e)
        {
            PositionsForm positionsForm = new();
            positionsForm.Show(mainDockPanel, DockState.Document);
        }

        private void TeamsToolStripButton_Click(object sender, EventArgs e)
        {
            ListTeamsForm teamsForm = new(false);
            teamsForm.Show(mainDockPanel, DockState.Document);
        }

        private void ViewersToolStripButton_Click(object sender, EventArgs e)
        {
            ListViewersForm viewersForm = new(false);
            viewersForm.Show(mainDockPanel, DockState.Document);
        }

        private void TicketsToolStripButton_Click(object sender, EventArgs e)
        {
            ListTicketsForm ticketsForm = new(false);
            ticketsForm.Show(mainDockPanel, DockState.Document);
        }

        private void EmployeesToolStripButton_Click(object sender, EventArgs e)
        {
            ListEmployeesForm employeesForm = new(false);
            employeesForm.Show(mainDockPanel, DockState.Document);
        }

        #endregion

    }
}
