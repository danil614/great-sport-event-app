using System;
using System.Windows.Forms;

namespace GreatSportEventApp
{
    internal static class Program
    {
        private static DatabaseConnection _connection;
        
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Создаем подключение к бд
            CreateDatabaseConnection();
            
            var loginForm = new LoginForm();
            Application.Run(loginForm);
            
            MessageBox.Show(loginForm.Login + @" " + loginForm.Password);
        }

        private static void GetListViewers()
        {
            const string query = "SELECT viewer_id, CONCAT(surname, ' ', name, ' ', patronymic) AS full_name," +
                                 "(SELECT gender_name FROM Gender WHERE gender_id = Viewers.gender_id) AS gender_id," +
                                 "phone_number, birth_date FROM Viewers";

            var data = _connection.RunQuery(query);
        }

        private static void CreateDatabaseConnection()
        {
            const string host = "vh293.spaceweb.ru";
            const string database = "fs159mailr";
            const string username = "fs159mailr";
            const string password = "4A8J%nAVDFFDPR5A";

            _connection = new DatabaseConnection(host, database, username, password);
        }


    }
}