using _13.SimleForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.SimleForm
{
    public partial class tablesForm : Form
    {
        public string DatabaseName { get; set; }
        private TabelManager _tableManager;

        public tablesForm()
        {
            InitializeComponent();
        }

        private void LoadListTabels()
        {
            dgvTabels.Rows.Clear();
            var list = _tableManager.GetAllTabels();
            foreach (var name in list)
            {
                object[] row = { name };
                dgvTabels.Rows.Add(row);
            }
        }

        private void dgvTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablesForm_Load_1(object sender, EventArgs e)
        {
            _tableManager = new TabelManager(DatabaseName);
            LoadListTabels();
        }

        private void btnGenareateTabels_Click(object sender, EventArgs e)
        {
            _tableManager.CreateTabels();
            LoadListTabels();
        }
    }
}
