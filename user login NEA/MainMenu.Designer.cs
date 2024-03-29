﻿namespace user_login_NEA
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AdminButton = new Button();
            PlayerName = new Label();
            SignOut = new Button();
            UserMenu = new Button();
            UserSettings = new Button();
            SuspendLayout();
            // 
            // AdminButton
            // 
            AdminButton.Location = new Point(30, 232);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(385, 167);
            AdminButton.TabIndex = 6;
            AdminButton.Text = "ADMIN MENU(Admin Only)";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Visible = false;
            AdminButton.Click += AddButton_Click;
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PlayerName.Location = new Point(312, 35);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(200, 31);
            PlayerName.TabIndex = 7;
            PlayerName.Text = "Player's Full Name";
            // 
            // SignOut
            // 
            SignOut.Location = new Point(12, 12);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(94, 29);
            SignOut.TabIndex = 8;
            SignOut.Text = "SIGN OUT";
            SignOut.UseVisualStyleBackColor = true;
            SignOut.Click += SignOut_Click;
            // 
            // UserMenu
            // 
            UserMenu.Location = new Point(545, 234);
            UserMenu.Name = "UserMenu";
            UserMenu.Size = new Size(385, 162);
            UserMenu.TabIndex = 9;
            UserMenu.Text = "USER MENU";
            UserMenu.UseVisualStyleBackColor = true;
            UserMenu.Click += UserMenu_Click;
            // 
            // UserSettings
            // 
            UserSettings.Location = new Point(698, 21);
            UserSettings.Name = "UserSettings";
            UserSettings.Size = new Size(249, 45);
            UserSettings.TabIndex = 10;
            UserSettings.Text = "User Profile/Settings";
            UserSettings.UseVisualStyleBackColor = true;
            UserSettings.Click += UserSettings_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 667);
            Controls.Add(UserSettings);
            Controls.Add(UserMenu);
            Controls.Add(SignOut);
            Controls.Add(PlayerName);
            Controls.Add(AdminButton);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AdminButton;
        private Label PlayerName;
        private Button SignOut;
        private Button UserMenu;
        private Button UserSettings;
    }
}