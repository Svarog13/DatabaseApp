using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _14.CategoryForm
{
    public partial class mainForm : Form
    {
        private string categoryName;
        private string categoryDescription;
        private string categoryImage;

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            categoryName = txtName.Text;
            categoryDescription = txtDescription.Text;
            categoryImage = txtImage.Text;
            string conStr = "Data Source=20.65.144.204;User ID=kaban;Password=9[nV`e7VN`0%;MultipleActiveResultSets=true;";

            try
            {
                using (var con = new SqlConnection(conStr))
                {
                    con.Open();
                    Category c = new Category();
                    string sql = "INSERT INTO tblCategories " +
                                 "(Name, Description, [Image], CreatedDate) " +
                                 "VALUES(@Name, @Description, @Image, @CreatedDate);";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, con))
                    {
                        sqlCommand.Parameters.AddWithValue("@Name", categoryName);
                        sqlCommand.Parameters.AddWithValue("@Description", categoryDescription);
                        // Assuming txtImage.Text contains the path to the image file
                        string imageName = ImageWorker.ImageSave(categoryImage);
                        sqlCommand.Parameters.AddWithValue("@Image", imageName);
                        sqlCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                        sqlCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Завантаження успішне!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка створення!");
            }
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateCategory()
        {
            MessageBox.Show($"Створено нову категорію:\nНазва: {categoryName}\nОпис: {categoryDescription}\nЗображення: {categoryImage}",
                            "Створення категорії", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}