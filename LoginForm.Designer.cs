namespace WinFormsApp1
{
    partial class LoginForm
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

        private Button backButton;
        private Button loginButton;
        private Label nicknameLabel;
        private Label masterPasswordLabel;
        private TextBox nicknameTextBox;
        private TextBox masterPasswordTextBox;

        private void InitializeComponent()
        {
            backButton = new Button();
            loginButton = new Button();
            nicknameLabel = new Label();
            masterPasswordLabel = new Label();
            nicknameTextBox = new TextBox();
            masterPasswordTextBox = new TextBox();

            // backButton
            backButton.Text = "←";
            backButton.Location = new Point(12, 12);
            backButton.Click += new EventHandler(BackButton_Click);

            // loginButton
            loginButton.Text = "Log In";
            loginButton.Location = new Point(230, 135);
            loginButton.Click += new EventHandler(LoginButton_Click);

            // nicknameLabel
            nicknameLabel.AutoSize = true;
            nicknameLabel.Location = new Point(30, 60);
            nicknameLabel.Text = "Nickname";

            // masterPasswordLabel
            masterPasswordLabel.AutoSize = true;
            masterPasswordLabel.Location = new Point(30, 100);
            masterPasswordLabel.Text = "Master Password";

            // nicknameTextBox
            nicknameTextBox.Location = new Point(150, 57);
            nicknameTextBox.Size = new Size(200, 23);

            // masterPasswordTextBox
            masterPasswordTextBox.Location = new Point(150, 97);
            masterPasswordTextBox.Size = new Size(200, 23);

            // LoginForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 200);
            Controls.Add(backButton);
            Controls.Add(loginButton);
            Controls.Add(nicknameLabel);
            Controls.Add(masterPasswordLabel);
            Controls.Add(nicknameTextBox);
            Controls.Add(masterPasswordTextBox);
            Text = "Log In";
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
    }
}