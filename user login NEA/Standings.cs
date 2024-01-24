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
            List<Tuple<string, int>> TEST = Game.Leaderboard(1);

            Team1.Text = TEST[0].Item1;
            Points1.Text = Convert.ToString(TEST[0].Item2);

            Team2.Text = TEST[1].Item1;
            Points2.Text = Convert.ToString(TEST[1].Item2);

            Team3.Text = TEST[2].Item1;
            Points3.Text = Convert.ToString(TEST[2].Item2);

            Team4.Text = TEST[3].Item1;
            Points4.Text = Convert.ToString(TEST[3].Item2);

            Team5.Text = TEST[4].Item1;
            Points5.Text = Convert.ToString(TEST[4].Item2);

            Team6.Text = TEST[5].Item1;
            Points6.Text = Convert.ToString(TEST[5].Item2);

            Team7.Text = TEST[6].Item1;
            Points7.Text = Convert.ToString(TEST[6].Item2);

            Team8.Text = TEST[7].Item1;
            Points8.Text = Convert.ToString(TEST[7].Item2);

            Team9.Text = TEST[8].Item1;
            Points9.Text = Convert.ToString(TEST[8].Item2);

            Team10.Text = TEST[9].Item1;
            Points10.Text = Convert.ToString(TEST[9].Item2);

            Team11.Text = TEST[10].Item1;
            Points11.Text = Convert.ToString(TEST[10].Item2);

            Team12.Text = TEST[11].Item1;
            Points12.Text = Convert.ToString(TEST[11].Item2);

            Team13.Text = TEST[12].Item1;
            Points13.Text = Convert.ToString(TEST[12].Item2);

            Team14.Text = TEST[13].Item1;
            Points14.Text = Convert.ToString(TEST[13].Item2);


        }





    }
}


