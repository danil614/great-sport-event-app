using System.Data;

namespace GreatSportEventApp
{
    public static class Query
    {
        /// <summary>
        /// Получает режим доступа по логину и паролю.
        /// </summary>
        public static string GetAccessMode(string login, string password, out bool isConnected)
        {
            var query = $"SELECT access_mode FROM Users WHERE login='{login}' AND password=md5('{password}')";
            var dataTable = DatabaseConnection.GetDataTable(query);

            if (dataTable == null)
            {
                isConnected = false;
                return "";
            }

            isConnected = true;

            if (dataTable.Rows.Count == 1)
            {
                return (string)dataTable.Rows[0][0];
            }

            return "";
        }

        /// <summary>
        /// Получает всех зрителей.
        /// </summary>
        public static DataTable GetListViewers(out bool isConnected)
        {
            const string query = "SELECT viewer_id as 'Номер', CONCAT(surname, ' ', name, ' ', patronymic) AS 'ФИО'," +
                                 "(SELECT gender_name FROM Gender WHERE gender_id = Viewers.gender_id) AS 'Пол'," +
                                 "phone_number as 'Номер телефона', birth_date as 'Дата рождения' FROM Viewers";

            var dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;
            
            return dataTable;
        }

        /// <summary>
        /// Вставляет новую запись в зрителей.
        /// </summary>
        public static bool InsertViewer(string surname, string name, string patronymic, string genderName, string phoneNumber, string birthDate)
        {
            var query =
                $"INSERT INTO Viewers (surname, name, patronymic, gender_id, phone_number, birth_date)" +
                $"SELECT '{surname}', '{name}', '{patronymic}', Gender.gender_id, '{phoneNumber}', '{birthDate}'" +
                $"FROM Gender WHERE gender_name='{genderName}'";
            
            var isConnected = DatabaseConnection.RunQuery(query);
            
            return isConnected;
        }
        
        /// <summary>
        /// Получает все полы.
        /// </summary>
        public static DataTable GetListGender(out bool isConnected)
        {
            const string query = "SELECT gender_name FROM Gender";

            var dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;
            
            return dataTable;
        }
    }
}