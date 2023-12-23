namespace _14.CategoryForm
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseName_Click(object sender, EventArgs e)
        {
            string categoryName = txtName.Text;
        }

        private void btnBrowseDiscription_Click(object sender, EventArgs e)
        {
            string discriptionName = txtDiscription.Text;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            string imageName = txtImage.Text;
        }
    }
}
