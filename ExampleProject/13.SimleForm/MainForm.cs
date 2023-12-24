using _13.SimleForm.Options;
using System.Data.SqlClient;
using System.Drawing;

namespace _13.SimleForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnDatabaseDelete_Click(object sender, EventArgs e)
        {
            int index = dgvDatabases.CurrentCell.RowIndex;
            string name = (string)dgvDatabases.Rows[index].Cells[0].Value;
            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.DeleteDatabase(name);
            //MessageBox.Show("Row index", index.ToString());
            LoadListDatabase();
        }

        private void dgvDatabases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDatabaseAdd_Click(object sender, EventArgs e)
        {
            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.CreateDatabase();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            int index = dgvDatabases.CurrentCell.RowIndex;
            string name = (string)dgvDatabases.Rows[index].Cells[0].Value;
            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.RenameDatabase(name);
            LoadListDatabase();
        }
    }
}
