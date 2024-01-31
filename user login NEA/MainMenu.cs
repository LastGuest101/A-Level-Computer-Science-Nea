using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace user_login_NEA
{
    public partial class MainMenu : Form
    {
        public static int loggedPlayerID;
        public MainMenu()
        {
            InitializeComponent();
            //Gets the player_id from the login username inputter in Login Form.
            loggedPlayerID = Player.GetPlayerID(LoginForm.LoggedInUsername);
            PlayerName.Text = "Bowler: " + Player.GetFirstName(loggedPlayerID) + " " + Player.GetLastName(loggedPlayerID);
            //Only displays Admin button if the user's account level is admin.
            if(User.GetAdminLevel(User.GetUserID(LoginForm.LoggedInUsername)) == 1)
            {
                AdminButton.Visible = true;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenuForm = new();
            adminMenuForm.Show();
            Hide();
        }
        private void SignOut_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to Sign Out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                LoginForm loginForm = new();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }

        }
        private void UserMenu_Click(object sender, EventArgs e)
        {
            UserMenu userMenuForm = new UserMenu();
            userMenuForm.Show();
            Hide();
        }
        private void UserSettings_Click(object sender, EventArgs e)
        {
            ProfileSettings profileSettingsForm = new ProfileSettings();
            profileSettingsForm.Show();
            Hide();
        }
    }
}
