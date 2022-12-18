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
            //var sellerForm1 = new SellerForm();
            //Application.Run(sellerForm1);
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

                // Создаем форму продавца
                var sellerForm = new SellerForm();

                switch (accessMode)
                {
                    case "1":
                        MessageBox.Show(@"АХАХАХАХАХ ВЫ АДМИН!!!");
                        break;
                    case "2":
                        Application.Run(sellerForm);
                        break;
                    default:
                        MessageBox.Show($@"НЕТУУУ {accessMode}");
                        break;
                }
            }
        }
    }
}