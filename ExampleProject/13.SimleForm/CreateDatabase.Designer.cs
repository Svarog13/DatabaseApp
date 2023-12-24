namespace _13.SimleForm
{
    partial class CreateNewDatabase
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
            label2 = new Label();
            btnChangeNameAcception = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(66, 9);
            label2.Name = "label2";
            label2.Size = new Size(311, 25);
            label2.TabIndex = 2;
            label2.Text = "Введіть нову назву бази данних";
            // 
            // btnChangeNameAcception
            // 
            btnChangeNameAcception.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeNameAcception.ForeColor = Color.Green;
            btnChangeNameAcception.Location = new Point(6, 160);
            btnChangeNameAcception.Name = "btnChangeNameAcception";
            btnChangeNameAcception.Size = new Size(113, 36);
            btnChangeNameAcception.TabIndex = 3;
            btnChangeNameAcception.Text = "Підтвердити";
            btnChangeNameAcception.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(352, 160);
            button1.Name = "button1";
            button1.Size = new Size(87, 36);
            button1.TabIndex = 6;
            button1.Text = "Відмінити";
            button1.UseVisualStyleBackColor = true;
            // 
            // CreateNewDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 203);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(btnChangeNameAcception);
            Controls.Add(label2);
            Name = "CreateNewDatabase";
            Text = "CreateNewDatabase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnChangeNameAcception;
        private TextBox textBox1;
        private Button button1;
    }
}