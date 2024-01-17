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
    public partial class Standings : Form
    {
        public Standings()
        {
            InitializeComponent();
            UpdateLabels();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UserMenu UserMenuForm = new UserMenu();
            UserMenuForm.Show();
            Hide();
        }

        private void Standings_Load(object sender, EventArgs e)
          {
             /* List<Tuple<string, int>> TeamName_Points = Game.Leaderboard(1);

              for (int i = 1; i < TeamName_Points.Count; i++)
              {
                  Team[i].Text = TeamName_Points[i].Item1;
              }
             */
          }


        private void UpdateLabels()
        {
            List<Tuple<string, int>> TeamName_Points = Game.Leaderboard(1);
            // Iterate through the items using foreach
            for (int i = 0; i < Math.Min(TeamName_Points.Count, 14); i++)
            {
                string teamName = TeamName_Points[i].Item1;

                // Assuming you have labels named Team1, Team2, ..., Team14
                // Adjust these label names based on your actual label names
                Label label = FindLabelByName($"Team{i + 1}");

                // Update the label text
                label.Text = $"Team: {teamName}";
            }
        }

        private Label FindLabelByName(string name)
        {
            // Search for a label with the specified name in the form's controls
            foreach (Control control in Controls)
            {
                if (control is Label label && label.Name == name)
                {
                    return label;
                }
            }

            // Handle the case where the label is not found
            throw new ArgumentException($"Label with name {name} not found.");
        }
    }
}


