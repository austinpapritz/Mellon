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

namespace WinFormsApp1
{
    public partial class CreateMasterPasswordForm : Form
    {
        public CreateMasterPasswordForm()
        {
            InitializeComponent();
        }

        private void SaveMasterPasswordButton_Click(object sender, EventArgs e)
        {
            string nickname = nicknameTextBox.Text;
            string masterPassword = masterPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            if (masterPassword == confirmPassword)
            {
                Debug.WriteLine("Nickname: " + nickname);
                Debug.WriteLine("Master Password: " + masterPassword);
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please re-enter your password.");
            }
        }

    }
}
