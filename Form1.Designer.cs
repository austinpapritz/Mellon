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
            website = new Label();
            username = new Label();
            btnSavePW = new Button();
            lblGeneratePW = new Label();
            btnGeneratedPW = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 1;
            // 
            // website
            // 
            website.AutoSize = true;
            website.Location = new Point(307, 106);
            website.Name = "website";
            website.Size = new Size(47, 15);
            website.TabIndex = 3;
            website.Text = "website";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(304, 169);
            username.Name = "username";
            username.Size = new Size(59, 15);
            username.TabIndex = 4;
            username.Text = "username";
            // 
            // btnSavePW
            // 
            btnSavePW.Location = new Point(275, 340);
            btnSavePW.Name = "btnSavePW";
            btnSavePW.Size = new Size(120, 58);
            btnSavePW.TabIndex = 6;
            btnSavePW.Text = "Save";
            btnSavePW.UseVisualStyleBackColor = true;
            btnSavePW.Click += btnSave_Click;
            // 
            // lblGeneratePW
            // 
            lblGeneratePW.AutoSize = true;
            lblGeneratePW.Location = new Point(214, 239);
            lblGeneratePW.Name = "lblGeneratePW";
            lblGeneratePW.Size = new Size(0, 15);
            lblGeneratePW.TabIndex = 0;
            // 
            // btnGeneratedPW
            // 
            btnGeneratedPW.Location = new Point(268, 267);
            btnGeneratedPW.Name = "btnGeneratedPW";
            btnGeneratedPW.Size = new Size(127, 23);
            btnGeneratedPW.TabIndex = 7;
            btnGeneratedPW.Text = "Generate Password";
            btnGeneratedPW.UseVisualStyleBackColor = true;
            btnGeneratedPW.Click += new System.EventHandler(this.btnGeneratePW_Click);

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 410);
            Controls.Add(btnGeneratedPW);
            Controls.Add(lblGeneratePW);
            Controls.Add(btnSavePW);
            Controls.Add(username);
            Controls.Add(website);
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
        private Label website;
        private Label username;
        private Button btnSavePW;
        private Label lblGeneratePW;
        private Button btnGeneratedPW;
    }
}