using System.Xml;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;


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

            SaveCategoryToJson();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveCategoryToJson()
        {
            try
            {
                List<string> messages = LoadMessagesFromJson();

                string newMessage = $"�����: {categoryName}, ����: {categoryDescription}, ����������: {categoryImage}, ����: {DateTime.Now}";
                messages.Add(newMessage);

                var data = new
                {
                    Name = categoryName,
                    Description = categoryDescription,
                    Image = categoryImage,
                    CreatedDate = DateTime.Now
                };

                string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText("appjson.json", json);

                MessageBox.Show("������������ ������!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ���������!");
            }
        }

        private List<string> LoadMessagesFromJson()
        {
            List<string> messages = new List<string>();

            try
            {
                if (File.Exists("appjson.json"))
                {
                    string json = File.ReadAllText("appjson.json");
                    messages = JsonConvert.DeserializeObject<List<string>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������������ �����!");
            }

            return messages;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}