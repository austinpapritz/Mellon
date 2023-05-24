namespace WinFormsApp1
{
    partial class LoginControl
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
        private Button loginButton;
        private Label nicknameLabel;
        private Label masterPasswordLabel;
        private TextBox nicknameTextBox;
        private TextBox masterPasswordTextBox;

        private void InitializeComponent()
        {
            loginButton = new Button();
            nicknameLabel = new Label();
            masterPasswordLabel = new Label();
            nicknameTextBox = new TextBox();
            masterPasswordTextBox = new TextBox();
            hidePasswordPictureBox = new PictureBox();
            showPasswordPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hidePasswordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(76, 113);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 1;
            loginButton.Text = "Log In";
            loginButton.Click += LoginButton_Click;
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Location = new Point(84, 12);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new Size(61, 15);
            nicknameLabel.TabIndex = 2;
            nicknameLabel.Text = "Nickname";
            // 
            // masterPasswordLabel
            // 
            masterPasswordLabel.AutoSize = true;
            masterPasswordLabel.Location = new Point(66, 67);
            masterPasswordLabel.Name = "masterPasswordLabel";
            masterPasswordLabel.Size = new Size(96, 15);
            masterPasswordLabel.TabIndex = 3;
            masterPasswordLabel.Text = "Master Password";
            // 
            // nicknameTextBox
            // 
            nicknameTextBox.Location = new Point(18, 29);
            nicknameTextBox.Name = "nicknameTextBox";
            nicknameTextBox.Size = new Size(200, 23);
            nicknameTextBox.TabIndex = 4;
            // 
            // masterPasswordTextBox
            // 
            masterPasswordTextBox.Location = new Point(18, 84);
            masterPasswordTextBox.Name = "masterPasswordTextBox";
            masterPasswordTextBox.Size = new Size(200, 23);
            masterPasswordTextBox.TabIndex = 5;
            masterPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // hidePasswordPictureBox
            // 
            hidePasswordPictureBox.Image = Properties.Resources.eye_off;
            hidePasswordPictureBox.Location = new Point(220, 87);
            hidePasswordPictureBox.Name = "hidePasswordPictureBox";
            hidePasswordPictureBox.Size = new Size(17, 20);
            hidePasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            hidePasswordPictureBox.TabIndex = 6;
            hidePasswordPictureBox.TabStop = false;
            hidePasswordPictureBox.Click += hidePasswordPictureBox_Click;
            // 
            // showPasswordPictureBox
            // 
            showPasswordPictureBox.Image = Properties.Resources.eye;
            showPasswordPictureBox.Location = new Point(220, 87);
            showPasswordPictureBox.Name = "showPasswordPictureBox";
            showPasswordPictureBox.Size = new Size(17, 20);
            showPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showPasswordPictureBox.TabIndex = 7;
            showPasswordPictureBox.TabStop = false;
            showPasswordPictureBox.Visible = false;
            showPasswordPictureBox.Click += showPasswordPictureBox_Click;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(showPasswordPictureBox);
            Controls.Add(hidePasswordPictureBox);
            Controls.Add(loginButton);
            Controls.Add(nicknameLabel);
            Controls.Add(masterPasswordLabel);
            Controls.Add(nicknameTextBox);
            Controls.Add(masterPasswordTextBox);
            Location = new Point(0, 100);
            Name = "LoginControl";
            Size = new Size(240, 174);
            Load += LoginControl_Load;
            ((System.ComponentModel.ISupportInitialize)hidePasswordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion

        private PictureBox hidePasswordPictureBox;
        private PictureBox showPasswordPictureBox;
    }
}
