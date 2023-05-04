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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Close the LoginForm and go back to the WelcomeForm
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Check the user's credentials and log in
            // TODO: Implement the credential checking logic
        }

    }
}
