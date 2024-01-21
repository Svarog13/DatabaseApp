using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14.CategoryForm.Entities;
using _3.Database.Helpers;
using System.IO;


namespace _13.SimleForm.Services
{
    public class CategoryManager
    {
        private readonly SqlConnection _con;
        public CategoryManager(string databaseName)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            string host = configuration.GetConnectionString("Host");
            string user = configuration.GetConnectionString("User");
            string password = configuration.GetConnectionString("Password");
            string conStr = $"Data Source={host};User ID={user};Password={password};" +
                $"MultipleActiveResultSets=true;";
            conStr += $"Initial Catalog={databaseName};";
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
        public void Insert(string name, string description)
        {
            Category c = new Category();
            c.Name = name;
            c.Description = description;
            //Console.WriteLine("Вкажіть фото url:");
            //c.Image = Console.ReadLine();
            //var date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            //c.CreatedDate = date;
            //2004-12-08
            //2023-09-10 11:15:22
            string sql = "INSERT INTO tblCategories " +
        "(Name, Description) " +
        "VALUES(@Name, @Description);";
            SqlCommand sqlCommand = _con.CreateCommand();
            sqlCommand.CommandText = sql;

            // Create parameters and add them to the command's Parameters collection
            sqlCommand.Parameters.AddWithValue("@Name", c.Name);
            sqlCommand.Parameters.AddWithValue("@Description", c.Description);        
            sqlCommand.ExecuteNonQuery();
        }
        public void Dispose()
        {
            _con.Close();
        }
        public string GetCurrentDatabaseName()
        {
            string sql = "SELECT DB_NAME() AS DatabaseName;";
            SqlCommand sqlCommand = _con.CreateCommand();
            sqlCommand.CommandText = sql;

            string databaseName = string.Empty;

            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        databaseName = reader["DatabaseName"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting database name: {ex.Message}");
            }

            return databaseName;
        }
    }
}
