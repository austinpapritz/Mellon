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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
            DatabaseHelper.SetUpDatabase();
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


        private void StoreUser(string nickname, string masterPassword)
        {
            (byte[] hashedMasterPassword, byte[] salt) = PasswordHelper.HashMasterPassword(masterPassword);

            using (var command = new SQLiteCommand(DatabaseManager.Connection))
            {
                command.CommandText = @"
INSERT INTO Users (Nickname, Salt, HashedMasterPassword)
VALUES (@nickname, @salt, @hashedMasterPassword);";

                command.Parameters.AddWithValue("@nickname", nickname);
                command.Parameters.AddWithValue("@salt", salt);
                command.Parameters.AddWithValue("@encryptedMasterPassword", hashedMasterPassword);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    if (ex.ResultCode == SQLiteErrorCode.Constraint)
                    {
                        MessageBox.Show("This nickname is already taken. Please choose a different one.");
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }






    }
}
