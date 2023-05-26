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
            loginButton.BackColor = Color.FromArgb(58, 59, 66);
            loginButton.Dock = DockStyle.Bottom;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Ringbearer", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.FromArgb(242, 197, 124);
            loginButton.Location = new Point(0, 182);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(254, 69);
            loginButton.TabIndex = 1;
            loginButton.Text = "Submit";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click;
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Font = new Font("Ringbearer", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nicknameLabel.ForeColor = Color.FromArgb(242, 197, 124);
            nicknameLabel.Location = new Point(27, 27);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new Size(81, 17);
            nicknameLabel.TabIndex = 2;
            nicknameLabel.Text = "Nickname";
            // 
            // masterPasswordLabel
            // 
            masterPasswordLabel.AutoSize = true;
            masterPasswordLabel.Font = new Font("Ringbearer", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            masterPasswordLabel.ForeColor = Color.FromArgb(242, 197, 124);
            masterPasswordLabel.Location = new Point(27, 108);
            masterPasswordLabel.Name = "masterPasswordLabel";
            masterPasswordLabel.Size = new Size(138, 17);
            masterPasswordLabel.TabIndex = 3;
            masterPasswordLabel.Text = "Master Password";
            // 
            // nicknameTextBox
            // 
            nicknameTextBox.BorderStyle = BorderStyle.None;
            nicknameTextBox.Location = new Point(27, 45);
            nicknameTextBox.Name = "nicknameTextBox";
            nicknameTextBox.Size = new Size(200, 16);
            nicknameTextBox.TabIndex = 4;
            // 
            // masterPasswordTextBox
            // 
            masterPasswordTextBox.AcceptsReturn = true;
            masterPasswordTextBox.BorderStyle = BorderStyle.None;
            masterPasswordTextBox.Location = new Point(27, 126);
            masterPasswordTextBox.Name = "masterPasswordTextBox";
            masterPasswordTextBox.Size = new Size(200, 16);
            masterPasswordTextBox.TabIndex = 5;
            masterPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // hidePasswordPictureBox
            // 
            hidePasswordPictureBox.Image = Properties.Resources.eye_off;
            hidePasswordPictureBox.Location = new Point(233, 126);
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
            showPasswordPictureBox.Location = new Point(233, 126);
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
            BackColor = Color.FromArgb(38, 69, 57);
            Controls.Add(showPasswordPictureBox);
            Controls.Add(hidePasswordPictureBox);
            Controls.Add(loginButton);
            Controls.Add(nicknameLabel);
            Controls.Add(masterPasswordLabel);
            Controls.Add(nicknameTextBox);
            Controls.Add(masterPasswordTextBox);
            Location = new Point(0, 60);
            Name = "LoginControl";
            Size = new Size(254, 251);
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
