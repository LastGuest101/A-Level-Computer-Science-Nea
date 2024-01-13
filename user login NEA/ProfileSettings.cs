﻿using System;
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

            foreach (string Username in Database_manager.columnStringFromDB("Users", "Username"))
            {
                int allUser_id = User.getUserID(Username);

                if (User.GetAdminLevel(allUser_id) == 0)
                {
                    UserCombobox.Items.Add($"{Username}");
                }
                else if (User.GetAdminLevel(allUser_id) == 1)
                {
                    AdminComboBox.Items.Add($"{Username}");
                }

            }

            if (User.GetAdminLevel(user_id) == 1)
            {
                AccountLevelDisplayLabel.Text = "Admin";
                UserCombobox.Visible = true;
                AdminAddLabel.Visible = true;
                RemoveAdminLabel.Visible = true;
                AdminComboBox.Visible = true;
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

        private void UserCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserCombobox.SelectedIndex.ToString() != null)
            {
                AddAdminButton.Visible = true;
            }
        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show($"Do you want to give Admin level permission to {UserCombobox.SelectedItem}?", "Add Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                int selectedUser_id = User.getUserID(UserCombobox.SelectedItem.ToString());
                User.SetAdminLevel(1, selectedUser_id);

                MessageBox.Show($"Admin Added: {UserCombobox.SelectedItem}  ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ProfileSettings profileSettingsForm = new ProfileSettings();
                profileSettingsForm.Show(this);
                Hide();


            }
        }

        private void AdminComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserCombobox.SelectedIndex.ToString() != null)
            {
                RemoveAdminButton.Visible = true;
            }
        }

        private void RemoveAdminButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show($"Do you want to remove Admin level permission : {AdminComboBox.SelectedItem} ?", "Remove Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                int selectedUser_id = User.getUserID(AdminComboBox.SelectedItem.ToString());
                User.SetAdminLevel(0, selectedUser_id);

                MessageBox.Show($"Admin Removed: {AdminComboBox.SelectedItem}  ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ProfileSettings profileSettingsForm = new ProfileSettings();
                profileSettingsForm.Show(this);
                Hide();

            }
        }
    }
}