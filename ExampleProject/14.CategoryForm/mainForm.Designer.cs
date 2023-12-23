namespace _14.CategoryForm
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCencel = new Button();
            btnCreateCategory = new Button();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtImage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCencel
            // 
            btnCencel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCencel.ForeColor = Color.Red;
            btnCencel.Location = new Point(608, 263);
            btnCencel.Name = "btnCencel";
            btnCencel.Size = new Size(167, 34);
            btnCencel.TabIndex = 0;
            btnCencel.Text = "Відмінити";
            btnCencel.UseVisualStyleBackColor = true;
            btnCencel.Click += btnCencel_Click;
            // 
            // btnCreateCategory
            // 
            btnCreateCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreateCategory.ForeColor = Color.Blue;
            btnCreateCategory.Location = new Point(30, 263);
            btnCreateCategory.Name = "btnCreateCategory";
            btnCreateCategory.Size = new Size(167, 35);
            btnCreateCategory.TabIndex = 1;
            btnCreateCategory.Text = "Створити";
            btnCreateCategory.UseVisualStyleBackColor = true;
            btnCreateCategory.Click += btnCreateCategory_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(30, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(570, 23);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(30, 120);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(570, 23);
            txtDescription.TabIndex = 4;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(30, 205);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(570, 23);
            txtImage.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 6;
            label1.Text = "Завантажити ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(30, 96);
            label2.Name = "label2";
            label2.Size = new Size(165, 21);
            label2.TabIndex = 7;
            label2.Text = "Завантажити допис";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(30, 181);
            label3.Name = "label3";
            label3.Size = new Size(216, 21);
            label3.TabIndex = 8;
            label3.Text = "Завантажити зображення";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtImage);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(btnCreateCategory);
            Controls.Add(btnCencel);
            Name = "mainForm";
            Text = "Категорія";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCreateCategory;
        private Button btnCencel;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtImage;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
