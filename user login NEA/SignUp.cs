using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_login_NEA
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

            foreach (var LeagueName in Database_manager.multipleIntFromDB("1", "league_id", "Leagues", "LeagueName")) 
            {
                LeagueComboBox.Items.Add(Database_manager.singleStringFromDB($"{LeagueName}", "LeagueName", "Leagues", "LeagueName"));
            }

        }


        private void LoginInButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new();
            loginForm.Show();
            Hide();
        }
    }
}
