using GreatSportEventApp.LocationForms;
using GreatSportEventApp.SimpleForms;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp.BasicForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

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
                string accessMode = Query.GetAccessMode(loginForm.Login, loginForm.Password, out bool isConnected);

                if (!isConnected)
                {
                    _ = MessageBox.Show(@"Отсутствует подключение!");
                    Application.Exit();
                    return;
                }

                // Создаем форму организатора
                OrganizerForm organizerForm = new();
                // Создаем форму продавца
                SellerForm sellerForm = new();
                // Создаем форму администратора
                AdminForm adminForm = new();

                switch (accessMode)
                {
                    case "1":
                        adminForm.Show(mainDockPanel, DockState.Document);
                        break;
                    case "2":
                        sellerForm.Show(mainDockPanel, DockState.Document);
                        break;
                    case "3":
                        organizerForm.Show(mainDockPanel, DockState.Document);
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

        #endregion
    }
}
