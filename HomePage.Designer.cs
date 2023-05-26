namespace WinFormsApp1
{
    partial class HomePage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NavigationPanel = new Panel();
            newPasswordNavButton = new Button();
            UserPanel = new Panel();
            NicknameLabel = new Label();
            UserAvatar = new PictureBox();
            MainContentPanel = new Panel();
            savedPasswordsButton = new Button();
            NavigationPanel.SuspendLayout();
            UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserAvatar).BeginInit();
            SuspendLayout();
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = Color.FromArgb(58, 59, 66);
            NavigationPanel.Controls.Add(savedPasswordsButton);
            NavigationPanel.Controls.Add(newPasswordNavButton);
            NavigationPanel.Controls.Add(UserPanel);
            NavigationPanel.Dock = DockStyle.Left;
            NavigationPanel.Location = new Point(0, 0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(186, 577);
            NavigationPanel.TabIndex = 0;
            // 
            // newPasswordNavButton
            // 
            newPasswordNavButton.Cursor = Cursors.Hand;
            newPasswordNavButton.Dock = DockStyle.Top;
            newPasswordNavButton.FlatAppearance.BorderSize = 0;
            newPasswordNavButton.FlatStyle = FlatStyle.Flat;
            newPasswordNavButton.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            newPasswordNavButton.ForeColor = Color.FromArgb(128, 161, 193);
            newPasswordNavButton.Image = Properties.Resources.plus_square;
            newPasswordNavButton.Location = new Point(0, 120);
            newPasswordNavButton.Name = "newPasswordNavButton";
            newPasswordNavButton.Size = new Size(186, 42);
            newPasswordNavButton.TabIndex = 0;
            newPasswordNavButton.Text = "New Password ";
            newPasswordNavButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            newPasswordNavButton.UseVisualStyleBackColor = true;
            newPasswordNavButton.Click += newPasswordNavButton_Click;
            // 
            // UserPanel
            // 
            UserPanel.Controls.Add(NicknameLabel);
            UserPanel.Controls.Add(UserAvatar);
            UserPanel.Dock = DockStyle.Top;
            UserPanel.Location = new Point(0, 0);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(186, 120);
            UserPanel.TabIndex = 0;
            // 
            // NicknameLabel
            // 
            NicknameLabel.AutoSize = true;
            NicknameLabel.BackColor = Color.FromArgb(58, 59, 66);
            NicknameLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NicknameLabel.ForeColor = Color.FromArgb(242, 197, 124);
            NicknameLabel.Location = new Point(48, 92);
            NicknameLabel.Name = "NicknameLabel";
            NicknameLabel.Size = new Size(76, 16);
            NicknameLabel.TabIndex = 1;
            NicknameLabel.Text = "Nickname";
            NicknameLabel.Click += label1_Click;
            // 
            // UserAvatar
            // 
            UserAvatar.Image = Properties.Resources.wizard_hat;
            UserAvatar.Location = new Point(60, 22);
            UserAvatar.Name = "UserAvatar";
            UserAvatar.Size = new Size(63, 63);
            UserAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            UserAvatar.TabIndex = 0;
            UserAvatar.TabStop = false;
            // 
            // MainContentPanel
            // 
            MainContentPanel.Location = new Point(183, 0);
            MainContentPanel.Name = "MainContentPanel";
            MainContentPanel.Size = new Size(770, 577);
            MainContentPanel.TabIndex = 1;
            // 
            // savedPasswordsButton
            // 
            savedPasswordsButton.Cursor = Cursors.Hand;
            savedPasswordsButton.Dock = DockStyle.Top;
            savedPasswordsButton.FlatAppearance.BorderSize = 0;
            savedPasswordsButton.FlatStyle = FlatStyle.Flat;
            savedPasswordsButton.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            savedPasswordsButton.ForeColor = Color.FromArgb(128, 161, 193);
            savedPasswordsButton.Image = Properties.Resources.list;
            savedPasswordsButton.Location = new Point(0, 162);
            savedPasswordsButton.Name = "savedPasswordsButton";
            savedPasswordsButton.Size = new Size(186, 42);
            savedPasswordsButton.TabIndex = 1;
            savedPasswordsButton.Text = "Saved Passwords";
            savedPasswordsButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            savedPasswordsButton.UseVisualStyleBackColor = true;
            savedPasswordsButton.Click += savedPasswordsButton_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 69, 57);
            ClientSize = new Size(951, 577);
            Controls.Add(MainContentPanel);
            Controls.Add(NavigationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            NavigationPanel.ResumeLayout(false);
            UserPanel.ResumeLayout(false);
            UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel NavigationPanel;
        private Panel MainContentPanel;
        private Panel UserPanel;
        private Label NicknameLabel;
        private PictureBox UserAvatar;
        private Button newPasswordNavButton;
        private Button savedPasswordsButton;
    }
}