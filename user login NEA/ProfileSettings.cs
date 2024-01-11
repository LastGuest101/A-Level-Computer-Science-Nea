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
    public partial class ProfileSettings : Form
    {
        public ProfileSettings()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new();
            mainMenuForm.Show();
            Hide();

            int user_id = User.getUserID(LoginForm.LoggedInUsername);


        }

        private void ProfileSettings_Load(object sender, EventArgs e)
        {
            int user_id = User.getUserID(LoginForm.LoggedInUsername);    

            UserID2.Text = Convert.ToString(user_id);

            if (User.GetAdminLevel(user_id) == 1)
            {
                AccountLevelDisplayLabel.Text = "Admin";
            }
            else
            {
                AccountLevelDisplayLabel.Text = "Member";
            }

            UsernameTextBox.Text = User.getUsername(user_id);



        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
           if (UsernameTextBox.Text != LoginForm.LoggedInUsername)
           {
                UsernameButton.Visible = true;
           }
           else
           {
                UsernameButton.Visible = false;
           }
        }

        private void UsernameButton_Click(object sender, EventArgs e)
        {
            int user_id = User.getUserID(LoginForm.LoggedInUsername);

            if (string.IsNullOrEmpty(UsernameTextBox.Text) == false)
            {
                if (User.UsernameValidator(UsernameTextBox.Text) == "valid")
                {
                    DialogResult confirmation = MessageBox.Show($"Do you want to change your Username to {UsernameTextBox.Text}?", "Change Username", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        User.SetUsername(UsernameTextBox.Text, user_id);
                        LoginForm.LoggedInUsername = UsernameTextBox.Text;

                        ProfileSettings profileSettingsForm = new ProfileSettings();
                        profileSettingsForm.Show(this);
                        Hide();


                    }
                    

                }

            }
                
        }
    }
}
