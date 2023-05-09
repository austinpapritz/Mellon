using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private int _userId;
        private byte[] _encryptionKey;

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
                MessageBox.Show("Invalid nickname or password.");
                return;
            }

            (byte[] providedHashedMasterPassword, _) = PasswordHelper.HashMasterPassword(masterPassword, storedSalt);

            if (providedHashedMasterPassword.SequenceEqual(storedHashedMasterPassword))
            {
                MessageBox.Show("Login successful!");
                // Navigate to NewPassword or perform other actions upon successful login
                _userId = DatabaseHelper.GetUserId(nickname);

                _encryptionKey = GenerateEncryptionKey(masterPassword, storedSalt);

                SavedCredentialsForm savedCredentialsForm = new SavedCredentialsForm(_userId, _encryptionKey);
                savedCredentialsForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid master password.");
            }
        }

        private byte[] GenerateEncryptionKey(string masterPassword, byte[] salt)
        {
            using (var kdf = new Rfc2898DeriveBytes(masterPassword, salt, 10000))
            {
                return kdf.GetBytes(32); // Generate a 256-bit (32-byte) key
            }
        }

    }
}
