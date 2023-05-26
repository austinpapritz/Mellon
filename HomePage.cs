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
    public partial class HomePage : Form
    {
        private string _nickname;
        private int _userId;
        private byte[] _encryptionKey;


        public HomePage(string nickname, int userId, byte[] encryptionKey)
        {
            InitializeComponent();
            _nickname = nickname;
            _userId = userId;
            _encryptionKey = encryptionKey;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NavTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void newPasswordNavButton_Click(object sender, EventArgs e)
        {
            // Clear out the main content panel
            MainContentPanel.Controls.Clear();

            // Create an instance of the form you want to display
            var form = new NewPassword(_userId, _encryptionKey);

            // Set TopLevel to false so the form can be added to the panel
            form.TopLevel = false;

            // Add the form to the panel
            MainContentPanel.Controls.Add(form);

            // Make the form fill the panel
            form.Dock = DockStyle.Fill;

            // Show the form
            form.Show();
        }

        private void savedPasswordsButton_Click(object sender, EventArgs e)
        {
            // Clear out the main content panel
            MainContentPanel.Controls.Clear();

            // Create an instance of the form you want to display
            var form = new SavedCredentials(_userId, _encryptionKey);

            // Set TopLevel to false so the form can be added to the panel
            form.TopLevel = false;

            // Add the form to the panel
            MainContentPanel.Controls.Add(form);

            // Make the form fill the panel
            form.Dock = DockStyle.Fill;

            // Show the form
            form.Show();

        }
    }
}
