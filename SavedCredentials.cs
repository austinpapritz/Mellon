using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SavedCredentials : Form
    {
        private List<(string? website, byte[] username, byte[] password)>? _savedCredentials;
        private int _userId;
        private byte[] _encryptionKey;

        public SavedCredentials(int userId, byte[] encryptionKey)
        {
            InitializeComponent();
            _userId = userId;
            _encryptionKey = encryptionKey;
            LoadSavedCredentials();
        }

        private void LoadSavedCredentials()
        {
            _savedCredentials = DatabaseHelper.GetSavedCredentials(_userId, _encryptionKey)
                .Select(c => (c.website, Convert.FromBase64String(c.username), Convert.FromBase64String(c.password)))
                .ToList();

            websiteComboBox.Items.Clear();
            foreach (var credential in _savedCredentials)
            {
                // Check if the website is not null before adding it to the ComboBox
                if (credential.website != null)
                {
                    websiteComboBox.Items.Add(credential.website);
                }
                else
                {
                    MessageBox.Show("Please add a website.");
                }
            }
        }


        private void websiteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = websiteComboBox.SelectedIndex;

            if (_savedCredentials != null && selectedIndex >= 0 && selectedIndex < _savedCredentials.Count)
            {
                byte[] encryptedUsername = _savedCredentials[selectedIndex].username;
                byte[] encryptedPassword = _savedCredentials[selectedIndex].password;

                // Convert encrypted byte arrays to Base64 strings
                string base64EncryptedUsername = Convert.ToBase64String(encryptedUsername);
                string base64EncryptedPassword = Convert.ToBase64String(encryptedPassword);

                string decryptedUsername = EncryptionHelper.Decrypt(base64EncryptedUsername, _encryptionKey);
                string decryptedPassword = EncryptionHelper.Decrypt(base64EncryptedPassword, _encryptionKey);

                usernameLabel.Text = decryptedUsername;
                passwordLabel.Text = decryptedPassword;
            }
        }




        private void newPasswordButton_Click(object sender, EventArgs e)
        {
            using (NewPassword newPasswordForm = new NewPassword(_userId, _encryptionKey))
            {
                newPasswordForm.ShowDialog();

                // Reload the saved credentials after adding new ones
                LoadSavedCredentials();
            }
        }

    }


}
