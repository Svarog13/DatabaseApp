namespace _13.SimleForm
{
    partial class DatabaseCreationForm
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
            lblDatabaseName = new Label();
            txtDatabaseName = new TextBox();
            btnCreateDatabase = new Button();
            SuspendLayout();
            // 
            // lblDatabaseName
            // 
            lblDatabaseName.AutoSize = true;
            lblDatabaseName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatabaseName.ForeColor = SystemColors.Highlight;
            lblDatabaseName.Location = new Point(46, 29);
            lblDatabaseName.Name = "lblDatabaseName";
            lblDatabaseName.Size = new Size(71, 30);
            lblDatabaseName.TabIndex = 0;
            lblDatabaseName.Text = "Name";
            // 
            // txtDatabaseName
            // 
            txtDatabaseName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatabaseName.Location = new Point(46, 62);
            txtDatabaseName.Name = "txtDatabaseName";
            txtDatabaseName.Size = new Size(184, 36);
            txtDatabaseName.TabIndex = 1;
            // 
            // btnCreateDatabase
            // 
            btnCreateDatabase.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateDatabase.ForeColor = SystemColors.Highlight;
            btnCreateDatabase.Location = new Point(480, 62);
            btnCreateDatabase.Name = "btnCreateDatabase";
            btnCreateDatabase.Size = new Size(124, 39);
            btnCreateDatabase.TabIndex = 2;
            btnCreateDatabase.Text = "Create";
            btnCreateDatabase.UseVisualStyleBackColor = true;
            btnCreateDatabase.Click += btnCreateDatabase_Click;
            // 
            // DatabaseCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateDatabase);
            Controls.Add(txtDatabaseName);
            Controls.Add(lblDatabaseName);
            Name = "DatabaseCreationForm";
            Text = "DatabaseCreationForm";
            Load += DatabaseCreationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatabaseName;
        private TextBox txtDatabaseName;
        private Button btnCreateDatabase;
    }
}