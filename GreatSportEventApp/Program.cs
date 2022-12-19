using System;
using System.Windows.Forms;

namespace GreatSportEventApp
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //////
            //var testForm = new AdminForm();
            //Application.Run(testForm);
            //return;
            //////

            // Открываем форму входа
            var loginForm = new LoginForm();
            Application.Run(loginForm);

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
                //Создаем форму администратора
                var adminForm = new AdminForm();

                switch (accessMode)
                {
                    case "1":
                        Application.Run(adminForm);
                        break;
                    case "2":
                        Application.Run(sellerForm);
                        break;
                    case "3":
                        Application.Run(organizerForm);
                        break;
                    default:
                        MessageBox.Show($@"Неправильный логин или пароль!");
                        break;
                }
            }
        }
    }
}