using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace _14.Project.Options
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            txtServerHost.Text = configuration.GetConnectionString("host");
            txtUserName.Text = configuration.GetConnectionString("user");
            txtUserPasssword.Text = configuration.GetConnectionString("password");

        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCencel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            string host = txtServerHost.Text;
            string userName = txtUserName.Text;
            string password = txtUserPasssword.Text;
            string conStr = $"Data Source={host};User ID={userName};Password={password};MultipleActiveResultSets=true;";
            try
            {
                var con = new SqlConnection(conStr);
                con.Open();
                MessageBox.Show("Успішно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення!!! " + ex.Message);
            }

        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

