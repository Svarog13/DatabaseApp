using _3.Database;
using _3.Database.Entities;
using _3.Database.Interfaces;
using Bogus;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace _3.Database
{
    public delegate void RecordAddedEventHandler(int recordNumber);
    /// <summary>
    /// Керування таблицею і даними по клієнтів
    /// </summary>
    public class ClientManager : IManager<Client>
    {

        private SqlConnection _conn;
        private readonly IManager<Profession> _proffesionManager;
        public event InsertCountDelegate InsertCount;

        /// <summary>
        /// Підлкючення до конкретної бази даних на сервері
        /// </summary>
        /// <param name="nameDatabase">Назва бази даних</param>
        public ClientManager(string nameDatabase)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            string conStr = configuration.GetConnectionString("MSSQLServerConnection") ?? "Data Source=.;Integrated Security=True;";
            conStr += $"Initial Catalog={nameDatabase};";

            _conn = new SqlConnection(conStr);
            _conn.Open();
            _proffesionManager = new ProfessionManager(_conn);
        }

        /// <summary>
        /// Повертаємо список усіх клієнтів
        /// </summary>
        public List<Client> GetList()
        {
            List<Client> list = new List<Client>();
            //показати список БД
            string sql = "SELECT c.Id, c.ProfessionId, c.FirstName, c.LastName, c.Phone, c.DateOfBirth, " +
                "c.CreatedDate, c.Sex, p.Name as ProfessionName " +
                "FROM tblClients  as c, tblProfessions p " +
                "WHERE c.ProfessionId = p.Id;";
            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;
            //Результа сервера будемо читати через SqlDataReeader
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Client entity = new Client();
                    entity.Id = int.Parse(reader["Id"].ToString());
                    entity.LastName = reader["LastName"].ToString();
                    entity.FirstName = reader["FirstName"].ToString();
                    entity.Phone = reader["Phone"].ToString();
                    entity.DateOfBirth = reader["DateOfBirth"].ToString();
                    entity.CreatedDate = reader["CreatedDate"].ToString();
                    entity.Sex = Boolean.Parse(reader["Sex"].ToString());
                    entity.ProfessionName = reader["ProfessionName"].ToString();
                    list.Add(entity);
                }
            }

            return list;
        }

        /// <summary>
        /// Додати клієнта
        /// </summary>
        public void Insert()
        {
            Client c = new Client();
            Console.WriteLine("Вкажіть прізвище клієнта:");
            c.LastName = Console.ReadLine();
            Console.WriteLine("Вкажіть ім'я клієнта:");
            c.FirstName = Console.ReadLine();
            Console.WriteLine("Вкажіть телефон клієнта:");
            c.Phone = Console.ReadLine();
            Console.WriteLine("Вкажіть дату народження клієнта(2004-12-08):");
            c.DateOfBirth = Console.ReadLine();
            var date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            c.CreatedDate = date;
            Console.WriteLine("Беріть професію:");
            foreach (var p in _proffesionManager.GetList())
            {
                Console.WriteLine(p);
            }
            Console.Write("->_");
            c.ProfessionId = int.Parse(Console.ReadLine());

            //2004-12-08
            //2023-09-10 11:15:22
            string sql = "INSERT INTO tblClients " +
                "(FirstName, ProfessionId, LastName, Phone, DateOfBirth, CreatedDate, Sex) " +
                $"VALUES(N'{c.FirstName}', {c.ProfessionId}, N'{c.LastName}', " +
                $"N'{c.Phone}', '{c.DateOfBirth}', '{c.CreatedDate}', {(c.Sex?1:0)});";
            SqlCommand sqlCommand = _conn.CreateCommand(); //окманди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди
            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();

            int count = 0;          
        }
        private void ClientRecordAddedHandler(int recordNumber)
        {
            Console.WriteLine($"Додано новий запис з номером {recordNumber}");
        }
        public void Dispose()
        {
            _conn.Close();
        }

        public Client GetById(int id)
        {
            string sql = $"SELECT * FROM tblClients WHERE Id = {id};";
            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    Client entity = new Client();
                    entity.Id = int.Parse(reader["Id"].ToString());
                    entity.LastName = reader["LastName"].ToString();
                    entity.FirstName = reader["FirstName"].ToString();
                    entity.Phone = reader["Phone"].ToString();
                    entity.DateOfBirth = reader["DateOfBirth"].ToString();
                    entity.CreatedDate = reader["CreatedDate"].ToString();
                    entity.Sex = Boolean.Parse(reader["Sex"].ToString());
                    entity.ProfessionId = int.Parse(reader["ProfessionId"].ToString());

                    return entity;
                }
            }

            return null;
        }

        public void Delete(Client entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
            }

            string sql = $"DELETE FROM tblClients WHERE Id = {entity.Id};";
            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine($"Record with Id {entity.Id} has been successfully deleted.");
            }
            else
            {
                Console.WriteLine($"Record with Id {entity.Id} not found or could not be deleted.");
            }
        }

        public void Update(Client entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
            }
            Console.WriteLine($"Введіть нове ім'я для клієнта {entity.FirstName}:");
            entity.FirstName = Console.ReadLine();
            Console.WriteLine($"Введіть нове прізвище для клієнта {entity.LastName}:");
            entity.LastName = Console.ReadLine();
            Console.WriteLine($"Введіть новий телефон для клієнта {entity.Phone}:");
            entity.Phone = Console.ReadLine();
            Console.WriteLine($"Введіть нову дату народження для клієнта {entity.DateOfBirth} (2004-12-08):");
            entity.DateOfBirth = Console.ReadLine();
            Console.WriteLine($"Введіть нову професію для клієнта {entity.ProfessionName}:");
            foreach (var p in _proffesionManager.GetList())
            {
                Console.WriteLine(p);
            }
            Console.Write("->_");
            entity.ProfessionId = int.Parse(Console.ReadLine());

            string sql = $"UPDATE tblClients SET " +
                         $"FirtsName = N'{entity.FirstName}', " +
                         $"LastName = N'{entity.LastName}', " +
                         $"Phone = N'{entity.Phone}', " +
                         $"DateOfBirth = N'{entity.DateOfBirth}', " +
                         $"ProfessionId = N'{entity.ProfessionId}', " +
                         $"WHERE Id  = {entity.Id};";
            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine($"Record with Id{entity.Id} has been successfully updated. ");
            }
            else
            {
                Console.WriteLine($"Record with Id {entity.Id} not found or could not be updated.");
            }
        }

        public void GenerateRandom(int count)
        {
            DateTime startTime = DateTime.Now;

            var faker = new Faker<Client>("uk")
               .RuleFor(u => u.FirstName, f => f.Name.FirstName())
               .RuleFor(u => u.LastName, f => f.Name.LastName())
               .RuleFor(u => u.CreatedDate, f =>
               {
                   return DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
               })
               .RuleFor(u => u.DateOfBirth, f =>
               {
                   return DateTime.Now.AddYears(-20).ToString("yyyy-MM-dd hh:mm:ss");
               })
               .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber());
            for (int i = 0; i < count; i++)
            {
                Client c = faker.Generate();
                c.ProfessionId = 1;
                string sql = "INSERT INTO tblClients " +
                "(FirstName, ProfessionId, LastName, Phone, DateOfBirth, CreatedDate, Sex) " +
                $"VALUES(N'{c.FirstName}', {c.ProfessionId}, N'{c.LastName}', " +
                $"N'{c.Phone}', '{c.DateOfBirth}', '{c.CreatedDate}', {(c.Sex ? 1 : 0)});";
                SqlCommand sqlCommand = _conn.CreateCommand(); //окманди виконуєються на основі підлкючення
                sqlCommand.CommandText = sql; //текст команди
                                              //виконати комнаду до сервера
                sqlCommand.ExecuteNonQuery();

                DateTime endTime = DateTime.Now;
                TimeSpan executionTime = endTime - startTime;

                Console.WriteLine($"Час генерації {count} клієнтів: {executionTime.TotalMilliseconds} мс");
                InsertCount(i + 1);
            }
        }
    }
}


