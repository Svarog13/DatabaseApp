namespace _13.SimleForm
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            menuHead = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileExit = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            optionsConnectionDB = new ToolStripMenuItem();
            label1 = new Label();
            dgvDatabases = new DataGridView();
            ColName = new DataGridViewTextBoxColumn();
            btnDeleteDatabase = new Button();
            btnDatabaseCreation = new Button();
            btnRanameDatabase = new Button();
            txtNewName = new TextBox();
            catalogMenuToolStripMenuItem = new ToolStripMenuItem();
            categoriesWorkingToolStripMenuItem = new ToolStripMenuItem();
            menuHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatabases).BeginInit();
            SuspendLayout();
            // 
            // menuHead
            // 
            menuHead.ImageScalingSize = new Size(20, 20);
            menuHead.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, catalogMenuToolStripMenuItem, optionsToolStripMenuItem });
            menuHead.Location = new Point(0, 0);
            menuHead.Name = "menuHead";
            menuHead.Padding = new Padding(5, 2, 0, 2);
            menuHead.Size = new Size(933, 24);
            menuHead.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // fileExit
            // 
            fileExit.Name = "fileExit";
            fileExit.ShortcutKeys = Keys.Control | Keys.X;
            fileExit.Size = new Size(144, 22);
            fileExit.Text = "Вихід";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsConnectionDB });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(101, 20);
            optionsToolStripMenuItem.Text = "Налаштування";
            // 
            // optionsConnectionDB
            // 
            optionsConnectionDB.Name = "optionsConnectionDB";
            optionsConnectionDB.Size = new Size(182, 22);
            optionsConnectionDB.Text = "Підключення до БД";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(298, 37);
            label1.Name = "label1";
            label1.Size = new Size(314, 32);
            label1.TabIndex = 3;
            label1.Text = "Керування Базами даних";
            // 
            // dgvDatabases
            // 
            dgvDatabases.AllowUserToAddRows = false;
            dgvDatabases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDatabases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatabases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatabases.Columns.AddRange(new DataGridViewColumn[] { ColName });
            dgvDatabases.Location = new Point(10, 101);
            dgvDatabases.Margin = new Padding(3, 2, 3, 2);
            dgvDatabases.Name = "dgvDatabases";
            dgvDatabases.ReadOnly = true;
            dgvDatabases.RowHeadersWidth = 51;
            dgvDatabases.RowTemplate.Height = 29;
            dgvDatabases.Size = new Size(912, 296);
            dgvDatabases.TabIndex = 4;
            dgvDatabases.CellContentClick += dgvDatabases_CellContentClick;
            dgvDatabases.CellDoubleClick += dgvDatabases_CellDoubleClick;
            // 
            // ColName
            // 
            ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColName.HeaderText = "Назва";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // btnDeleteDatabase
            // 
            btnDeleteDatabase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteDatabase.ForeColor = Color.Red;
            btnDeleteDatabase.Location = new Point(798, 414);
            btnDeleteDatabase.Margin = new Padding(3, 2, 3, 2);
            btnDeleteDatabase.Name = "btnDeleteDatabase";
            btnDeleteDatabase.Size = new Size(124, 38);
            btnDeleteDatabase.TabIndex = 5;
            btnDeleteDatabase.Text = "Видалити";
            btnDeleteDatabase.UseVisualStyleBackColor = true;
            btnDeleteDatabase.Click += btnDeleteDatabase_Click_1;
            // 
            // btnDatabaseCreation
            // 
            btnDatabaseCreation.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnDatabaseCreation.ForeColor = Color.Green;
            btnDatabaseCreation.Location = new Point(25, 416);
            btnDatabaseCreation.Name = "btnDatabaseCreation";
            btnDatabaseCreation.Size = new Size(210, 36);
            btnDatabaseCreation.TabIndex = 6;
            btnDatabaseCreation.Text = "Створити нову БД";
            btnDatabaseCreation.UseVisualStyleBackColor = true;
            btnDatabaseCreation.Click += btnDatabaseCreation_Click;
            // 
            // btnRanameDatabase
            // 
            btnRanameDatabase.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnRanameDatabase.ForeColor = Color.Blue;
            btnRanameDatabase.Location = new Point(274, 416);
            btnRanameDatabase.Name = "btnRanameDatabase";
            btnRanameDatabase.Size = new Size(234, 36);
            btnRanameDatabase.TabIndex = 7;
            btnRanameDatabase.Text = "Перейменувати БД";
            btnRanameDatabase.UseVisualStyleBackColor = true;
            btnRanameDatabase.Click += btnRanameDatabase_Click;
            // 
            // txtNewName
            // 
            txtNewName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewName.Location = new Point(539, 416);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(235, 36);
            txtNewName.TabIndex = 8;
            txtNewName.TextChanged += txtNewName_TextChanged;
            // 
            // catalogMenuToolStripMenuItem
            // 
            catalogMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriesWorkingToolStripMenuItem });
            catalogMenuToolStripMenuItem.Name = "catalogMenuToolStripMenuItem";
            catalogMenuToolStripMenuItem.Size = new Size(62, 20);
            catalogMenuToolStripMenuItem.Text = "Каталог";
            // 
            // categoriesWorkingToolStripMenuItem
            // 
            categoriesWorkingToolStripMenuItem.Name = "categoriesWorkingToolStripMenuItem";
            categoriesWorkingToolStripMenuItem.Size = new Size(180, 22);
            categoriesWorkingToolStripMenuItem.Text = "Категорії";
            categoriesWorkingToolStripMenuItem.Click += categoriesWorkingToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 472);
            Controls.Add(txtNewName);
            Controls.Add(btnRanameDatabase);
            Controls.Add(btnDatabaseCreation);
            Controls.Add(btnDeleteDatabase);
            Controls.Add(dgvDatabases);
            Controls.Add(label1);
            Controls.Add(menuHead);
            MainMenuStrip = menuHead;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Магазин";
            menuHead.ResumeLayout(false);
            menuHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatabases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuHead;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileExit;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem optionsConnectionDB;
        private Label label1;
        private DataGridView dgvDatabases;
        private DataGridViewTextBoxColumn ColName;
        private Button btnDeleteDatabase;
        private Button btnDatabaseCreation;
        private Button btnRanameDatabase;
        private TextBox txtNewName;
        private ToolStripMenuItem catalogMenuToolStripMenuItem;
        private ToolStripMenuItem categoriesWorkingToolStripMenuItem;
    }
}
