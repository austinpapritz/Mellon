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
            button1 = new Button();
            cmbWebsites = new ComboBox();
            label1 = new Label();
            lblUsernameDisplay = new Label();
            lblPasswordDisplay = new Label();
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
            // website
            // 
            website.AutoSize = true;
            website.Location = new Point(34, 94);
            website.Name = "website";
            website.Size = new Size(47, 15);
            website.TabIndex = 3;
            website.Text = "website";

            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(34, 158);
            username.Name = "username";
            username.Size = new Size(59, 15);
            username.TabIndex = 4;
            username.Text = "username";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(34, 224);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 5;
            password.Text = "password";
            // 
            // button1
            // 
            button1.Location = new Point(35, 282);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSave_Click;
            // 
            // cmbWebsites
            // 
            cmbWebsites.FormattingEnabled = true;
            cmbWebsites.Location = new Point(382, 114);
            cmbWebsites.Name = "cmbWebsites";
            cmbWebsites.Size = new Size(246, 23);
            cmbWebsites.TabIndex = 7;
            cmbWebsites.SelectedIndexChanged += cmbWebsites_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 95);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 8;
            label1.Text = "Pick a Site";
            // 
            // lblUsernameDisplay
            // 
            lblUsernameDisplay.AutoSize = true;
            lblUsernameDisplay.Location = new Point(382, 177);
            lblUsernameDisplay.Name = "lblUsernameDisplay";
            lblUsernameDisplay.Size = new Size(0, 15);
            lblUsernameDisplay.TabIndex = 9;
            // 
            // lblPasswordDisplay
            // 
            lblPasswordDisplay.AutoSize = true;
            lblPasswordDisplay.Location = new Point(382, 242);
            lblPasswordDisplay.Name = "lblPasswordDisplay";
            lblPasswordDisplay.Size = new Size(0, 15);
            lblPasswordDisplay.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 410);
            Controls.Add(lblPasswordDisplay);
            Controls.Add(lblUsernameDisplay);
            Controls.Add(label1);
            Controls.Add(cmbWebsites);
            Controls.Add(button1);
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
        private Button button1;
        private ComboBox cmbWebsites;
        private Label label1;
        private Label lblUsernameDisplay;
        private Label lblPasswordDisplay;
    }
}