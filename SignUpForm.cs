using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using System.Security.Cryptography;
using Konscious.Security.Cryptography;


namespace WinFormsApp1
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            SetUpDatabase();
        }

        private void SaveMasterPasswordButton_Click(object sender, EventArgs e)
        {
            string nickname = nicknameTextBox.Text;
            string masterPassword = masterPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            if (masterPassword == confirmPassword)
            {
                StoreUser(nickname, masterPassword);
                Debug.WriteLine("User stored successfully!");
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please re-enter your password.");
            }
        }
        private void SetUpDatabase()
        {
            using (var connection = new SQLiteConnection("Data Source=users.db"))
            {
                connection.Open();

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
            CREATE TABLE IF NOT EXISTS Users (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nickname TEXT NOT NULL UNIQUE,
                EncryptedMasterPassword BLOB NOT NULL
            );";
                    command.ExecuteNonQuery();
                }
            }
        }


        private void StoreUser(string nickname, string masterPassword)
        {
            byte[] encryptedMasterPassword = PasswordHelper.EncryptMasterPassword(masterPassword);

            using (var connection = new SQLiteConnection("Data Source=users.db"))
            {
                connection.Open();

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
            INSERT INTO Users (Nickname, EncryptedMasterPassword)
            VALUES (@nickname, @encryptedMasterPassword);";

                    command.Parameters.AddWithValue("@nickname", nickname);
                    command.Parameters.AddWithValue("@encryptedMasterPassword", encryptedMasterPassword);

                    command.ExecuteNonQuery();
                }
            }
        }




    }
}
