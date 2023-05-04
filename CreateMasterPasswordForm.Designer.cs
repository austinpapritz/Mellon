namespace WinFormsApp1
{
    partial class CreateMasterPasswordForm
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
            nicknameLabel.Location = new Point(30, 30);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new Size(58, 15);
            nicknameLabel.TabIndex = 0;
            nicknameLabel.Text = "Nickname";
            // 
            // masterPasswordLabel
            // 
            masterPasswordLabel.AutoSize = true;
            masterPasswordLabel.Location = new Point(30, 80);
            masterPasswordLabel.Name = "masterPasswordLabel";
            masterPasswordLabel.Size = new Size(100, 15);
            masterPasswordLabel.TabIndex = 1;
            masterPasswordLabel.Text = "Master Password";
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(30, 130);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(107, 15);
            confirmPasswordLabel.TabIndex = 2;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // nicknameTextBox
            // 
            nicknameTextBox.Location = new Point(150, 27);
            nicknameTextBox.Name = "nicknameTextBox";
            nicknameTextBox.Size = new Size(200, 23);
            nicknameTextBox.TabIndex = 3;
            // 
            // masterPasswordTextBox
            // 
            masterPasswordTextBox.Location = new Point(150, 77);
            masterPasswordTextBox.Name = "masterPasswordTextBox";
            masterPasswordTextBox.Size = new Size(200, 23);
            masterPasswordTextBox.TabIndex = 4;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(150, 127);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(200, 23);
            confirmPasswordTextBox.TabIndex = 5;
            // 
            // saveMasterPasswordButton
            // 
            saveMasterPasswordButton.Location = new Point(150, 177);
            saveMasterPasswordButton.Name = "saveMasterPasswordButton";
            saveMasterPasswordButton.Size = new Size(200, 23);
            saveMasterPasswordButton.TabIndex = 6;
            saveMasterPasswordButton.Text = "Save Master Password";
            saveMasterPasswordButton.UseVisualStyleBackColor = true;
            saveMasterPasswordButton.Click += SaveMasterPasswordButton_Click;
            // 
            // CreateMasterPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 200);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(masterPasswordTextBox);
            Controls.Add(nicknameTextBox);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(masterPasswordLabel);
            Controls.Add(nicknameLabel);
            Controls.Add(saveMasterPasswordButton);
            Name = "CreateMasterPasswordForm";
            Text = "Create Master Password";
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