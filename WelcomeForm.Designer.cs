namespace WinFormsApp1
{
    partial class WelcomeForm
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
            signUpButton = new Button();
            logInButton = new Button();
            gatesPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gatesPictureBox).BeginInit();
            SuspendLayout();
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.FromArgb(58, 59, 66);
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.Font = new Font("Ringbearer", 18F, FontStyle.Bold, GraphicsUnit.Point);
            signUpButton.ForeColor = Color.FromArgb(242, 197, 124);
            signUpButton.Location = new Point(0, 0);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(127, 60);
            signUpButton.TabIndex = 0;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += SignupButton_Click;
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.FromArgb(58, 59, 66);
            logInButton.FlatStyle = FlatStyle.Flat;
            logInButton.Font = new Font("Ringbearer", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            logInButton.ForeColor = Color.FromArgb(242, 197, 124);
            logInButton.Location = new Point(127, 0);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(127, 60);
            logInButton.TabIndex = 1;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += LoginButton_Click;
            // 
            // gatesPictureBox
            // 
            gatesPictureBox.Dock = DockStyle.Bottom;
            gatesPictureBox.Image = Properties.Resources.gates;
            gatesPictureBox.Location = new Point(0, 66);
            gatesPictureBox.Name = "gatesPictureBox";
            gatesPictureBox.Size = new Size(254, 251);
            gatesPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            gatesPictureBox.TabIndex = 2;
            gatesPictureBox.TabStop = false;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 69, 57);
            ClientSize = new Size(254, 317);
            Controls.Add(logInButton);
            Controls.Add(signUpButton);
            Controls.Add(gatesPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)gatesPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button signUpButton;
        private Button logInButton;
        private PictureBox gatesPictureBox;
    }
}