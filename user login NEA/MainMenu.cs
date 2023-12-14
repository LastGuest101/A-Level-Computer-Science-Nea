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
        public static string? loggedPlayerId;

        public MainMenu()
        {
            InitializeComponent();
            loggedPlayerId = Convert.ToString(Database_manager.intAttributesFromDB(LoginForm.LoggedInUsername, "Username", "Users", "player_id"));

            PlayerName.Text = "Bowler: " + Database_manager.stringAttributesFromDB(loggedPlayerId, "player_id", "Players", "FirstName") + " " + Database_manager.stringAttributesFromDB(loggedPlayerId, "player_id", "Players", "LastName");
            PlayerHandicap.Text = "Handicap:  " + Convert.ToString(Database_manager.intAttributesFromDB(loggedPlayerId, "player_id", "Handicaps", "Handicap"));
            label2.Text = Convert.ToString(Database_manager.intAttributesFromDB(LoginForm.LoggedInUsername, "Username", "Users", "Admin"));
            AddButton.Visible = Database_manager.intAttributesFromDB(LoginForm.LoggedInUsername, "Username", "Users", "Admin") == 1;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenuForm = new AdminMenu();
            adminMenuForm.Show();
            Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void SignOut_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Do you want to Sign Out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            else
            {

                this.Show();
            }


        }

       
    }
}
