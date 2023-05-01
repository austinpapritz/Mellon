using System;
using System.Collections.Generic;
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

        private void website_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string website = textBox1.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;

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
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
