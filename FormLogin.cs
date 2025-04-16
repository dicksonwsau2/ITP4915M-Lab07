using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITP4915M_Lab07
{
    public partial class FormLogin : Form
    {
        // Public variable to store login status
        public bool Login = false;

        // Connection string pointing to your .accdb file
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                               + "Data Source=lib.accdb";

        public FormLogin()
        {
            InitializeComponent();
        }

        // Handle the Submit button click event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Reset login status
            Login = false;

            // Make sure user entered something for username & password
            if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Missing username or password. Please try again.");
                txtUsername.Clear();
                txtPassword.Clear();
                return;
            }

            // 1. Create a connection to the Access database
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                // 2. Build a query to check if the username & password exist in the [Users] table
                string sql = "SELECT COUNT(*) FROM [Users] "
                           + "WHERE [Username] = ? AND [Password] = ?";

                // 3. Create the command and add parameters
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    // Access uses '?' placeholders in the exact order they appear in the query
                    cmd.Parameters.AddWithValue("?", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("?", txtPassword.Text.Trim());

                    // 4. Execute the query and get the match count
                    int userCount = (int)cmd.ExecuteScalar();

                    // 5. If at least one record matches, set Login = true
                    if (userCount > 0)
                    {
                        Login = true;
                        Close(); // Close the login form
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
            }
        }

        // Handle the Cancel button click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); // Close the login form without logging in
        }
    }
}
