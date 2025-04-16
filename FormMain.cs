using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Lab07
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // Make sure the Logout button is disabled at startup
            btnLogout.Enabled = false;
        }

        // LOGIN button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Create a new instance of the login form
            FormLogin frmLogin = new FormLogin();

            // 2. Show it as a modal dialog
            frmLogin.ShowDialog();

            // 3. Check if the user successfully logged in
            if (frmLogin.Login)
            {
                // Disable the Login button, enable the Logout button
                btnLogin.Enabled = false;
                btnLogout.Enabled = true;
            }
            // Otherwise, do nothing (user canceled or invalid credentials)
        }

        // LOGOUT button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Re-enable the Login button, disable the Logout button
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;

            // Optional: show a message or do other cleanup
            MessageBox.Show("You have logged out successfully.");
        }
    }
}
