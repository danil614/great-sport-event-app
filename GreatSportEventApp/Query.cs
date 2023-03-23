using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace GreatSportEventApp
{
    public static class Query
    {
        public static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        /// <summary>
        ///     Получает режим доступа по логину и паролю.
        /// </summary>
        public static CurrentUser GetAccessMode(string login, string password, out bool isConnected)
        {
            string query = $"CALL get_access_mode('{login}', '{GetHash(password)}')";
            DataTable dataTable = DatabaseConnection.GetDataTable(query);

            if (dataTable == null)
            {
                isConnected = false;
                return new CurrentUser();
            }

            isConnected = true;

            if(dataTable.Rows.Count == 1)
            {
                if (int.TryParse(dataTable.Rows[0]["access_mode"].ToString(), out int mode))
                {
                    int.TryParse(dataTable.Rows[0]["employee_id"].ToString(), out int employeeId);
                    return new CurrentUser((UserType)mode, employeeId);
                }
            }

            return new CurrentUser();
        }

        /// <summary>
        ///     Получает всех зрителей.
        /// </summary>
        public static DataTable GetListViewers(out bool isConnected)
        {
            const string query = 
                @"SELECT viewer_id AS 'Номер', CONCAT(surname, ' ', name, ' ', patronymic) AS 'ФИО',
                  (SELECT gender_name FROM Gender WHERE gender_id = Viewers.gender_id) AS 'Пол',
                  phone_number AS 'Номер телефона', birth_date AS 'Дата рождения',
                  number_purchases AS 'Количество покупок' FROM Viewers";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает всех сотрудников.
        /// </summary>
        public static DataTable GetListEmployees(out bool isConnected)
        {
            const string query =
                @"SELECT employee_id AS 'Номер', CONCAT(surname, ' ', name, ' ', patronymic) AS 'ФИО',
                  (SELECT Gender.gender_name FROM Gender WHERE Gender.gender_id = Employees.gender_id) AS 'Пол',
                  phone_number AS 'Номер телефона', birth_date AS 'Дата рождения',
                  (SELECT Positions.position_name FROM Positions WHERE Positions.position_id = Employees.position_id) AS 'Должность',
                  (SELECT Teams.team_name FROM Teams WHERE Teams.team_id = Employees.team_id) AS 'Команда'
                  FROM Employees";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает все билеты.
        /// </summary>
        public static DataTable GetListTickets(out bool isConnected)
        {
            const string query =
                  @"SELECT
                    ticket_id AS 'Номер',
                    (
                        SELECT
                            CONCAT(
                                Viewers.surname,
                                ' ',
                                Viewers.name,
                                ' ',
                                Viewers.patronymic
                            )
                        FROM
                            Viewers
                        WHERE
                        Viewers.viewer_id = Tickets.viewer_id
                    ) AS 'Зритель',
                    (
                        SELECT
                            CONCAT(
                                Employees.surname,
                                ' ',
                                Employees.name,
                                ' ',
                                Employees.patronymic
                            )
                        FROM
                            Employees
                        WHERE
                            Employees.employee_id = Tickets.employee_id
                    ) AS 'Продавец',
                    Seats.seat_name AS 'Место',
                    Seats.seat_price AS 'Цена',
                    (
                        SELECT
                            CONCAT(
                                Types.type_name,
                                ': ',
                                Cities.city_name,
                                ', ',
                                Locations.location_name,
                                ', начало: ',
                                DATE_FORMAT(
                                    Sport_events.sport_event_date_time,
                                    '%d.%m.%Y %H:%i'
                                )
                            )
                        FROM
                            Sport_events,
                            Cities,
                            Locations,
                            Types
                        WHERE
                            Sport_events.sport_event_id = Seats.sport_event_id AND
                            Cities.city_id = Locations.city_id AND Locations.location_id = Sport_events.location_id AND
                            Sport_events.type_id = Types.type_id
                    ) AS 'Мероприятие',
                    sale_date_time AS 'Дата продажи'
                    FROM
                        Tickets,
                        Seats
                    WHERE
                        Seats.seat_id = Tickets.seat_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает все места расположения.
        /// </summary>
        public static DataTable GetListLocations(out bool isConnected)
        {
            const string query = @"SELECT location_id AS 'Номер', location_name AS 'Название',
                                 (SELECT city_name FROM Cities WHERE Cities.city_id = Locations.city_id) AS 'Город',
                                 address AS 'Адрес',
                                 (SELECT type_name FROM Types WHERE Types.type_id = Locations.location_type_id) AS 'Тип места',
                                 capacity AS 'Вместимость' FROM Locations";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает все спортивные мероприятия.
        /// </summary>
        public static DataTable GetListSportEvents(out bool isConnected)
        {
            const string query =
                @"SELECT
                   Sport_events.sport_event_id AS id,
                   Types.type_name AS 'Тип мероприятия',
                   CONCAT(Cities.city_name, ', ', Locations.location_name) AS 'Место',
                   DATE_FORMAT(Sport_events.sport_event_date_time, '%d.%m.%Y %H:%i') AS 'Начало',
                   TIME_FORMAT(Sport_events.duration, '%H ч. %i мин.') AS 'Длительность'
                  FROM
                   Sport_events, Cities, Locations, Types
                  WHERE
                   Cities.city_id = Locations.city_id AND
                   Locations.location_id = Sport_events.location_id AND
                   Sport_events.type_id = Types.type_id
                  ORDER BY
                   Sport_events.sport_event_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает все спортивные мероприятия с командами.
        /// </summary>
        public static DataTable GetListSportEventsTeams(out bool isConnected)
        {
            const string query = 
                @"SELECT
                  Sport_events.sport_event_id AS id,
                  CONCAT(Types.type_name, ': ', Cities.city_name, ', ',
                  Locations.location_name, ', начало: ',
                  DATE_FORMAT(sport_event_date_time, '%d.%m.%Y %H:%i'), ', длительность: ',
                  TIME_FORMAT(duration, '%H ч. %i мин.')) AS name,
                  (SELECT Teams.team_id FROM Teams, Participation_events
                   WHERE Teams.team_id = Participation_events.team_id AND Participation_events.sport_event_id = Sport_events.sport_event_id
                   LIMIT 1) AS teams
                  FROM
                  Sport_events, Cities, Locations, Types
                  WHERE
                  Cities.city_id = Locations.city_id AND Locations.location_id = Sport_events.location_id AND Sport_events.type_id = Types.type_id
                  ORDER BY Sport_events.sport_event_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает все спортивные мероприятия с сотрудниками.
        /// </summary>
        public static DataTable GetListSportEventsEmployees(out bool isConnected)
        {
            const string query =
                @"SELECT
                  Sport_events.sport_event_id AS id,
                  CONCAT(Types.type_name, ': ', Cities.city_name, ', ',
                  Locations.location_name, ', начало: ',
                  DATE_FORMAT(sport_event_date_time, '%d.%m.%Y %H:%i'), ', длительность: ',
                  TIME_FORMAT(duration, '%H ч. %i мин.')) AS name,
                  (SELECT Organisation_events.employee_id FROM Organisation_events
                   WHERE Organisation_events.sport_event_id = Sport_events.sport_event_id
                   LIMIT 1) AS employees
                  FROM
                  Sport_events, Cities, Locations, Types
                  WHERE
                  Cities.city_id = Locations.city_id AND Locations.location_id = Sport_events.location_id AND Sport_events.type_id = Types.type_id
                  ORDER BY Sport_events.sport_event_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает спортивное мероприятие строкой по индексу.
        /// </summary>
        public static string GetSportEventStringById(out bool isConnected, int sportEventId)
        {
            string query = 
                $@"SELECT
                   CONCAT(Types.type_name, ': ', Cities.city_name, ', ',
                   Locations.location_name, ', начало: ',
                   DATE_FORMAT(Sport_events.sport_event_date_time, '%d.%m.%Y %H:%i'), ', длительность: ',
                   TIME_FORMAT(Sport_events.duration, '%H ч. %i мин.')) AS name
                   FROM
                   Sport_events, Cities, Locations, Types
                   WHERE
                   Sport_events.sport_event_id = {sportEventId} AND
                   Cities.city_id = Locations.city_id AND Locations.location_id = Sport_events.location_id AND Sport_events.type_id = Types.type_id
                   ORDER BY Sport_events.sport_event_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return isConnected && dataTable.Rows.Count == 1 ? dataTable.Rows[0]["name"].ToString() : "";
        }

        /// <summary>
        ///     Получает билет строкой по индексу.
        /// </summary>
        public static DataRow GetTicketById(out bool isConnected, int ticketId)
        {
            string query =
                 $@"SELECT
                    (
                        SELECT
                            CONCAT(
                                Viewers.surname,
                                ' ',
                                Viewers.name,
                                ' ',
                                Viewers.patronymic
                            )
                        FROM
                            Viewers
                        WHERE
                        Viewers.viewer_id = Tickets.viewer_id
                    ) AS viewer_name,
                    Tickets.viewer_id AS viewer_id,
                    (
                        SELECT
                            CONCAT(
                                Employees.surname,
                                ' ',
                                Employees.name,
                                ' ',
                                Employees.patronymic
                            )
                        FROM
                            Employees
                        WHERE
                            Employees.employee_id = Tickets.employee_id
                    ) AS employee_name,
                    Tickets.employee_id AS employee_id,
                    Seats.seat_name AS seat,
                    Seats.seat_price AS price,
                    (
                        SELECT
                            CONCAT(
                                Types.type_name,
                                ': ',
                                Cities.city_name,
                                ', ',
                                Locations.location_name,
                                ', начало: ',
                                DATE_FORMAT(
                                    Sport_events.sport_event_date_time,
                                    '%d.%m.%Y %H:%i'
                                )
                            )
                        FROM
                            Sport_events,
                            Cities,
                            Locations,
                            Types
                        WHERE
                            Sport_events.sport_event_id = Seats.sport_event_id AND
                            Cities.city_id = Locations.city_id AND Locations.location_id = Sport_events.location_id AND
                            Sport_events.type_id = Types.type_id
                    ) AS sport_event_name,
                    Tickets.sale_date_time AS sale_date_time,
                    Tickets.seat_id AS seat_id
                    FROM
                        Tickets,
                        Seats
                    WHERE
                        Tickets.ticket_id = {ticketId} AND Seats.seat_id = Tickets.seat_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return isConnected && dataTable.Rows.Count == 1 ? dataTable.Rows[0] : null;
        }

        /// <summary>
        ///     Получает спортивное мероприятие по индексу.
        /// </summary>
        public static DataRow GetSportEventById(out bool isConnected, int sportEventId)
        {
            string query = $@"SELECT Types.type_name AS type_name,
                                    CONCAT(Cities.city_name, ', ', Locations.location_name) AS location_full_name,
                                    Locations.location_id AS location_id,
                                    Sport_events.sport_event_date_time AS dateTimeEvent,
                                    Sport_events.duration AS duration,
                                    Sport_events.description AS description
                                    FROM
                                    Sport_events, Cities, Locations, Types
                                    WHERE Sport_events.sport_event_id = {sportEventId} AND
                                    Cities.city_id = Locations.city_id AND Locations.location_id = Sport_events.location_id AND Sport_events.type_id = Types.type_id
                                    ORDER BY Sport_events.sport_event_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable != null && dataTable.Rows.Count == 1 ? dataTable.Rows[0] : null;
        }

        /// <summary>
        ///     Получает все команды.
        /// </summary>
        public static DataTable GetListTeams(out bool isConnected)
        {
            string query = $@"SELECT Teams.team_id AS team_id, Teams.team_name AS team_name,
                              CONCAT(Cities.city_name, ', ', Locations.location_name) AS location_name,
                              Teams.rating AS rating
                              FROM
                              Teams, Cities, Locations
                              WHERE
                              Cities.city_id = Locations.city_id AND Locations.location_id = Teams.location_id
                              ORDER BY Teams.team_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает команду по индексу.
        /// </summary>
        public static DataRow GetTeamById(out bool isConnected, int teamId, int sportEventId)
        {
            string query;

            if (sportEventId == -1)
            {
                query = $@"SELECT Teams.team_name AS team_name,
                           CONCAT(Cities.city_name, ', ', Locations.location_name) AS location_full_name,
                           Teams.location_id AS location_id,
                           Teams.rating AS rating,
                           Teams.description AS description
                           FROM
                           Teams, Cities, Locations
                           WHERE Teams.team_id = {teamId} AND
                           Cities.city_id = Locations.city_id AND Locations.location_id = Teams.location_id
                           ORDER BY Teams.team_id";
            }
            else
            {
                query = $@"SELECT Teams.team_name AS team_name,
                           CONCAT(Cities.city_name, ', ', Locations.location_name) AS location_full_name,
                           Teams.location_id AS location_id,
                           Teams.rating AS rating,
                           Teams.description AS description,
                           Participation_events.score AS score
                           FROM
                           Teams, Cities, Locations, Participation_events
                           WHERE Teams.team_id = {teamId} AND
                           Cities.city_id = Locations.city_id AND Locations.location_id = Teams.location_id
                           AND Participation_events.team_id = Teams.team_id AND Participation_events.sport_event_id = {sportEventId}
                           ORDER BY Teams.team_id";
            }

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable != null && dataTable.Rows.Count == 1 ? dataTable.Rows[0] : null;
        }

        /// <summary>
        ///     Получает команды по индексу спортивного мероприятия.
        /// </summary>
        public static DataTable GetListTeamsBySportEvent(out bool isConnected, int sportEventId)
        {
            string query = $@"SELECT Teams.team_id AS id, CONCAT(Teams.team_name, ', рейтинг: ', Teams.rating, ', счет: ',
                              Participation_events.score) AS name,
                              (SELECT Athletes.athlete_id FROM Athletes WHERE Athletes.team_id = Teams.team_id LIMIT 1) AS athletes
                              FROM Teams, Participation_events
                              WHERE Teams.team_id = Participation_events.team_id AND Participation_events.sport_event_id = {sportEventId}
                              ORDER BY Teams.team_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает всех сотрудников.
        /// </summary>
        public static DataTable GetListEmployeesBySportEvent(out bool isConnected, int sportEventId)
        {
            string query = 
                $@"SELECT Employees.employee_id AS id,
                   CONCAT((SELECT Positions.position_name FROM Positions WHERE Positions.position_id = Employees.position_id), ': ',
                    Employees.surname, ' ', Employees.name, ' ', Employees.patronymic, ', дата рождения: ',
                    DATE_FORMAT(Employees.birth_date, '%d.%m.%Y')) AS name
                   FROM Employees, Organisation_events
                   WHERE Employees.employee_id = Organisation_events.employee_id AND Organisation_events.sport_event_id = {sportEventId}";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает строку команды по индексу.
        /// </summary>
        public static string GetTeamStringById(out bool isConnected, int teamId, int sportEventId)
        {
            string query = $@"SELECT CONCAT(Teams.team_name, ', рейтинг: ', Teams.rating, ', счет: ', Participation_events.score) AS name
                              FROM Teams, Participation_events
                              WHERE Participation_events.team_id = Teams.team_id  AND Participation_events.sport_event_id = {sportEventId}
                              AND Teams.team_id = {teamId}
                              ORDER BY Teams.team_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return isConnected && dataTable.Rows.Count == 1 ? dataTable.Rows[0]["name"].ToString() : "";
        }

        /// <summary>
        ///     Получает спортсменов по индексу команды.
        /// </summary>
        public static DataTable GetListAthletesByTeam(out bool isConnected, int teamId)
        {
            string query = $@"SELECT Athletes.athlete_id as id,
                              CONCAT((SELECT Positions.position_name FROM Positions WHERE Positions.position_id = Athletes.position_id), ': ',
                              Athletes.surname, ' ', Athletes.name, ' ', Athletes.patronymic, ', дата рождения: ',
                              DATE_FORMAT(Athletes.birth_date, '%d.%m.%Y')) AS name
                              FROM Athletes
                              WHERE Athletes.team_id = {teamId}
                              ORDER BY Athletes.athlete_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает всех спортсменов.
        /// </summary>
        public static DataTable GetListAthletes(out bool isConnected)
        {
            string query =
                @"SELECT Athletes.athlete_id as 'Номер',
                  CONCAT(Athletes.surname, ' ', Athletes.name, ' ', Athletes.patronymic) AS 'ФИО',
                  (SELECT Gender.gender_name FROM Gender WHERE Gender.gender_id = Athletes.gender_id) AS 'Пол',
                  Athletes.phone_number AS 'Номер телефона',
                  (SELECT Positions.position_name FROM Positions WHERE Positions.position_id = Athletes.position_id) AS 'Должность',
                  (SELECT Teams.team_name FROM Teams WHERE Teams.team_id = Athletes.team_id) AS 'Команда',
                  Athletes.birth_date AS 'Дата рождения',
                  Athletes.rating AS 'Рейтинг'
                  FROM Athletes
                  ORDER BY Athletes.athlete_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает строку спортсмена по индексу.
        /// </summary>
        public static string GetAthleteStringById(out bool isConnected, int athleteId)
        {
            string query = $@"SELECT CONCAT((SELECT Positions.position_name FROM Positions WHERE Positions.position_id = Athletes.position_id), ': ',
                              Athletes.surname, ' ', Athletes.name, ' ', Athletes.patronymic, ', дата рождения: ',
                              DATE_FORMAT(Athletes.birth_date, '%d.%m.%Y')) AS name
                              FROM Athletes
                              WHERE Athletes.athlete_id = {athleteId}
                              ORDER BY Athletes.athlete_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return isConnected && dataTable.Rows.Count == 1 ? dataTable.Rows[0]["name"].ToString() : "";
        }

        /// <summary>
        ///     Получает строку спортсмена по индексу.
        /// </summary>
        public static string GetEmployeeStringById(out bool isConnected, int employeeId)
        {
            string query = 
                $@"SELECT CONCAT((SELECT Positions.position_name FROM Positions WHERE Positions.position_id = Employees.position_id), ': ',
                   Employees.surname, ' ', Employees.name, ' ', Employees.patronymic, ', дата рождения: ',
                   DATE_FORMAT(Employees.birth_date, '%d.%m.%Y')) AS name
                   FROM Employees
                   WHERE Employees.employee_id = {employeeId}
                   ORDER BY Employees.employee_id";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return isConnected && dataTable.Rows.Count == 1 ? dataTable.Rows[0]["name"].ToString() : "";
        }

        public static int GetTypeIdByName(out bool isConnected, string typeName)
        {
            string query = $@"SELECT type_id FROM Types WHERE type_name = '{typeName}'";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable != null && dataTable.Rows.Count == 1 ? (int)dataTable.Rows[0]["type_id"] : -1;
        }

        /// <summary>
        ///     Получает всех пользователей.
        /// </summary>
        public static DataTable GetListUsers(out bool isConnected)
        {
            const string query =
              @"SELECT login AS 'Логин', access_mode AS 'Режим доступа',
                CONCAT(surname, ' ', name, ' ', patronymic) AS 'ФИО',
                (SELECT gender_name FROM Gender WHERE gender_id = Employees.gender_id) AS 'Пол',
                phone_number AS 'Номер телефона', birth_date AS 'Дата рождения'
                FROM Users INNER JOIN Employees USING(employee_id)
                UNION
                SELECT login AS 'Логин', access_mode AS 'Режим доступа',
                CONCAT(surname, ' ', name, ' ', patronymic) AS 'ФИО',
                (SELECT gender_name FROM Gender WHERE gender_id = Viewers.gender_id) AS 'Пол',
                phone_number AS 'Номер телефона', birth_date AS 'Дата рождения'
                FROM Users INNER JOIN Viewers USING(viewer_id)
                UNION
                SELECT login AS 'Логин', access_mode AS 'Режим доступа',
                CONCAT(surname, ' ', name, ' ', patronymic) AS 'ФИО',
                (SELECT gender_name FROM Gender WHERE gender_id = Athletes.gender_id) AS 'Пол',
                phone_number AS 'Номер телефона', birth_date AS 'Дата рождения'
                FROM Users INNER JOIN Athletes USING(athlete_id)
                UNION
                SELECT login AS 'Логин', access_mode AS 'Режим доступа',
                '' AS 'ФИО', '' AS 'Пол', '' AS 'Номер телефона', '' AS 'Дата рождения'
                FROM Users WHERE athlete_id IS NULL AND employee_id IS NULL AND viewer_id IS NULL";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Вставляет новую запись в зрителей.
        /// </summary>
        public static bool InsertViewer(string surname, string name, string patronymic, string genderName,
            string phoneNumber, string birthDate)
        {
            string query =
                @$"INSERT INTO Viewers (surname, name, patronymic, gender_id, phone_number, birth_date)
                   SELECT '{surname}', '{name}', '{patronymic}', Gender.gender_id, '{phoneNumber}', '{birthDate}'
                   FROM Gender WHERE gender_name='{genderName}'";

            bool isConnected = DatabaseConnection.RunQuery(query);

            return isConnected;
        }

        /// <summary>
        ///     Вставляет новую запись в места расположения.
        /// </summary>
        public static bool InsertLocation(string name, string city, string address, string type,
            int capacity, string description)
        {
            string query =
                "INSERT INTO Locations (location_name, city_id, address, location_type_id, capacity, description) " +
                $"SELECT '{name}', (SELECT city_id FROM Cities WHERE city_name='{city}'), " +
                $"'{address}', (SELECT type_id FROM Types WHERE type_name='{type}'), " +
                $"'{capacity}', '{description}'";

            bool isConnected = DatabaseConnection.RunQuery(query);

            return isConnected;
        }

        /// <summary>
        ///     Изменяет место по id.
        /// </summary>
        public static bool UpdateLocation(int id, string name, string city, string address, string type,
            int capacity, string description)
        {
            string query =
                $"UPDATE Locations SET location_name='{name}', " +
                $"city_id=(SELECT city_id FROM Cities WHERE city_name='{city}'), address='{address}', " +
                $"location_type_id=(SELECT type_id FROM Types WHERE type_name='{type}'), " +
                $"capacity='{capacity}', description='{description}' WHERE location_id={id}";

            bool isConnected = DatabaseConnection.RunQuery(query);

            return isConnected;
        }

        /// <summary>
        ///     Изменяет зрителя по id
        /// </summary>
        public static bool UpdateViewer(int id, string surname, string name, string patronymic, string genderName,
            string phoneNumber, string birthDate)
        {
            string query =
                $"UPDATE Viewers SET surname='{surname}', name='{name}', patronymic='{patronymic}', " +
                $"gender_id=(SELECT gender_id FROM Gender WHERE gender_name='{genderName}'), " +
                $"phone_number='{phoneNumber}', birth_date='{birthDate}'" +
                $"WHERE viewer_id={id}";

            bool isConnected = DatabaseConnection.RunQuery(query);

            return isConnected;
        }

        /// <summary>
        ///     Получает все полы.
        /// </summary>
        public static DataTable GetListGender(out bool isConnected)
        {
            const string query = "SELECT gender_name FROM Gender";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает все полы.
        /// </summary>
        public static DataTable GetListGenderAndId(out bool isConnected)
        {
            const string query = "SELECT gender_id, gender_name FROM Gender";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает все города.
        /// </summary>
        public static DataTable GetListCities(out bool isConnected)
        {
            const string query = "SELECT city_name FROM Cities ORDER BY city_name";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает все города.
        /// </summary>
        public static DataTable GetListCitiesAndId(out bool isConnected)
        {
            const string query = "SELECT city_id AS 'Код ОКТМО', city_name AS 'Название' FROM Cities ORDER BY city_name";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает все должности.
        /// </summary>
        public static DataTable GetListPositions(out bool isConnected)
        {
            const string query = "SELECT position_id, position_name FROM Positions ORDER BY position_name";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает все типы.
        /// </summary>
        public static DataTable GetListTypesIdName(out bool isConnected)
        {
            const string query = "SELECT type_id, type_name FROM Types ORDER BY type_name";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает все типы мест.
        /// </summary>
        public static DataTable GetListTypes(out bool isConnected)
        {
            const string query = "SELECT type_name FROM Types ORDER BY type_name DESC";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable;
        }

        /// <summary>
        ///     Получает зрителя по id.
        /// </summary>
        public static DataRow GetViewerById(out bool isConnected, int id)
        {
            string query = $@"SELECT surname, name, patronymic,
                             (SELECT gender_name FROM Gender WHERE gender_id = Viewers.gender_id) AS gender_name,
                             phone_number, birth_date FROM Viewers WHERE viewer_id={id}";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable != null && dataTable.Rows.Count == 1 ? dataTable.Rows[0] : null;
        }

        /// <summary>
        ///     Получает место по id.
        /// </summary>
        public static DataRow GetLocationById(out bool isConnected, int id)
        {
            string query =
                $@"SELECT location_name, (SELECT city_name FROM Cities WHERE city_id = Locations.city_id) AS city_name, address,
                   (SELECT type_name FROM Types WHERE type_id = Locations.location_type_id) AS location_type,
                   capacity, description FROM Locations WHERE location_id={id}";

            DataTable dataTable = DatabaseConnection.GetDataTable(query);
            isConnected = dataTable != null;

            return dataTable != null && dataTable.Rows.Count == 1 ? dataTable.Rows[0] : null;
        }

        /// <summary>
        ///     Удаляет пользователя по логину.
        /// </summary>
        public static bool DeleteUserByLogin(string login)
        {
            string query = $"DELETE FROM Users WHERE login='{login}'";
            bool isConnected = DatabaseConnection.RunQuery(query);
            return isConnected;
        }
    }
}