namespace user_login_NEA
{
    partial class RemovingPlayers
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
            this.backButton = new System.Windows.Forms.Button();
            this.RemovePlayerButton = new System.Windows.Forms.Button();
            this.TeamComboBox = new System.Windows.Forms.ComboBox();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.LeagueComboBox = new System.Windows.Forms.ComboBox();
            this.LeagueLabel = new System.Windows.Forms.Label();
            this.PlayerComboBox = new System.Windows.Forms.ComboBox();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(82, 22);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RemovePlayerButton
            // 
            this.RemovePlayerButton.Location = new System.Drawing.Point(318, 316);
            this.RemovePlayerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemovePlayerButton.Name = "RemovePlayerButton";
            this.RemovePlayerButton.Size = new System.Drawing.Size(133, 71);
            this.RemovePlayerButton.TabIndex = 30;
            this.RemovePlayerButton.Text = "Remove Player";
            this.RemovePlayerButton.UseVisualStyleBackColor = true;
            this.RemovePlayerButton.Click += new System.EventHandler(this.RemovePlayerButton_Click);
            // 
            // TeamComboBox
            // 
            this.TeamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamComboBox.FormattingEnabled = true;
            this.TeamComboBox.Location = new System.Drawing.Point(318, 103);
            this.TeamComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeamComboBox.Name = "TeamComboBox";
            this.TeamComboBox.Size = new System.Drawing.Size(133, 23);
            this.TeamComboBox.TabIndex = 25;
            this.TeamComboBox.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Location = new System.Drawing.Point(366, 71);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(35, 15);
            this.TeamLabel.TabIndex = 24;
            this.TeamLabel.Text = "Team";
            // 
            // LeagueComboBox
            // 
            this.LeagueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeagueComboBox.FormattingEnabled = true;
            this.LeagueComboBox.Location = new System.Drawing.Point(82, 103);
            this.LeagueComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeagueComboBox.Name = "LeagueComboBox";
            this.LeagueComboBox.Size = new System.Drawing.Size(133, 23);
            this.LeagueComboBox.TabIndex = 23;
            this.LeagueComboBox.SelectedIndexChanged += new System.EventHandler(this.LeagueComboBox_SelectedIndexChanged);
            // 
            // LeagueLabel
            // 
            this.LeagueLabel.AutoSize = true;
            this.LeagueLabel.Location = new System.Drawing.Point(120, 71);
            this.LeagueLabel.Name = "LeagueLabel";
            this.LeagueLabel.Size = new System.Drawing.Size(45, 15);
            this.LeagueLabel.TabIndex = 22;
            this.LeagueLabel.Text = "League";
            // 
            // PlayerComboBox
            // 
            this.PlayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerComboBox.FormattingEnabled = true;
            this.PlayerComboBox.Location = new System.Drawing.Point(561, 103);
            this.PlayerComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerComboBox.Name = "PlayerComboBox";
            this.PlayerComboBox.Size = new System.Drawing.Size(133, 23);
            this.PlayerComboBox.TabIndex = 32;
            this.PlayerComboBox.SelectedIndexChanged += new System.EventHandler(this.PlayerComboBox_SelectedIndexChanged);
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(614, 71);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(39, 15);
            this.PlayerLabel.TabIndex = 33;
            this.PlayerLabel.Text = "Player";
            // 
            // RemovingPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.PlayerComboBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.RemovePlayerButton);
            this.Controls.Add(this.TeamComboBox);
            this.Controls.Add(this.TeamLabel);
            this.Controls.Add(this.LeagueComboBox);
            this.Controls.Add(this.LeagueLabel);
            this.Name = "RemovingPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemovingPlayers";
            this.Load += new System.EventHandler(this.RemovingPlayers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton;
        private Button RemovePlayerButton;
        private ComboBox TeamComboBox;
        private Label TeamLabel;
        private ComboBox LeagueComboBox;
        private Label LeagueLabel;
        private ComboBox PlayerComboBox;
        private Label PlayerLabel;
    }
}