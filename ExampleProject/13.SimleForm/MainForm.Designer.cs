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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuHead = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileExit = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            optionsConnectionDB = new ToolStripMenuItem();
            label1 = new Label();
            dgvDatabases = new DataGridView();
            ColName = new DataGridViewTextBoxColumn();
            btnDatabaseDelete = new Button();
            menuHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatabases).BeginInit();
            SuspendLayout();
            // 
            // menuHead
            // 
            menuHead.ImageScalingSize = new Size(20, 20);
            menuHead.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem });
            menuHead.Location = new Point(0, 0);
            menuHead.Name = "menuHead";
            menuHead.Padding = new Padding(5, 2, 0, 2);
            menuHead.Size = new Size(700, 24);
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
            fileExit.Click += fileExit_Click;
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
            optionsConnectionDB.Click += optionsConnectionDB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(224, 44);
            label1.Name = "label1";
            label1.Size = new Size(259, 25);
            label1.TabIndex = 3;
            label1.Text = "Керування базами данних";
            label1.Click += label1_Click;
            // 
            // dgvDatabases
            // 
            dgvDatabases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvDatabases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatabases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatabases.Columns.AddRange(new DataGridViewColumn[] { ColName });
            dgvDatabases.Location = new Point(12, 81);
            dgvDatabases.Name = "dgvDatabases";
            dgvDatabases.ReadOnly = true;
            dgvDatabases.RowTemplate.Height = 25;
            dgvDatabases.Size = new Size(676, 214);
            dgvDatabases.TabIndex = 4;
            dgvDatabases.CellContentClick += dgvDatabases_CellContentClick;
            // 
            // ColName
            // 
            ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColName.HeaderText = "Назва";
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // btnDatabaseDelete
            // 
            btnDatabaseDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatabaseDelete.ForeColor = Color.Red;
            btnDatabaseDelete.Location = new Point(598, 301);
            btnDatabaseDelete.Name = "btnDatabaseDelete";
            btnDatabaseDelete.Size = new Size(90, 31);
            btnDatabaseDelete.TabIndex = 5;
            btnDatabaseDelete.Text = "Видалити";
            btnDatabaseDelete.UseVisualStyleBackColor = true;
            btnDatabaseDelete.Click += btnDatabaseDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnDatabaseDelete);
            Controls.Add(dgvDatabases);
            Controls.Add(label1);
            Controls.Add(menuHead);
            MainMenuStrip = menuHead;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Магазин";
            Load += MainForm_Load;
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
        private Button btnDatabaseDelete;
    }
}
