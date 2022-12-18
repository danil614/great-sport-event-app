using System.Data;

namespace GreatSportEventApp
{
    public static class Query
    {
        public static DataTable GetAccessMode(string login, string password)
        {
            var query = $"SELECT access_mode FROM Users WHERE login='{login}' AND password=md5('{password}')";
            var data = DatabaseConnection.GetDataTable(query);

            return data;
        }

        public static DataTable GetListViewers()
        {
            const string query = "SELECT viewer_id, CONCAT(surname, ' ', name, ' ', patronymic) AS full_name," +
                                 "(SELECT gender_name FROM Gender WHERE gender_id = Viewers.gender_id) AS gender_id," +
                                 "phone_number, birth_date FROM Viewers";

            return DatabaseConnection.GetDataTable(query);
        }
    }
}