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
            btnBrowseName = new Button();
            btnBrowseDiscription = new Button();
            btnBrowseImage = new Button();
            txtName = new TextBox();
            txtDiscription = new TextBox();
            txtImage = new TextBox();
            SuspendLayout();
            // 
            // btnBrowseName
            // 
            btnBrowseName.ForeColor = Color.Blue;
            btnBrowseName.Location = new Point(621, 58);
            btnBrowseName.Name = "btnBrowseName";
            btnBrowseName.Size = new Size(119, 23);
            btnBrowseName.TabIndex = 0;
            btnBrowseName.Text = "Browse Name";
            btnBrowseName.UseVisualStyleBackColor = true;
            btnBrowseName.Click += btnBrowseName_Click;
            // 
            // btnBrowseDiscription
            // 
            btnBrowseDiscription.ForeColor = Color.Blue;
            btnBrowseDiscription.Location = new Point(621, 108);
            btnBrowseDiscription.Name = "btnBrowseDiscription";
            btnBrowseDiscription.Size = new Size(119, 23);
            btnBrowseDiscription.TabIndex = 1;
            btnBrowseDiscription.Text = "Browse Discription";
            btnBrowseDiscription.UseVisualStyleBackColor = true;
            btnBrowseDiscription.Click += btnBrowseDiscription_Click;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.ForeColor = Color.Blue;
            btnBrowseImage.Location = new Point(621, 160);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(119, 23);
            btnBrowseImage.TabIndex = 2;
            btnBrowseImage.Text = "Browse Image";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(30, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(570, 23);
            txtName.TabIndex = 3;
            // 
            // txtDiscription
            // 
            txtDiscription.Location = new Point(30, 109);
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(570, 23);
            txtDiscription.TabIndex = 4;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(30, 160);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(570, 23);
            txtImage.TabIndex = 5;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtImage);
            Controls.Add(txtDiscription);
            Controls.Add(txtName);
            Controls.Add(btnBrowseImage);
            Controls.Add(btnBrowseDiscription);
            Controls.Add(btnBrowseName);
            Name = "mainForm";
            Text = "Категорія";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBrowseDiscription;
        private Button btnBrowseImage;
        private Button btnBrowseName;
        private TextBox txtName;
        private TextBox txtDiscription;
        private TextBox txtImage;
    }
}
