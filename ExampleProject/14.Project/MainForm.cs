namespace _14.Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            MessageBox.Show("Привіт "+ name);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
