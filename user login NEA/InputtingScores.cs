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
    public partial class InputtingScores : Form
    {
        public InputtingScores()
        {
            InitializeComponent();
            label1.Text = SelectingPlayers.player1 + SelectingPlayers.player2 + SelectingPlayers.player3 + SelectingPlayers.player4;
        }

       
    }
}
