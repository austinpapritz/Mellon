namespace WinFormsApp1
{
    partial class NewPassword
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
            website = new Label();
            username = new Label();
            btnSavePW = new Button();
            lblGeneratePW = new Label();
            btnGeneratedPW = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 25);
            textBox2.TabIndex = 1;
            // 
            // website
            // 
            website.AutoSize = true;
            website.Font = new Font("Ringbearer", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            website.ForeColor = Color.FromArgb(242, 197, 124);
            website.Location = new Point(239, 121);
            website.Name = "website";
            website.Size = new Size(62, 17);
            website.TabIndex = 3;
            website.Text = "website";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Ringbearer", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            username.ForeColor = Color.FromArgb(242, 197, 124);
            username.Location = new Point(239, 192);
            username.Name = "username";
            username.Size = new Size(79, 17);
            username.TabIndex = 4;
            username.Text = "username";
            // 
            // btnSavePW
            // 
            btnSavePW.BackColor = Color.FromArgb(58, 59, 66);
            btnSavePW.Dock = DockStyle.Bottom;
            btnSavePW.FlatStyle = FlatStyle.Flat;
            btnSavePW.ForeColor = Color.FromArgb(242, 197, 124);
            btnSavePW.Location = new Point(0, 401);
            btnSavePW.Name = "btnSavePW";
            btnSavePW.Size = new Size(766, 64);
            btnSavePW.TabIndex = 6;
            btnSavePW.Text = "Save";
            btnSavePW.UseVisualStyleBackColor = false;
            btnSavePW.Click += btnSave_Click;
            // 
            // lblGeneratePW
            // 
            lblGeneratePW.AutoSize = true;
            lblGeneratePW.Location = new Point(245, 271);
            lblGeneratePW.Name = "lblGeneratePW";
            lblGeneratePW.Size = new Size(0, 17);
            lblGeneratePW.TabIndex = 0;
            // 
            // btnGeneratedPW
            // 
            btnGeneratedPW.BackColor = Color.FromArgb(58, 59, 66);
            btnGeneratedPW.FlatStyle = FlatStyle.Flat;
            btnGeneratedPW.Font = new Font("Ringbearer", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeneratedPW.ForeColor = Color.FromArgb(242, 197, 124);
            btnGeneratedPW.Location = new Point(229, 303);
            btnGeneratedPW.Name = "btnGeneratedPW";
            btnGeneratedPW.Size = new Size(311, 42);
            btnGeneratedPW.TabIndex = 7;
            btnGeneratedPW.Text = "Generate Password";
            btnGeneratedPW.UseVisualStyleBackColor = false;
            btnGeneratedPW.Click += btnGeneratePW_Click;
            // 
            // NewPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 69, 57);
            ClientSize = new Size(766, 465);
            Controls.Add(btnGeneratedPW);
            Controls.Add(lblGeneratePW);
            Controls.Add(btnSavePW);
            Controls.Add(username);
            Controls.Add(website);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewPassword";
            Text = "New Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label website;
        private Label username;
        private Button btnSavePW;
        private Label lblGeneratePW;
        private Button btnGeneratedPW;
    }
}