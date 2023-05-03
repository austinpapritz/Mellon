namespace WinFormsApp1
{
    partial class WelcomeForm
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
            createMasterPasswordButton = new Button();
            newMasterPasswordButton = new Button();
            SuspendLayout();
            // 
            // createMasterPasswordButton
            // 
            createMasterPasswordButton.Location = new Point(50, 50);
            createMasterPasswordButton.Name = "createMasterPasswordButton";
            createMasterPasswordButton.Size = new Size(200, 100);
            createMasterPasswordButton.TabIndex = 0;
            createMasterPasswordButton.Text = "Create Master Password";
            createMasterPasswordButton.UseVisualStyleBackColor = true;
            createMasterPasswordButton.Click += createMasterPasswordButton_Click;
            // 
            // newMasterPasswordButton
            // 
            newMasterPasswordButton.Location = new Point(50, 200);
            newMasterPasswordButton.Name = "newMasterPasswordButton";
            newMasterPasswordButton.Size = new Size(200, 100);
            newMasterPasswordButton.TabIndex = 1;
            newMasterPasswordButton.Text = "New Master Password";
            newMasterPasswordButton.UseVisualStyleBackColor = true;
            newMasterPasswordButton.Click += newMasterPasswordButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 350);
            Controls.Add(newMasterPasswordButton);
            Controls.Add(createMasterPasswordButton);
            Name = "WelcomeForm";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createMasterPasswordButton;
        private Button newMasterPasswordButton;



    }
}