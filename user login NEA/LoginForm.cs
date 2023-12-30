using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_login_NEA
{
    public partial class LoginForm : Form
    {
        // SQLite connection for database operations
        private SQLiteConnection dbConnection = new SQLiteConnection(Database_manager.Connection());

        // Static variable to store the logged-in username
        public static string? LoggedInUsername;

        // Form constructor
        public LoginForm()
        {
            InitializeComponent();

            // Attach the Click event handler for the login button
            loginButton.Click += LoginButton_Click;

            // Attach the KeyDown event handler to the password TextBox
            passwordTextBox.KeyDown += PasswordTextBox_KeyDown;
        }

        // Method to authenticate the user
        private void AuthenticateUser()
        {
            // Retrieve username and password from the respective TextBoxes
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                // Attempt to authenticate the user using the database manager
                if (Database_manager.AuthenticateUser(username, password))
                {
                    MessageBox.Show("Login Successful!");
                    LoggedInUsername = username;

                    // Redirect to the next form or perform actions upon successful login
                    MainMenu MenuForm = new MainMenu();
                    MenuForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBox.Clear();
                    usernameTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions that might occur during authentication
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Event handler for the login button Click event
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Call the method responsible for authenticating the user
            AuthenticateUser();
        }

        // Event handler for the password TextBox KeyDown event
        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Call the method responsible for authenticating the user
                AuthenticateUser();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            passwordTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog for exiting the application
            DialogResult res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                // If user chooses to exit, close the application
                Application.Exit();
            }
            else
            {
                // If user chooses not to exit, show the current form
                this.Show();
            }
        }

        private void CheckBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !CheckBoxShowPass.Checked;

        }


        // Other methods and event handlers...
    }

}
