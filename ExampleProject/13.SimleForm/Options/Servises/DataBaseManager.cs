using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public class DatabaseManager
{
    private readonly SqlConnection _con;
    public DatabaseManager()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration configuration = builder.Build();

        string host = configuration.GetConnectionString("Host");
        string user = configuration.GetConnectionString("User");
        string password = configuration.GetConnectionString("Password");
        string conStr = $"Data Source={host};User ID={user};Password={password};MultipleActiveResultSets=true;";
        try
        {
            _con = new SqlConnection(conStr);
            _con.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Помилка підключення!!! " + ex.Message);
        }

    }
    public List<string> GetListDatabases()
    {
        var list = new List<string>();
        //показати список БД
        string sql = "SELECT name FROM sys.databases WHERE database_id > 4;";
        SqlCommand sqlCommand = _con.CreateCommand();
        sqlCommand.CommandText = sql;
        //Результа сервера будемо читати через SqlDataReeader
        using (SqlDataReader reader = sqlCommand.ExecuteReader())
        {
            Console.WriteLine("Списко база даних:");
            while (reader.Read())
            {
                list.Add(reader["name"].ToString());
            }
        }
        return list;
    }

    /// <summary>
    /// Перевірка існування БД на сервері
    /// </summary>
    /// <param name="name">Назва бази</param>
    /// <param name="conStr">Строка підлкючення</param>
    /// <returns>Повертає bool, True - якщо існує</returns>
    private bool IsExistDatabase(string name)
    {
        //Перевірка чи існує база даних
        string sql = $"IF EXISTS (SELECT name FROM sys.databases WHERE name = '{name}')" +
            " SELECT 1 AS Result" +
            " ELSE" +
            " SELECT 0 AS Result";
        SqlCommand cmd = _con.CreateCommand();
        cmd.CommandText = sql;
        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            if (reader.Read())
            {
                int result = int.Parse(reader["Result"].ToString());
                if (result > 0)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public void CreateDatabase()
    {
        Console.WriteLine("Вкажіть назву бази даних:");
        string dbName = Console.ReadLine();

        var isEsixt = IsExistDatabase(dbName);
        if (isEsixt)
        {
            Console.WriteLine("База даних {0} уже існує", dbName) ;
            return;
        }
        
        string sql = $"CREATE DATABASE {dbName};";
        SqlCommand sqlCommand = _con.CreateCommand(); 
        sqlCommand.CommandText = sql; 
        sqlCommand.ExecuteNonQuery();
        Console.WriteLine("Успішно створено БД :)");
    }
    public void DeleteDatabase(string databaseName)
    {
        var isEsixt = IsExistDatabase(databaseName);
        if (!isEsixt)
        {
            MessageBox.Show("База даних не існує" + databaseName);
            return;
        }
        string sql = $"DROP DATABASE {databaseName};";
        SqlCommand sqlCommand = _con.CreateCommand(); //команди виконуєються на основі підлкючення
        sqlCommand.CommandText = sql; //текст команди
                                      //виконати комнаду до сервера
        sqlCommand.ExecuteNonQuery();
    }
    public void RenameDatabase(string databaseName)
    {
        var isExist = IsExistDatabase(databaseName);

        if (!isExist)
        {
            MessageBox.Show($"Database '{databaseName}' does not exist.");
            return;
        }

        string newName = PromptForNewName(databaseName);

        if (string.IsNullOrEmpty(newName))
        {        
            return;
        }

        var isNewNameExist = IsExistDatabase(newName);

        if (isNewNameExist)
        {
            MessageBox.Show($"Database with the new name '{newName}' already exists.");
            return;
        }

        string sql = $"ALTER DATABASE {databaseName} MODIFY NAME = {newName};";
        SqlCommand sqlCommand = _con.CreateCommand();

        try
        {
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show($"Database '{databaseName}' has been renamed to '{newName}'.");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error renaming database: {ex.Message}");
        }
    }

    private string PromptForNewName(string currentName)
    {        
        string newName = Microsoft.VisualBasic.Interaction.InputBox($"Enter a new name for the database '{currentName}':", "Rename Database", "");
        return newName;
    }
}