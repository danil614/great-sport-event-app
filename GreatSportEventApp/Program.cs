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

            // Открываем форму входа
            var loginForm = new LoginForm();
            Application.Run(loginForm);

            if (!(string.IsNullOrWhiteSpace(loginForm.Login) || string.IsNullOrWhiteSpace(loginForm.Password)))
            {
                // Получаем режим доступа по логину и паролю
                var accessMode = Query.GetAccessMode(loginForm.Login, loginForm.Password);
                
                // Создаем форму продавца
                var sellerForm = new SellerForm();

                switch (accessMode)
                {
                    case "1":
                        MessageBox.Show(@"АХАХАХАХАХ ВЫ АДМИН!!!");
                        break;
                    case "2":
                        //Application.Run(sellerForm);
                        MessageBox.Show(@"ъуъуъуъуъ ВЫ КаССИИРРР!!!");
                        break;
                    default:
                        MessageBox.Show($@"НЕТУУУ {accessMode}");
                        break;
                }
            }
        }
    }
}