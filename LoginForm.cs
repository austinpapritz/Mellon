using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DatabaseHelper.SetUpDatabase();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Close the LoginForm and go back to the WelcomeForm
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string nickname = nicknameTextBox.Text;
            string masterPassword = masterPasswordTextBox.Text;

            (byte[] storedHashedMasterPassword, byte[] storedSalt) = DatabaseHelper.GetStoredHashedMasterPassword(nickname);

            if (storedHashedMasterPassword == null)
            {
                MessageBox.Show("Invalid nickname.");
                return;
            }

            (byte[] providedHashedMasterPassword, _) = PasswordHelper.HashMasterPassword(masterPassword, storedSalt);

            if (providedHashedMasterPassword.SequenceEqual(storedHashedMasterPassword))
            {
                MessageBox.Show("Login successful!");
                // Navigate to NewPassword or perform other actions upon successful login
                SavedCredentialsForm savedCredentialsForm = new SavedCredentialsForm(nickname);
                savedCredentialsForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid master password.");
            }
        }

    }
}
