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
    public partial class WelcomeForm : Form
    {
        private SignupControl signupControl;
        private LoginControl loginControl;

        public WelcomeForm()
        {
            InitializeComponent();

            // Initialize UserControls and add to form
            signupControl = new SignupControl();
            loginControl = new LoginControl();

            // Add to form
            this.Controls.Add(signupControl);
            this.Controls.Add(loginControl);

            // Initially set to invisible
            signupControl.Visible = false;
            loginControl.Visible = false;
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            // Hide Login UserControl and show Signup UserControl
            loginControl.Visible = false;
            signupControl.Visible = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Hide Signup UserControl and show Login UserControl
            signupControl.Visible = false;
            loginControl.Visible = true;
        }

    }

}
