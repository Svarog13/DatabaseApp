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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuHead = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsConnectionDB = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatabases = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteDatabase = new System.Windows.Forms.Button();
            this.btnDatabaseCreation = new System.Windows.Forms.Button();
            this.btnRanameDatabase = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.menuHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabases)).BeginInit();
            this.SuspendLayout();
            // 
            // menuHead
            // 
            this.menuHead.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuHead.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuHead.Location = new System.Drawing.Point(0, 0);
            this.menuHead.Name = "menuHead";
            this.menuHead.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuHead.Size = new System.Drawing.Size(933, 24);
            this.menuHead.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // fileExit
            // 
            this.fileExit.Name = "fileExit";
            this.fileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.fileExit.Size = new System.Drawing.Size(144, 22);
            this.fileExit.Text = "Вихід";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsConnectionDB});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.optionsToolStripMenuItem.Text = "Налаштування";
            // 
            // optionsConnectionDB
            // 
            this.optionsConnectionDB.Name = "optionsConnectionDB";
            this.optionsConnectionDB.Size = new System.Drawing.Size(182, 22);
            this.optionsConnectionDB.Text = "Підключення до БД";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(298, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Керування Базами даних";
            // 
            // dgvDatabases
            // 
            this.dgvDatabases.AllowUserToAddRows = false;
            this.dgvDatabases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvDatabases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName});
            this.dgvDatabases.Location = new System.Drawing.Point(10, 101);
            this.dgvDatabases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDatabases.Name = "dgvDatabases";
            this.dgvDatabases.ReadOnly = true;
            this.dgvDatabases.RowHeadersWidth = 51;
            this.dgvDatabases.RowTemplate.Height = 29;
            this.dgvDatabases.Size = new System.Drawing.Size(912, 296);
            this.dgvDatabases.TabIndex = 4;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Назва";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // btnDeleteDatabase
            // 
            this.btnDeleteDatabase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteDatabase.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteDatabase.Location = new System.Drawing.Point(798, 426);
            this.btnDeleteDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteDatabase.Name = "btnDeleteDatabase";
            this.btnDeleteDatabase.Size = new System.Drawing.Size(124, 38);
            this.btnDeleteDatabase.TabIndex = 5;
            this.btnDeleteDatabase.Text = "Видалить";
            this.btnDeleteDatabase.UseVisualStyleBackColor = true;
            this.btnDeleteDatabase.Click += new System.EventHandler(this.btnDeleteDatabase_Click_1);
            // 
            // btnDatabaseCreation
            // 
            this.btnDatabaseCreation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDatabaseCreation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDatabaseCreation.Location = new System.Drawing.Point(12, 419);
            this.btnDatabaseCreation.Name = "btnDatabaseCreation";
            this.btnDatabaseCreation.Size = new System.Drawing.Size(147, 36);
            this.btnDatabaseCreation.TabIndex = 6;
            this.btnDatabaseCreation.Text = "Create new";
            this.btnDatabaseCreation.UseVisualStyleBackColor = true;
            this.btnDatabaseCreation.Click += new System.EventHandler(this.btnDatabaseCreation_Click);
            // 
            // btnRanameDatabase
            // 
            this.btnRanameDatabase.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRanameDatabase.ForeColor = System.Drawing.Color.Olive;
            this.btnRanameDatabase.Location = new System.Drawing.Point(196, 419);
            this.btnRanameDatabase.Name = "btnRanameDatabase";
            this.btnRanameDatabase.Size = new System.Drawing.Size(229, 36);
            this.btnRanameDatabase.TabIndex = 7;
            this.btnRanameDatabase.Text = "Перейменувати БД";
            this.btnRanameDatabase.UseVisualStyleBackColor = true;
            this.btnRanameDatabase.Click += new System.EventHandler(this.btnRanameDatabase_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewName.Location = new System.Drawing.Point(431, 419);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(235, 36);
            this.txtNewName.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 472);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.btnRanameDatabase);
            this.Controls.Add(this.btnDatabaseCreation);
            this.Controls.Add(this.btnDeleteDatabase);
            this.Controls.Add(this.dgvDatabases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuHead);
            this.MainMenuStrip = this.menuHead;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Магазин";
            this.menuHead.ResumeLayout(false);
            this.menuHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
