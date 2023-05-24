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
    public partial class LoginControl : UserControl
    {
        private int _userId;
        private byte[] _encryptionKey = Array.Empty<byte>();

        public LoginControl()
        {
            InitializeComponent();
            DatabaseHelper.SetUpDatabase();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            string nickname = nicknameTextBox.Text;
            string masterPassword = masterPasswordTextBox.Text;

            // get the hashed password and salt from database
            (byte[]? storedHashedMasterPassword, byte[]? storedSalt) = DatabaseHelper.GetStoredHashedMasterPassword(nickname);

            if (storedHashedMasterPassword == null)
            {
                MessageBox.Show("Invalid nickname or password.");
                return;
            }

            // take both the master password that user enters and salt value from above and create a provdedHashedMasterPassword to compare to one in database
            (byte[] providedHashedMasterPassword, _) = PasswordHelper.HashMasterPassword(masterPassword, storedSalt);

            if (providedHashedMasterPassword.SequenceEqual(storedHashedMasterPassword))
            {
                MessageBox.Show("Login successful!");
                _userId = DatabaseHelper.GetUserId(nickname);

                //check for valid username
                if (_userId >= 0)
                {
                    // the encryptionKey is generated here and used throughout the session to save and access credentials
                    _encryptionKey = GenerateEncryptionKey(masterPassword, storedSalt);

                    HomePage homePage = new HomePage(nickname, _userId, _encryptionKey);
                    homePage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid nickname.");
                }
            }
            else
            {
                MessageBox.Show("Invalid master password.");
            }
        }


        private byte[] GenerateEncryptionKey(string masterPassword, byte[]? salt)
        {
            // check for salt
            if (salt == null)
            {
                throw new ArgumentNullException(nameof(salt));
            }

            // standard PBKDF2 algorithm to generate key which is 32 bytes long
            using (var kdf = new Rfc2898DeriveBytes(masterPassword, salt, 10000))
            {
                return kdf.GetBytes(32); 
            }
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }
    }
}
