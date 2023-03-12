using GreatSportEventApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GreatSportEventApp
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
            var loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (!(string.IsNullOrWhiteSpace(loginForm.Login) || string.IsNullOrWhiteSpace(loginForm.Password)))
            {
                // Получаем режим доступа по логину и паролю
                var accessMode = Query.GetAccessMode(loginForm.Login, loginForm.Password, out var isConnected);

                if (!isConnected)
                {
                    MessageBox.Show(@"Отсутствует подключение!");
                    Application.Exit();
                    return;
                }

                // Создаем форму организатора
                var organizerForm = new OrganizerForm();
                // Создаем форму продавца
                var sellerForm = new SellerForm();
                // Создаем форму администратора
                var adminForm = new AdminForm();

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
                        MessageBox.Show($@"Неправильный логин или пароль!");
                        break;
                }
            }
        }

        private void TreeFormToolStripButton_Click(object sender, EventArgs e)
        {
            var treeForm = new TreeForm();
            treeForm.Show(mainDockPanel, DockState.Document);
        }

        private void AboutFormToolStripButton_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        #endregion
    }
}
