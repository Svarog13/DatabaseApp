namespace _13.SimleForm
{
    partial class tablesForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvTabels = new DataGridView();
            ColName = new DataGridViewTextBoxColumn();
            btnGenareateTabels = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTabels).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 4;
            label1.Text = "Таблиці бази даних";
            // 
            // dgvTabels
            // 
            dgvTabels.AllowUserToAddRows = false;
            dgvTabels.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvTabels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvTabels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabels.Columns.AddRange(new DataGridViewColumn[] { ColName });
            dgvTabels.Location = new Point(12, 57);
            dgvTabels.Margin = new Padding(3, 2, 3, 2);
            dgvTabels.Name = "dgvTabels";
            dgvTabels.ReadOnly = true;
            dgvTabels.RowHeadersWidth = 51;
            dgvTabels.RowTemplate.Height = 29;
            dgvTabels.Size = new Size(776, 296);
            dgvTabels.TabIndex = 5;
            dgvTabels.CellContentClick += dgvTables_CellContentClick;
            // 
            // ColName
            // 
            ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColName.HeaderText = "Назва";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // btnGenareateTabels
            // 
            btnGenareateTabels.FlatStyle = FlatStyle.Flat;
            btnGenareateTabels.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenareateTabels.ForeColor = Color.Blue;
            btnGenareateTabels.Location = new Point(12, 13);
            btnGenareateTabels.Name = "btnGenareateTabels";
            btnGenareateTabels.Size = new Size(147, 32);
            btnGenareateTabels.TabIndex = 6;
            btnGenareateTabels.Text = "Генерувати таблиці";
            btnGenareateTabels.UseVisualStyleBackColor = true;
            btnGenareateTabels.Click += btnGenareateTabels_Click;
            // 
            // tablesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenareateTabels);
            Controls.Add(dgvTabels);
            Controls.Add(label1);
            Name = "tablesForm";
            Text = "Керування таблицями";
            Load += tablesForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvTabels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvTabels;
        private DataGridViewTextBoxColumn ColName;
        private Button btnGenareateTabels;
    }
}