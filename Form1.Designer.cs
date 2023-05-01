namespace WinFormsApp1
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            website = new Label();
            username = new Label();
            password = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(34, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            website.AutoSize = true;
            website.Location = new Point(34, 94);
            website.Name = "website";
            website.Size = new Size(38, 15);
            website.TabIndex = 3;
            website.Text = "website";
            website.Click += label1_Click;
            // 
            // label2
            // 
            username.AutoSize = true;
            username.Location = new Point(34, 158);
            username.Name = "username";
            username.Size = new Size(38, 15);
            username.TabIndex = 4;
            username.Text = "username";
            // 
            // label3
            // 
            password.AutoSize = true;
            password.Location = new Point(34, 224);
            password.Name = "password";
            password.Size = new Size(38, 15);
            password.TabIndex = 5;
            password.Text = "password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 410);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(website);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label website;
        private Label username;
        private Label password;
    }
}