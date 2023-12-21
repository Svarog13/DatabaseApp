namespace _14.Project.Options
{
    partial class ConnectionForm
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
            txtServerHost = new TextBox();
            btnSave = new Button();
            btnCencel = new Button();
            txtUser = new Label();
            txtUserName = new TextBox();
            txtPassword = new Label();
            txtUserPasssword = new TextBox();
            btnCheckConnection = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 0;
            label1.Text = "Сервер";
            // 
            // txtServerHost
            // 
            txtServerHost.Location = new Point(12, 33);
            txtServerHost.Name = "txtServerHost";
            txtServerHost.Size = new Size(269, 29);
            txtServerHost.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Cornsilk;
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(326, 29);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 33);
            btnSave.TabIndex = 2;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCencel
            // 
            btnCencel.BackColor = Color.Cornsilk;
            btnCencel.ForeColor = Color.Red;
            btnCencel.Location = new Point(326, 83);
            btnCencel.Name = "btnCencel";
            btnCencel.Size = new Size(102, 35);
            btnCencel.TabIndex = 3;
            btnCencel.Text = "Скасувати";
            btnCencel.UseVisualStyleBackColor = false;
            btnCencel.Click += btnCencel_Click;
            // 
            // txtUser
            // 
            txtUser.AutoSize = true;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtUser.ForeColor = Color.Blue;
            txtUser.Location = new Point(12, 65);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(102, 21);
            txtUser.TabIndex = 4;
            txtUser.Text = "Користувач";
            txtUser.Click += label2_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(12, 89);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(269, 29);
            txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtPassword.ForeColor = Color.Blue;
            txtPassword.Location = new Point(12, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(70, 21);
            txtPassword.TabIndex = 6;
            txtPassword.Text = "Пароль";
            // 
            // txtUserPasssword
            // 
            txtUserPasssword.Location = new Point(12, 145);
            txtUserPasssword.Name = "txtUserPasssword";
            txtUserPasssword.Size = new Size(269, 29);
            txtUserPasssword.TabIndex = 7;
            txtUserPasssword.TextChanged += txtUserPassword_TextChanged;
            // 
            // btnCheckConnection
            // 
            btnCheckConnection.BackColor = Color.Cornsilk;
            btnCheckConnection.ForeColor = Color.Blue;
            btnCheckConnection.Location = new Point(12, 202);
            btnCheckConnection.Name = "btnCheckConnection";
            btnCheckConnection.Size = new Size(188, 33);
            btnCheckConnection.TabIndex = 8;
            btnCheckConnection.Text = "Перевірити з'єднання";
            btnCheckConnection.UseVisualStyleBackColor = false;
            btnCheckConnection.Click += btnCheckConnection_Click;
            // 
            // ConnectionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 250);
            Controls.Add(btnCheckConnection);
            Controls.Add(txtUserPasssword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtUser);
            Controls.Add(btnCencel);
            Controls.Add(btnSave);
            Controls.Add(txtServerHost);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "ConnectionForm";
            Text = "Підключення до сервера";
            Load += ConnectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtServerHost;
        private Button btnSave;
        private Button btnCencel;
        private Label txtUser;
        private TextBox txtUserName;
        private Label txtPassword;
        private TextBox txtUserPasssword;
        private Button btnCheckConnection;
    }
}