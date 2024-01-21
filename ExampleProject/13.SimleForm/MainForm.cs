using _13.SimleForm.Categories;
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
            try
            {
                DatabaseManager databaseManager = new DatabaseManager();
                databaseManager.CreateDatabase(txtNewName.Text);
                LoadListDatabase();
                txtNewName.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ўось п≥шло не так");
            }
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
                MessageBox.Show("¬и не ввели нове ≥м'€!");
            }


        }

        private void dgvDatabases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDatabases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle the double-click event
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the double-clicked cell
                string dataBaseName = (string)dgvDatabases.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                tablesForm dlg = new tablesForm();
                dlg.DatabaseName = dataBaseName;
                dlg.ShowDialog();
            }
        }

        private void categoriesWorkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryCreateForm dlg = new CategoryCreateForm();
            dlg.ShowDialog();
        }
    }
}
