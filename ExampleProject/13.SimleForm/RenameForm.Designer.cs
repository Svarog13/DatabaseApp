namespace _13.SimleForm
{
    partial class RenameForm
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
            label2 = new Label();
            txtNewName = new TextBox();
            btnAccept = new Button();
            btnCencel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(197, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 0;
            label1.Text = "Зміна імені бази данних";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(205, 17);
            label2.TabIndex = 1;
            label2.Text = "Вкажіть нове ім'я бази данних";
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(223, 69);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(360, 23);
            txtNewName.TabIndex = 2;
            txtNewName.TextChanged += txtNewName_TextChanged;
            // 
            // btnAccept
            // 
            btnAccept.ForeColor = Color.Green;
            btnAccept.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccept.Location = new Point(12, 144);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(121, 23);
            btnAccept.TabIndex = 3;
            btnAccept.Text = "Підтвердити";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCencel
            // 
            btnCencel.Location = new Point(501, 144);
            btnCencel.Name = "btnCencel";
            btnCencel.Size = new Size(110, 23);
            btnCencel.TabIndex = 4;
            btnCencel.Text = "Відмінити";
            btnCencel.UseVisualStyleBackColor = true;
            btnCencel.Click += btnCencel_Click;
            // 
            // RenameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 179);
            Controls.Add(btnCencel);
            Controls.Add(btnAccept);
            Controls.Add(txtNewName);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Blue;
            Name = "RenameForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNewName;
        private Button btnAccept;
        private Button btnCencel;
    }
}