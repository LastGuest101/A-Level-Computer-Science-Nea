using System;
using System.Collections;
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
    public partial class Standings : Form
    {
        public Standings()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            UserMenu UserMenuForm = new UserMenu();
            UserMenuForm.Show();
            Hide();
        }
        private void Standings_Load(object sender, EventArgs e)
        {
            // 1 represents the league_id

            List<Tuple<string, int>> Teamname_Points = Game.Leaderboard(UserMenu.LeagueID);
            if (Teamname_Points.Count == 14)
            {
                //Displays the 1st team TeamName. 
                Team1.Text = Teamname_Points[0].Item1;
                //Displays the 1st team points
                Points1.Text = Convert.ToString(Teamname_Points[0].Item2);

                //Displays the 2nd team TeamName. 
                Team2.Text = Teamname_Points[1].Item1;
                //Displays the 2nd team points
                Points2.Text = Convert.ToString(Teamname_Points[1].Item2);

                //Displays the 3rd team TeamName. 
                Team3.Text = Teamname_Points[2].Item1;
                //Displays the 3rd team points
                Points3.Text = Convert.ToString(Teamname_Points[2].Item2);

                Team4.Text = Teamname_Points[3].Item1;
                Points4.Text = Convert.ToString(Teamname_Points[3].Item2);

                Team5.Text = Teamname_Points[4].Item1;
                Points5.Text = Convert.ToString(Teamname_Points[4].Item2);

                Team6.Text = Teamname_Points[5].Item1;
                Points6.Text = Convert.ToString(Teamname_Points[5].Item2);

                Team7.Text = Teamname_Points[6].Item1;
                Points7.Text = Convert.ToString(Teamname_Points[6].Item2);

                Team8.Text = Teamname_Points[7].Item1;
                Points8.Text = Convert.ToString(Teamname_Points[7].Item2);

                Team9.Text = Teamname_Points[8].Item1;
                Points9.Text = Convert.ToString(Teamname_Points[8].Item2);

                Team10.Text = Teamname_Points[9].Item1;
                Points10.Text = Convert.ToString(Teamname_Points[9].Item2);

                Team11.Text = Teamname_Points[10].Item1;
                Points11.Text = Convert.ToString(Teamname_Points[10].Item2);

                Team12.Text = Teamname_Points[11].Item1;
                Points12.Text = Convert.ToString(Teamname_Points[11].Item2);

                Team13.Text = Teamname_Points[12].Item1;
                Points13.Text = Convert.ToString(Teamname_Points[12].Item2);

                Team14.Text = Teamname_Points[13].Item1;
                Points14.Text = Convert.ToString(Teamname_Points[13].Item2);
            }
        }
    }
}


