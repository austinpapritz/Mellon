using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        private List<Credential> _credentials;

        public Form1()
        {
            InitializeComponent();
            _credentials = new List<Credential>();
        }
        private void btnGeneratePW_Click(object sender, EventArgs e)
        {
            string password = GenerateStrongPassword(12);
            lblGeneratePW.Text = password;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string website = textBox1.Text;
            string username = textBox2.Text;
            string password = lblGeneratePW.Text;

            if (!string.IsNullOrWhiteSpace(website) &&
                !string.IsNullOrWhiteSpace(username) &&
                !string.IsNullOrWhiteSpace(password))
            {
                Credential credential = new Credential
                {
                    Website = website,
                    Username = username,
                    Password = password
                };

                _credentials.Add(credential);

                // Clear the TextBoxes for the next entry
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}