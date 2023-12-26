using _13.SimleForm.Options;
using _13.SimleForm.Services;
using System.Xml.Linq;

namespace _13.SimleForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadListDatabase();
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsConnectionDB_Click(object sender, EventArgs e)
        {
            ConnectionForm connectionForm = new ConnectionForm();
            connectionForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           LoadListDatabase();
        }

        private void LoadListDatabase()
        {
            dgvDatabases.Rows.Clear();
            DatabaseManager databaseManager = new DatabaseManager();
            var list = databaseManager.GetListDatabases();
            foreach (var name in list)
            {
                object[] row = { name };
                dgvDatabases.Rows.Add(row);
            }
        }

        private void btnDeleteDatabase_Click_1(object sender, EventArgs e)
        {
            int index = dgvDatabases.CurrentCell.RowIndex;
            string name = (string)dgvDatabases.Rows[index].Cells[0].Value;
            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.DeleteDatabase(name);
            //MessageBox.Show("Row index", name);
            LoadListDatabase();
        }

        private void btnDatabaseCreation_Click(object sender, EventArgs e)
        {
            DatabaseCreationForm databaseCreationForm = new DatabaseCreationForm();
            databaseCreationForm.ShowDialog();
            LoadListDatabase();
        }

        private void btnRanameDatabase_Click(object sender, EventArgs e)
        {

            int index = dgvDatabases.CurrentCell.RowIndex;
            string name = (string)dgvDatabases.Rows[index].Cells[0].Value;
            if (txtNewName.Text.Length > 0)
            {
                DatabaseManager databaseManager = new DatabaseManager();
                databaseManager.RenameDatabase(name, txtNewName.Text);
                LoadListDatabase();
            }
            else
            {
                MessageBox.Show("Ви не ввели нове ім'я!");
            }
            

        }
    }
}
