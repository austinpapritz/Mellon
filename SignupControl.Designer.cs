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
            ((System.ComponentModel.ISupportInitialize)hidePasswordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).BeginInit();
            SuspendLayout();
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Location = new Point(92, 12);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new Size(61, 15);
            nicknameLabel.TabIndex = 0;
            nicknameLabel.Text = "Nickname";
            // 
            // masterPasswordLabel
            // 
            masterPasswordLabel.AutoSize = true;
            masterPasswordLabel.Location = new Point(76, 56);
            masterPasswordLabel.Name = "masterPasswordLabel";
            masterPasswordLabel.Size = new Size(96, 15);
            masterPasswordLabel.TabIndex = 1;
            masterPasswordLabel.Text = "Master Password";
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(72, 98);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(104, 15);
            confirmPasswordLabel.TabIndex = 2;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // nicknameTextBox
            // 
            nicknameTextBox.Location = new Point(25, 29);
            nicknameTextBox.Name = "nicknameTextBox";
            nicknameTextBox.Size = new Size(200, 23);
            nicknameTextBox.TabIndex = 3;
            // 
            // masterPasswordTextBox
            // 
            masterPasswordTextBox.Location = new Point(25, 73);
            masterPasswordTextBox.Name = "masterPasswordTextBox";
            masterPasswordTextBox.Size = new Size(200, 23);
            masterPasswordTextBox.TabIndex = 4;
            masterPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(25, 115);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(200, 23);
            confirmPasswordTextBox.TabIndex = 5;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // saveMasterPasswordButton
            // 
            saveMasterPasswordButton.Location = new Point(25, 144);
            saveMasterPasswordButton.Name = "saveMasterPasswordButton";
            saveMasterPasswordButton.Size = new Size(200, 23);
            saveMasterPasswordButton.TabIndex = 6;
            saveMasterPasswordButton.Text = "Save Master Password";
            saveMasterPasswordButton.UseVisualStyleBackColor = true;
            saveMasterPasswordButton.Click += SaveMasterPasswordButton_Click;
            // 
            // hidePasswordPictureBox
            // 
            hidePasswordPictureBox.Image = Properties.Resources.eye_off;
            hidePasswordPictureBox.Location = new Point(231, 118);
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
            showPasswordPictureBox.Location = new Point(231, 118);
            showPasswordPictureBox.Name = "showPasswordPictureBox";
            showPasswordPictureBox.Size = new Size(20, 18);
            showPasswordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            showPasswordPictureBox.TabIndex = 8;
            showPasswordPictureBox.TabStop = false;
            showPasswordPictureBox.Visible = false;
            showPasswordPictureBox.Click += showPasswordPictureBox_Click;
            // 
            // SignupControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(showPasswordPictureBox);
            Controls.Add(hidePasswordPictureBox);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(masterPasswordTextBox);
            Controls.Add(nicknameTextBox);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(masterPasswordLabel);
            Controls.Add(nicknameLabel);
            Controls.Add(saveMasterPasswordButton);
            Location = new Point(0, 100);
            Name = "SignupControl";
            Size = new Size(254, 174);
            ((System.ComponentModel.ISupportInitialize)hidePasswordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPasswordPictureBox).EndInit();
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
    }
}
