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
            signUpButton = new Button();
            logInButton = new Button();
            SuspendLayout();
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(50, 50);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(200, 100);
            signUpButton.TabIndex = 0;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += SignupButton_Click;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(50, 200);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(200, 100);
            logInButton.TabIndex = 1;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += LoginButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 350);
            Controls.Add(logInButton);
            Controls.Add(signUpButton);
            Name = "WelcomeForm";
            Text = "Welcome";
            ResumeLayout(false);
        }

        #endregion

        private Button signUpButton;
        private Button logInButton;



    }
}