using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class NewPassword : Form
{
    private List<Credential> _credentials;
    private int _userId;

    public NewPassword(int userId)
    {
        InitializeComponent();
        _userId = userId;
        _credentials = new List<Credential>();
    }


    public string GenerateStrongPassword(int length)
        {
            const string uppercaseChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            const string lowercaseChars = "abcdefghijkmnopqrstuvwxyz";
            const string digitChars = "0123456789";
            const string specialChars = "!@#$%^&*_-+";

            string allowedChars = uppercaseChars + lowercaseChars + digitChars + specialChars;

            return GenerateRandomPassword(length, allowedChars);
        }

        private string GenerateRandomPassword(int length, string allowedChars)
        {
            char[] password = new char[length];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] randomBytes = new byte[length];

                rng.GetBytes(randomBytes);

                for (int i = 0; i < length; i++)
                {
                    int index = randomBytes[i] % allowedChars.Length;
                    password[i] = allowedChars[index];
                }
            }

            return new string(password);
        }

        private void btnGeneratePW_Click(object sender, EventArgs e)
        {
            string password = GenerateStrongPassword(12);
            lblGeneratePW.Text = password;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string website = textBox1.Text;
            string username = textBox2.Text;
            string password = lblGeneratePW.Text;

            if (!string.IsNullOrWhiteSpace(website) &&
                !string.IsNullOrWhiteSpace(username) &&
                !string.IsNullOrWhiteSpace(password))
            {
                DatabaseHelper.SaveCredential(_userId, website, username, password);

                // Clear the TextBoxes for the next entry
                textBox1.Clear();
                textBox2.Clear();
                lblGeneratePW.Text = string.Empty;

                MessageBox.Show("Credential saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}