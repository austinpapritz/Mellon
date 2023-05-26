namespace WinFormsApp1
{
    partial class SignupControl
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

        private void InitializeComponent()
        {
            nicknameLabel = new Label();
            masterPasswordLabel = new Label();
            confirmPasswordLabel = new Label();
            nicknameTextBox = new TextBox();
            masterPasswordTextBox = new TextBox();
            confirmPasswordTextBox = new TextBox();
            saveMasterPasswordButton = new Button();
            hidePasswordPictureBox = new PictureBox();
            showPasswordPictureBox = new PictureBox();
            passwordMatchPictureBox = new PictureBox();
            passwordMisMatchPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hidePasswordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordMatchPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordMisMatchPictureBox).BeginInit();
            SuspendLayout();
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Font = new Font("Ringbearer", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nicknameLabel.ForeColor = Color.FromArgb(242, 197, 124);
            nicknameLabel.Location = new Point(27, 12);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new Size(81, 17);
            nicknameLabel.TabIndex = 0;
            nicknameLabel.Text = "Nickname";
            // 
            // masterPasswordLabel
            // 
            masterPasswordLabel.AutoSize = true;
            masterPasswordLabel.Font = new Font("Ringbearer", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            masterPasswordLabel.ForeColor = Color.FromArgb(242, 197, 124);
            masterPasswordLabel.Location = new Point(27, 72);
            masterPasswordLabel.Name = "masterPasswordLabel";
            masterPasswordLabel.Size = new Size(138, 17);
            masterPasswordLabel.TabIndex = 1;
            masterPasswordLabel.Text = "Master Password";
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Ringbearer", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            confirmPasswordLabel.ForeColor = Color.FromArgb(242, 197, 124);
            confirmPasswordLabel.Location = new Point(27, 132);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(150, 17);
            confirmPasswordLabel.TabIndex = 2;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // nicknameTextBox
            // 
            nicknameTextBox.BorderStyle = BorderStyle.None;
            nicknameTextBox.Location = new Point(27, 30);
            nicknameTextBox.Name = "nicknameTextBox";
            nicknameTextBox.Size = new Size(200, 16);
            nicknameTextBox.TabIndex = 3;
            // 
            // masterPasswordTextBox
            // 
            masterPasswordTextBox.BorderStyle = BorderStyle.None;
            masterPasswordTextBox.Location = new Point(27, 90);
            masterPasswordTextBox.Name = "masterPasswordTextBox";
            masterPasswordTextBox.Size = new Size(200, 16);
            masterPasswordTextBox.TabIndex = 4;
            masterPasswordTextBox.UseSystemPasswordChar = true;
            masterPasswordTextBox.TextChanged += masterPasswordTextBox_TextChanged;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BorderStyle = BorderStyle.None;
            confirmPasswordTextBox.Location = new Point(27, 150);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(200, 16);
            confirmPasswordTextBox.TabIndex = 5;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            confirmPasswordTextBox.TextChanged += confirmPasswordTextBox_TextChanged;
            // 
            // saveMasterPasswordButton
            // 
            saveMasterPasswordButton.BackColor = Color.FromArgb(58, 59, 66);
            saveMasterPasswordButton.Dock = DockStyle.Bottom;
            saveMasterPasswordButton.FlatStyle = FlatStyle.Flat;
            saveMasterPasswordButton.Font = new Font("Ringbearer", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveMasterPasswordButton.ForeColor = Color.FromArgb(242, 197, 124);
            saveMasterPasswordButton.Location = new Point(0, 182);
            saveMasterPasswordButton.Name = "saveMasterPasswordButton";
            saveMasterPasswordButton.Size = new Size(254, 69);
            saveMasterPasswordButton.TabIndex = 6;
            saveMasterPasswordButton.Text = "Submit";
            saveMasterPasswordButton.UseVisualStyleBackColor = false;
            saveMasterPasswordButton.Click += SaveMasterPasswordButton_Click;
            // 
            // hidePasswordPictureBox
            // 
            hidePasswordPictureBox.Image = Properties.Resources.eye_off;
            hidePasswordPictureBox.Location = new Point(231, 150);
            hidePasswordPictureBox.Name = "hidePasswordPictureBox";
            hidePasswordPictureBox.Size = new Size(20, 18);
            hidePasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            hidePasswordPictureBox.TabIndex = 7;
            hidePasswordPictureBox.TabStop = false;
            hidePasswordPictureBox.Click += hidePasswordPictureBox_Click;
            // 
            // showPasswordPictureBox
            // 
            showPasswordPictureBox.Image = Properties.Resources.eye;
            showPasswordPictureBox.Location = new Point(231, 150);
            showPasswordPictureBox.Name = "showPasswordPictureBox";
            showPasswordPictureBox.Size = new Size(20, 18);
            showPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showPasswordPictureBox.TabIndex = 8;
            showPasswordPictureBox.TabStop = false;
            showPasswordPictureBox.Visible = false;
            showPasswordPictureBox.Click += showPasswordPictureBox_Click;
            // 
            // passwordMatchPictureBox
            // 
            passwordMatchPictureBox.Image = Properties.Resources.check_square;
            passwordMatchPictureBox.Location = new Point(5, 149);
            passwordMatchPictureBox.Name = "passwordMatchPictureBox";
            passwordMatchPictureBox.Size = new Size(16, 19);
            passwordMatchPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            passwordMatchPictureBox.TabIndex = 9;
            passwordMatchPictureBox.TabStop = false;
            passwordMatchPictureBox.Visible = false;
            // 
            // passwordMisMatchPictureBox
            // 
            passwordMisMatchPictureBox.Image = Properties.Resources.x_square;
            passwordMisMatchPictureBox.Location = new Point(5, 149);
            passwordMisMatchPictureBox.Name = "passwordMisMatchPictureBox";
            passwordMisMatchPictureBox.Size = new Size(16, 19);
            passwordMisMatchPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            passwordMisMatchPictureBox.TabIndex = 10;
            passwordMisMatchPictureBox.TabStop = false;
            passwordMisMatchPictureBox.Visible = false;
            // 
            // SignupControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 69, 57);
            Controls.Add(passwordMisMatchPictureBox);
            Controls.Add(passwordMatchPictureBox);
            Controls.Add(showPasswordPictureBox);
            Controls.Add(hidePasswordPictureBox);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(masterPasswordTextBox);
            Controls.Add(nicknameTextBox);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(masterPasswordLabel);
            Controls.Add(nicknameLabel);
            Controls.Add(saveMasterPasswordButton);
            Location = new Point(0, 60);
            Name = "SignupControl";
            Size = new Size(254, 251);
            Load += SignupControl_Load;
            ((System.ComponentModel.ISupportInitialize)hidePasswordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordMatchPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordMisMatchPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label nicknameLabel;
        private Label masterPasswordLabel;
        private Label confirmPasswordLabel;
        private TextBox nicknameTextBox;
        private TextBox masterPasswordTextBox;
        private TextBox confirmPasswordTextBox;
        private Button saveMasterPasswordButton;
        private PictureBox hidePasswordPictureBox;
        private PictureBox showPasswordPictureBox;
        private PictureBox passwordMatchPictureBox;
        private PictureBox passwordMisMatchPictureBox;
    }
}
