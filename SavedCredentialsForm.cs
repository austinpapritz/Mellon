using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SavedCredentialsForm : Form
    {

        private List<(string website, string username, string password)> _savedCredentials;
        private int _userId;

        public SavedCredentialsForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadSavedCredentials();
        }

        private void LoadSavedCredentials()
        {
            _savedCredentials = DatabaseHelper.GetSavedCredentials(_userId);

            websiteComboBox.Items.Clear();
            foreach (var credential in _savedCredentials)
            {
                websiteComboBox.Items.Add(credential.website);
            }
        }

        private void websiteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = websiteComboBox.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < _savedCredentials.Count)
            {
                usernameLabel.Text = _savedCredentials[selectedIndex].username;
                passwordLabel.Text = _savedCredentials[selectedIndex].password;
            }
        }
    }


}
