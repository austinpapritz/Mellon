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
            MainContentPanel = new Panel();
            panel1 = new Panel();
            UserAvatar = new PictureBox();
            label1 = new Label();
            newPasswordButton = new Button();
            NavigationPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserAvatar).BeginInit();
            SuspendLayout();
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = Color.FromArgb(58, 59, 66);
            NavigationPanel.Controls.Add(newPasswordButton);
            NavigationPanel.Controls.Add(panel1);
            NavigationPanel.Dock = DockStyle.Left;
            NavigationPanel.Location = new Point(0, 0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(186, 577);
            NavigationPanel.TabIndex = 0;
            // 
            // MainContentPanel
            // 
            MainContentPanel.Location = new Point(183, 0);
            MainContentPanel.Name = "MainContentPanel";
            MainContentPanel.Size = new Size(770, 577);
            MainContentPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UserAvatar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 120);
            panel1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(58, 59, 66);
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(242, 197, 124);
            label1.Location = new Point(48, 92);
            label1.Name = "label1";
            label1.Size = new Size(76, 16);
            label1.TabIndex = 1;
            label1.Text = "Nickname";
            label1.Click += label1_Click;
            // 
            // newPasswordButton
            // 
            newPasswordButton.Cursor = Cursors.Hand;
            newPasswordButton.Dock = DockStyle.Top;
            newPasswordButton.FlatAppearance.BorderSize = 0;
            newPasswordButton.FlatStyle = FlatStyle.Flat;
            newPasswordButton.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            newPasswordButton.ForeColor = Color.FromArgb(128, 161, 193);
            newPasswordButton.Image = Properties.Resources.plus_square;
            newPasswordButton.Location = new Point(0, 120);
            newPasswordButton.Name = "newPasswordButton";
            newPasswordButton.Size = new Size(186, 42);
            newPasswordButton.TabIndex = 0;
            newPasswordButton.Text = "New Password ";
            newPasswordButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            newPasswordButton.UseVisualStyleBackColor = true;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel NavigationPanel;
        private Panel MainContentPanel;
        private Panel panel1;
        private Label label1;
        private PictureBox UserAvatar;
        private Button newPasswordButton;
    }
}