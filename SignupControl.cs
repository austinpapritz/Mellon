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
    public partial class SignupControl : UserControl
    {
        public SignupControl()
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

            using (var command = new SQLiteCommand(DatabaseManager.Instance.Connection))
            {
                command.CommandText = @"
INSERT INTO Users (Nickname, Salt, HashedMasterPassword)
VALUES (@nickname, @salt, @hashedMasterPassword);";

                command.Parameters.AddWithValue("@nickname", nickname);
                command.Parameters.AddWithValue("@salt", salt);
                command.Parameters.AddWithValue("@hashedMasterPassword", hashedMasterPassword);

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

        private void hidePasswordPictureBox_Click(object sender, EventArgs e)
        {
            // Change from hide to show 
            masterPasswordTextBox.UseSystemPasswordChar = false;
            confirmPasswordTextBox.UseSystemPasswordChar = false;

            // Swap the visibility of the PictureBox controls
            showPasswordPictureBox.Visible = true;
            hidePasswordPictureBox.Visible = false;

        }

        private void showPasswordPictureBox_Click(object sender, EventArgs e)
        {
            // Change from show to hide
            masterPasswordTextBox.UseSystemPasswordChar = true;
            confirmPasswordTextBox.UseSystemPasswordChar = true;

            // Swap the visibility of the PictureBox controls
            showPasswordPictureBox.Visible = false;
            hidePasswordPictureBox.Visible = true;
        }

        private void masterPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordsMatch();
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordsMatch();
        }


        private void CheckPasswordsMatch()
        {
            if (masterPasswordTextBox.Text == confirmPasswordTextBox.Text)
            {
                // If the passwords match, show the check icon
                passwordMisMatchPictureBox.Visible = false;
                passwordMatchPictureBox.Visible = true;
            }
            else
            {
                if ((!string.IsNullOrEmpty(masterPasswordTextBox.Text) && // Verify there is text in both fields before showing X icon
                     !string.IsNullOrEmpty(confirmPasswordTextBox.Text)))
                {
                    // Otherwise, hide it.
                    passwordMatchPictureBox.Visible = false;
                    passwordMisMatchPictureBox.Visible = true;
                }

            }
        }

        private void SignupControl_Load(object sender, EventArgs e)
        {

        }
    }
}
