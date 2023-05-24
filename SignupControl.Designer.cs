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
            SuspendLayout();
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Location = new Point(84, 12);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new Size(61, 15);
            nicknameLabel.TabIndex = 0;
            nicknameLabel.Text = "Nickname";
            // 
            // masterPasswordLabel
            // 
            masterPasswordLabel.AutoSize = true;
            masterPasswordLabel.Location = new Point(68, 56);
            masterPasswordLabel.Name = "masterPasswordLabel";
            masterPasswordLabel.Size = new Size(96, 15);
            masterPasswordLabel.TabIndex = 1;
            masterPasswordLabel.Text = "Master Password";
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(64, 98);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(104, 15);
            confirmPasswordLabel.TabIndex = 2;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // nicknameTextBox
            // 
            nicknameTextBox.Location = new Point(17, 29);
            nicknameTextBox.Name = "nicknameTextBox";
            nicknameTextBox.Size = new Size(200, 23);
            nicknameTextBox.TabIndex = 3;
            // 
            // masterPasswordTextBox
            // 
            masterPasswordTextBox.Location = new Point(17, 73);
            masterPasswordTextBox.Name = "masterPasswordTextBox";
            masterPasswordTextBox.PasswordChar = '*';
            masterPasswordTextBox.Size = new Size(200, 23);
            masterPasswordTextBox.TabIndex = 4;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(17, 115);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(200, 23);
            confirmPasswordTextBox.TabIndex = 5;
            // 
            // saveMasterPasswordButton
            // 
            saveMasterPasswordButton.Location = new Point(17, 144);
            saveMasterPasswordButton.Name = "saveMasterPasswordButton";
            saveMasterPasswordButton.Size = new Size(200, 23);
            saveMasterPasswordButton.TabIndex = 6;
            saveMasterPasswordButton.Text = "Save Master Password";
            saveMasterPasswordButton.UseVisualStyleBackColor = true;
            saveMasterPasswordButton.Click += SaveMasterPasswordButton_Click;
            // 
            // SignupControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(masterPasswordTextBox);
            Controls.Add(nicknameTextBox);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(masterPasswordLabel);
            Controls.Add(nicknameLabel);
            Controls.Add(saveMasterPasswordButton);
            Location = new Point(0, 100);
            Name = "SignupControl";
            Size = new Size(240, 174);
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
    }
}
