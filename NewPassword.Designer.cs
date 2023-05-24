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
            website.Location = new Point(351, 120);
            website.Name = "website";
            website.Size = new Size(55, 17);
            website.TabIndex = 3;
            website.Text = "website";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(347, 192);
            username.Name = "username";
            username.Size = new Size(68, 17);
            username.TabIndex = 4;
            username.Text = "username";
            // 
            // btnSavePW
            // 
            btnSavePW.Location = new Point(314, 385);
            btnSavePW.Name = "btnSavePW";
            btnSavePW.Size = new Size(137, 66);
            btnSavePW.TabIndex = 6;
            btnSavePW.Text = "Save";
            btnSavePW.UseVisualStyleBackColor = true;
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
            btnGeneratedPW.Location = new Point(306, 303);
            btnGeneratedPW.Name = "btnGeneratedPW";
            btnGeneratedPW.Size = new Size(145, 26);
            btnGeneratedPW.TabIndex = 7;
            btnGeneratedPW.Text = "Generate Password";
            btnGeneratedPW.UseVisualStyleBackColor = true;
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