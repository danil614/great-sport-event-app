using System.Data;

namespace GreatSportEventApp
{
    public static class Query
    {
        /// <summary>
        ///     Получает режим доступа по логину и паролю.
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

            if (dataTable.Rows.Count == 1) return (string)dataTable.Rows[0][0];

            return "";
        }

        /// <summary>
        ///     Получает всех зрителей.
        /// </summary>
        public static DataTable GetListViewers(out bool isConnected)
        {
            const string query = "SELECT viewer_id AS 'Номер', CONCAT(surname, ' ', name, ' ', patronymic) AS 'ФИО'," +
                                 "(SELECT gender_name FROM Gender WHERE gender_id = Viewers.gender_id) AS 'Пол'," +
                                 "phone_number AS 'Номер телефона', birth_date AS 'Дата рождения' FROM Viewers";

            var dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }
        
        /// <summary>
        ///     Получает все места расположения.
        /// </summary>
        public static DataTable GetListLocations(out bool isConnected)
        {
            const string query = "SELECT location_id AS 'Номер', location_name AS 'Название', " +
                                 "(SELECT city_name FROM Cities WHERE city_id = Locations.city_id) AS 'Город', " +
                                 "address AS 'Адрес', (SELECT location_type_name FROM Location_types " +
                                 "WHERE location_type_id = Locations.location_type_id) AS 'Тип места', " +
                                 "capacity AS 'Вместимость' FROM Locations";

            var dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Вставляет новую запись в зрителей.
        /// </summary>
        public static bool InsertViewer(string surname, string name, string patronymic, string genderName,
            string phoneNumber, string birthDate)
        {
            var query =
                "INSERT INTO Viewers (surname, name, patronymic, gender_id, phone_number, birth_date)" +
                $"SELECT '{surname}', '{name}', '{patronymic}', Gender.gender_id, '{phoneNumber}', '{birthDate}'" +
                $"FROM Gender WHERE gender_name='{genderName}'";

            var isConnected = DatabaseConnection.RunQuery(query);

            return isConnected;
        }
        
        /// <summary>
        ///     Вставляет новую запись в места расположения.
        /// </summary>
        public static bool InsertLocation(string name, string city, string address, string type,
            int capacity, string description)
        {
            var query =
                "INSERT INTO Locations (location_name, city_id, address, location_type_id, capacity, description) " +
                $"SELECT '{name}', (SELECT city_id FROM Cities WHERE city_name='{city}'), " +
                $"'{address}', (SELECT location_type_id FROM Location_types WHERE location_type_name='{type}'), " +
                $"'{capacity}', '{description}'";

            var isConnected = DatabaseConnection.RunQuery(query);

            return isConnected;
        }
        
        /// <summary>
        ///     Изменяет место по id.
        /// </summary>
        public static bool UpdateLocation(int id, string name, string city, string address, string type,
            int capacity, string description)
        {
            var query = 
                $"UPDATE Locations SET location_name='{name}', " +
                $"city_id=(SELECT city_id FROM Cities WHERE city_name='{city}'), address='{address}', " +
                $"location_type_id=(SELECT location_type_id FROM Location_types WHERE location_type_name='{type}'), " +
                $"capacity='{capacity}', description='{description}' WHERE location_id={id}";

            var isConnected = DatabaseConnection.RunQuery(query);

            return isConnected;
        }
        
        /// <summary>
        ///     Изменяет зрителя по id
        /// </summary>
        public static bool UpdateViewer(int id, string surname, string name, string patronymic, string genderName,
            string phoneNumber, string birthDate)
        {
            var query =
                $"UPDATE Viewers SET surname='{surname}', name='{name}', patronymic='{patronymic}', " +
                $"gender_id=(SELECT gender_id FROM Gender WHERE gender_name='{genderName}'), " +
                $"phone_number='{phoneNumber}', birth_date='{birthDate}'" +
                $"WHERE viewer_id={id}";

            var isConnected = DatabaseConnection.RunQuery(query);

            return isConnected;
        }

        /// <summary>
        ///     Получает все полы.
        /// </summary>
        public static DataTable GetListGender(out bool isConnected)
        {
            const string query = "SELECT gender_name FROM Gender";

            var dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }
        
        /// <summary>
        ///     Получает все города.
        /// </summary>
        public static DataTable GetListCities(out bool isConnected)
        {
            const string query = "SELECT city_name FROM Cities";

            var dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }
        
        /// <summary>
        ///     Получает все типы мест.
        /// </summary>
        public static DataTable GetListTypes(out bool isConnected)
        {
            const string query = "SELECT location_type_name FROM Location_types";

            var dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает зрителя по id.
        /// </summary>
        public static DataRow GetViewerById(out bool isConnected, int id)
        {
            var query =
                "SELECT surname, name, patronymic, " +
                "(SELECT gender_name FROM Gender WHERE gender_id = Viewers.gender_id) AS gender_name," +
                $"phone_number, birth_date FROM Viewers WHERE viewer_id={id}";

            var dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            if (dataTable != null && dataTable.Rows.Count == 1) return dataTable.Rows[0];

            return null;
        }
        
        /// <summary>
        ///     Получает место по id.
        /// </summary>
        public static DataRow GetLocationById(out bool isConnected, int id)
        {
            var query =
                "SELECT location_name, (SELECT city_name FROM Cities WHERE city_id = Locations.city_id) AS city_name, address, " +
                "(SELECT location_type_name FROM Location_types WHERE location_type_id = Locations.location_type_id) AS location_type, " +
                $"capacity, description FROM Locations WHERE location_id={id}";

            var dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            if (dataTable != null && dataTable.Rows.Count == 1) return dataTable.Rows[0];

            return null;
        }
    }
}