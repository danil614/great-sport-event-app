using MySql.Data.MySqlClient;
using System.Data;

namespace GreatSportEventApp
{
    public static class DatabaseConnection
    {
        /// <summary>
        ///     Получает строку подключения к базе данных.
        /// </summary>
        public static string GetConnectionString()
        {
            const string host = "";
            const string database = "";
            const string username = "";
            const string password = "";

            string connectionString =
                $"server={host};user={username};database={database};password={password};CharSet=utf8;convert zero datetime=True";
            return connectionString;
        }

        /// <summary>
        ///     Получает таблицу по результату запроса.
        /// </summary>
        public static DataTable GetDataTable(string query)
        {
            DataTable dataTable;
            // Получаем строку подключения
            string connectionString = GetConnectionString();

            try
            {
                using MySqlConnection connection = new(connectionString);
                using MySqlDataAdapter adapter = new(query, connection);
                DataSet dataSet = new();
                _ = adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (MySqlException)
            {
                return null;
            }

            return dataTable;
        }

        /// <summary>
        ///     Выполняет запрос.
        /// </summary>
        public static bool RunQuery(string query)
        {
            // Получаем строку подключения
            string connectionString = GetConnectionString();
            bool isConnected;

            try
            {
                using MySqlConnection connection = new(connectionString);
                connection.Open();
                using (MySqlCommand command = new(query, connection))
                {
                    _ = command.ExecuteNonQuery();
                    isConnected = true;
                }

                connection.Close();
            }
            catch (MySqlException)
            {
                isConnected = false;
            }

            return isConnected;
        }
    }
}