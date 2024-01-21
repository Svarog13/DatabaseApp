using _13.SimleForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.SimleForm
{
    public partial class DatabaseCreationForm : Form
    {

        public DatabaseCreationForm()
        {
            InitializeComponent();
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.CreateDatabase(txtDatabaseName.Text);
        }

        private void DatabaseCreationForm_Load(object sender, EventArgs e)
        {

        }
    }


}
