using SixLabors.ImageSharp.Formats.Webp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _13.SimleForm.Categories
{
    partial class CategoryCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            pbImage = new PictureBox();
            btnCreateCategory = new Button();
            btnCencel = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(211, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 40);
            label1.TabIndex = 4;
            label1.Text = "Створення категорії";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 23);
            txtName.TabIndex = 6;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 5;
            label2.Text = "Назва";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 162);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(380, 207);
            txtDescription.TabIndex = 8;
            txtDescription.TextChanged += textDescription_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 7;
            label3.Text = "Опис";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(421, 162);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(207, 207);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 9;
            pbImage.TabStop = false;
            // 
            // btnCreateCategory
            // 
            btnCreateCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateCategory.ForeColor = Color.Green;
            btnCreateCategory.Location = new Point(12, 390);
            btnCreateCategory.Name = "btnCreateCategory";
            btnCreateCategory.Size = new Size(184, 48);
            btnCreateCategory.TabIndex = 10;
            btnCreateCategory.Text = "Створити категорію";
            btnCreateCategory.UseVisualStyleBackColor = true;
            btnCreateCategory.Click += btnCreateCategory_Click;
            // 
            // btnCencel
            // 
            btnCencel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCencel.ForeColor = Color.Red;
            btnCencel.Location = new Point(509, 390);
            btnCencel.Name = "btnCencel";
            btnCencel.Size = new Size(119, 48);
            btnCencel.TabIndex = 11;
            btnCencel.Text = "Відхилити";
            btnCencel.UseVisualStyleBackColor = true;
            btnCencel.Click += btnCencel_Click;
            // 
            // CategoryCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 450);
            Controls.Add(btnCencel);
            Controls.Add(btnCreateCategory);
            Controls.Add(pbImage);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CategoryCreateForm";
            Text = "CategoryCreatingForm";
            Load += CategoryCreateForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private PictureBox pbImage;
        private Button btnCreateCategory;
        private Button btnCencel;
    }
}