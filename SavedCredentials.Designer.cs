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
            savedUsernameLabel = new Label();
            savedPasswordLabel = new Label();
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
            usernameLabel.Location = new Point(27, 97);
            usernameLabel.Margin = new Padding(5, 0, 5, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(0, 17);
            usernameLabel.TabIndex = 1;
            usernameLabel.Click += usernameLabel_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(26, 172);
            passwordLabel.Margin = new Padding(5, 0, 5, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(0, 17);
            passwordLabel.TabIndex = 2;
            passwordLabel.Click += passwordLabel_Click;
            // 
            // savedUsernameLabel
            // 
            savedUsernameLabel.AutoSize = true;
            savedUsernameLabel.Font = new Font("Ringbearer", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            savedUsernameLabel.ForeColor = Color.FromArgb(242, 197, 124);
            savedUsernameLabel.Location = new Point(26, 80);
            savedUsernameLabel.Name = "savedUsernameLabel";
            savedUsernameLabel.Size = new Size(81, 17);
            savedUsernameLabel.TabIndex = 3;
            savedUsernameLabel.Text = "Username";
            savedUsernameLabel.Click += label1_Click;
            // 
            // savedPasswordLabel
            // 
            savedPasswordLabel.AutoSize = true;
            savedPasswordLabel.Font = new Font("Ringbearer", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            savedPasswordLabel.ForeColor = Color.FromArgb(242, 197, 124);
            savedPasswordLabel.Location = new Point(26, 155);
            savedPasswordLabel.Name = "savedPasswordLabel";
            savedPasswordLabel.Size = new Size(82, 17);
            savedPasswordLabel.TabIndex = 4;
            savedPasswordLabel.Text = "Password";
            savedPasswordLabel.Click += label1_Click_1;
            // 
            // SavedCredentials
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 69, 57);
            ClientSize = new Size(378, 341);
            Controls.Add(savedPasswordLabel);
            Controls.Add(savedUsernameLabel);
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
        private Label savedUsernameLabel;
        private Label savedPasswordLabel;
    }
}
