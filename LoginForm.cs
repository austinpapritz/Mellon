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

            byte[] storedEncryptedMasterPassword = DatabaseHelper.GetStoredEncryptedMasterPassword(nickname);

            if (storedEncryptedMasterPassword == null)
            {
                MessageBox.Show("Invalid nickname.");
                return;
            }

            byte[] providedEncryptedMasterPassword = PasswordHelper.EncryptMasterPassword(masterPassword);


            if (providedEncryptedMasterPassword.SequenceEqual(storedEncryptedMasterPassword))
            {
                MessageBox.Show("Login successful!");
                // Navigate to NewPassword or perform other actions upon successful login
            }
            else
            {
                MessageBox.Show("Invalid master password.");
            }
        }
    }
}
