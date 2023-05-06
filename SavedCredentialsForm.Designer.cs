using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class SavedCredentialsForm
    {
        private System.ComponentModel.IContainer components = null;

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
            websiteComboBox = new ComboBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            newPasswordButton = new Button();
            SuspendLayout();
            // 
            // websiteComboBox
            // 
            websiteComboBox.FormattingEnabled = true;
            websiteComboBox.Location = new Point(188, 57);
            websiteComboBox.Margin = new Padding(4, 3, 4, 3);
            websiteComboBox.Name = "websiteComboBox";
            websiteComboBox.Size = new Size(140, 23);
            websiteComboBox.TabIndex = 0;
            websiteComboBox.SelectedIndexChanged += websiteComboBox_SelectedIndexChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(184, 96);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(63, 15);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(184, 125);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(60, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // newPasswordButton
            // 
            newPasswordButton.Location = new Point(17, 14);
            newPasswordButton.Name = "newPasswordButton";
            newPasswordButton.Size = new Size(93, 23);
            newPasswordButton.TabIndex = 3;
            newPasswordButton.Text = "New Password";
            newPasswordButton.UseVisualStyleBackColor = true;
            newPasswordButton.Click += newPasswordButton_Click;
            // 
            // SavedCredentialsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 301);
            Controls.Add(newPasswordButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(websiteComboBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SavedCredentialsForm";
            Text = "SavedCredentialsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox websiteComboBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private Button newPasswordButton;
    }
}
