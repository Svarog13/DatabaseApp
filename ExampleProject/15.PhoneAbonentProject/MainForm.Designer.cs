namespace _15.PhoneAbonentProject
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lbMainName = new Label();
            dgvAbonents = new DataGridView();
            ColName = new DataGridViewTextBoxColumn();
            btnAddAbonent = new Button();
            btnShowAbonentInfo = new Button();
            btnChangeTariff = new Button();
            btnDeleteAbonent = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAbonents).BeginInit();
            SuspendLayout();
            // 
            // lbMainName
            // 
            lbMainName.AutoSize = true;
            lbMainName.BackColor = Color.Blue;
            lbMainName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbMainName.ForeColor = Color.White;
            lbMainName.Location = new Point(224, 9);
            lbMainName.Name = "lbMainName";
            lbMainName.Size = new Size(401, 30);
            lbMainName.TabIndex = 0;
            lbMainName.Text = "Облік абонентів телефонного зв'язку";
            lbMainName.Click += label1_Click;
            // 
            // dgvAbonents
            // 
            dgvAbonents.AllowUserToAddRows = false;
            dgvAbonents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dgvAbonents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvAbonents.BackgroundColor = SystemColors.ControlLight;
            dgvAbonents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAbonents.Columns.AddRange(new DataGridViewColumn[] { ColName });
            dgvAbonents.Location = new Point(12, 53);
            dgvAbonents.Margin = new Padding(3, 2, 3, 2);
            dgvAbonents.Name = "dgvAbonents";
            dgvAbonents.ReadOnly = true;
            dgvAbonents.RowHeadersWidth = 51;
            dgvAbonents.RowTemplate.Height = 29;
            dgvAbonents.Size = new Size(476, 296);
            dgvAbonents.TabIndex = 5;
            // 
            // ColName
            // 
            ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColName.HeaderText = "Назва";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // btnAddAbonent
            // 
            btnAddAbonent.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddAbonent.ForeColor = Color.Green;
            btnAddAbonent.Location = new Point(626, 53);
            btnAddAbonent.Name = "btnAddAbonent";
            btnAddAbonent.Size = new Size(133, 55);
            btnAddAbonent.TabIndex = 6;
            btnAddAbonent.Text = "Додати абонента";
            btnAddAbonent.UseVisualStyleBackColor = true;
            btnAddAbonent.Click += btnAddAbonent_Click;
            // 
            // btnShowAbonentInfo
            // 
            btnShowAbonentInfo = new Button();
            btnShowAbonentInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnShowAbonentInfo.ForeColor = Color.Blue;
            btnShowAbonentInfo.Location = new Point(626, 134);
            btnShowAbonentInfo.Name = "btnShowAbonentInfo";
            btnShowAbonentInfo.Size = new Size(133, 60);
            btnShowAbonentInfo.TabIndex = 7;
            btnShowAbonentInfo.Text = "Показати інформацію про абонента";
            btnShowAbonentInfo.UseVisualStyleBackColor = true;
            btnShowAbonentInfo.Click += this.btnShowAbonentInfo_Click;

            // 
            // btnChangeTariff
            // 
            btnChangeTariff.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnChangeTariff.ForeColor = Color.Blue;
            btnChangeTariff.Location = new Point(626, 218);
            btnChangeTariff.Name = "btnChangeTariff";
            btnChangeTariff.Size = new Size(133, 54);
            btnChangeTariff.TabIndex = 8;
            btnChangeTariff.Text = "Змінити тариф";
            btnChangeTariff.UseVisualStyleBackColor = true;
            btnChangeTariff.Click += btnChangeTariff_Click;
            // 
            // btnDeleteAbonent
            // 
            btnDeleteAbonent.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDeleteAbonent.ForeColor = Color.Red;
            btnDeleteAbonent.Location = new Point(626, 301);
            btnDeleteAbonent.Name = "btnDeleteAbonent";
            btnDeleteAbonent.Size = new Size(133, 48);
            btnDeleteAbonent.TabIndex = 9;
            btnDeleteAbonent.Text = "Видалити абонента";
            btnDeleteAbonent.UseVisualStyleBackColor = true;
            btnDeleteAbonent.Click += btnDeleteAbonent_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 355);
            Controls.Add(btnDeleteAbonent);
            Controls.Add(btnChangeTariff);
            Controls.Add(btnShowAbonentInfo);
            Controls.Add(btnAddAbonent);
            Controls.Add(dgvAbonents);
            Controls.Add(lbMainName);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAbonents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMainName;
        private DataGridView dgvAbonents;
        private DataGridViewTextBoxColumn ColName;
        private Button btnAddAbonent;
        private Button btnShowAbonentInfo;
        private Button btnChangeTariff;
        private Button btnDeleteAbonent;
    }
}
