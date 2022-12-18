using System.Data;

namespace GreatSportEventApp
{
    public static class Query
    {
        /// <summary>
        /// Получает режим доступа по логину и паролю.
        /// </summary>
        public static string GetAccessMode(string login, string password)
        {
            var query = $"SELECT access_mode FROM Users WHERE login='{login}' AND password=md5('{password}')";
            var dataTable = DatabaseConnection.GetDataTable(query);

            if (dataTable.Rows.Count == 1)
            {
                return (string)dataTable.Rows[0][0];
            }

            return "";
        }

        /// <summary>
        /// Получает всех зрителей.
        /// </summary>
        public static DataTable GetListViewers()
        {
            const string query = "SELECT viewer_id, CONCAT(surname, ' ', name, ' ', patronymic) AS full_name," +
                                 "(SELECT gender_name FROM Gender WHERE gender_id = Viewers.gender_id) AS gender_id," +
                                 "phone_number, birth_date FROM Viewers";

            return DatabaseConnection.GetDataTable(query);
        }
    }
}