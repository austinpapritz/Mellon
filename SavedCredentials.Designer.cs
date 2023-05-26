using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class SavedCredentials
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
            SuspendLayout();
            // 
            // websiteComboBox
            // 
            websiteComboBox.Dock = DockStyle.Top;
            websiteComboBox.FormattingEnabled = true;
            websiteComboBox.Location = new Point(0, 0);
            websiteComboBox.Margin = new Padding(5, 3, 5, 3);
            websiteComboBox.Name = "websiteComboBox";
            websiteComboBox.Size = new Size(378, 25);
            websiteComboBox.TabIndex = 0;
            websiteComboBox.SelectedIndexChanged += websiteComboBox_SelectedIndexChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(26, 107);
            usernameLabel.Margin = new Padding(5, 0, 5, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(73, 17);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(26, 172);
            passwordLabel.Margin = new Padding(5, 0, 5, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 17);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // SavedCredentials
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 69, 57);
            ClientSize = new Size(378, 341);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(websiteComboBox);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 3, 5, 3);
            Name = "SavedCredentials";
            Text = "Saved Credentials";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox websiteComboBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}
