using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;
using _13.SimleForm.Services;
using _14.CategoryForm.Entities;

namespace _13.SimleForm.Categories
{
    public partial class CategoryCreateForm : Form
    {
        private readonly CategoryManager categoryManager;
        public CategoryCreateForm()
        {
            InitializeComponent();
            categoryManager = new CategoryManager(categoryManager.GetCurrentDatabaseName());
        }

        private void CategoryCreateForm_Load_1(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "Image", "no-image.jpg");
            //pbImage.Image = Image.FromFile(imagePath);
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            categoryManager.Insert(txtName.Text, textDescription.Text);

            MessageBox.Show("Категорію успішно створено!");
            Dispose();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string categoryName = txtName.Text;
        }

        private void textDescription_TextChanged(object sender, EventArgs e)
        {
            string categoryDescription = txtDescription.Text;
        }
    }
}
