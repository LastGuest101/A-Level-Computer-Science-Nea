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
    public partial class InputtingScoresForm : Form
    {
        public InputtingScoresForm()
        {
            InitializeComponent();

            Team1.Text = Database_manager.stringAttributesFromDB("1", "team_id", "Teams", "TeamName");

        }

       
    }
}
