namespace user_login_NEA
{
    partial class UserMenu
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
            backButton = new Button();
            WeeklyScoresPlayerButton = new Button();
            WeeklyScoresTeamButton = new Button();
            StandingsButton = new Button();
            LeagueComboBox = new ComboBox();
            LeagueLabel = new Label();
            TeamLabel = new Label();
            BowlerLabel = new Label();
            PlaceLabel = new Label();
            AverageLabel = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // WeeklyScoresPlayerButton
            // 
            WeeklyScoresPlayerButton.Location = new Point(474, 155);
            WeeklyScoresPlayerButton.Name = "WeeklyScoresPlayerButton";
            WeeklyScoresPlayerButton.Size = new Size(258, 61);
            WeeklyScoresPlayerButton.TabIndex = 1;
            WeeklyScoresPlayerButton.Text = "Weekly HighScores: (Players)";
            WeeklyScoresPlayerButton.UseVisualStyleBackColor = true;
            WeeklyScoresPlayerButton.Visible = false;
            WeeklyScoresPlayerButton.Click += WeeklyScoresPlayerButton_Click;
            // 
            // WeeklyScoresTeamButton
            // 
            WeeklyScoresTeamButton.Location = new Point(474, 261);
            WeeklyScoresTeamButton.Name = "WeeklyScoresTeamButton";
            WeeklyScoresTeamButton.Size = new Size(258, 61);
            WeeklyScoresTeamButton.TabIndex = 2;
            WeeklyScoresTeamButton.Text = "Weekly HighScores: (Teams)";
            WeeklyScoresTeamButton.UseVisualStyleBackColor = true;
            WeeklyScoresTeamButton.Visible = false;
            WeeklyScoresTeamButton.Click += WeeklyScoresTeamButton_Click;
            // 
            // StandingsButton
            // 
            StandingsButton.Location = new Point(474, 56);
            StandingsButton.Name = "StandingsButton";
            StandingsButton.Size = new Size(256, 61);
            StandingsButton.TabIndex = 3;
            StandingsButton.Text = "Standings";
            StandingsButton.UseVisualStyleBackColor = true;
            StandingsButton.Visible = false;
            StandingsButton.Click += StandingsButton_Click;
            // 
            // LeagueComboBox
            // 
            LeagueComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LeagueComboBox.FormattingEnabled = true;
            LeagueComboBox.Location = new Point(93, 136);
            LeagueComboBox.Name = "LeagueComboBox";
            LeagueComboBox.Size = new Size(239, 28);
            LeagueComboBox.TabIndex = 4;
            LeagueComboBox.SelectedIndexChanged += LeagueComboBox_SelectedIndexChanged;
            // 
            // LeagueLabel
            // 
            LeagueLabel.AutoSize = true;
            LeagueLabel.Location = new Point(145, 97);
            LeagueLabel.Name = "LeagueLabel";
            LeagueLabel.Size = new Size(113, 20);
            LeagueLabel.TabIndex = 5;
            LeagueLabel.Text = "Select a league:";
            // 
            // TeamLabel
            // 
            TeamLabel.AutoSize = true;
            TeamLabel.Location = new Point(167, 12);
            TeamLabel.Name = "TeamLabel";
            TeamLabel.Size = new Size(45, 20);
            TeamLabel.TabIndex = 6;
            TeamLabel.Text = "Team";
            TeamLabel.Visible = false;
            // 
            // BowlerLabel
            // 
            BowlerLabel.AutoSize = true;
            BowlerLabel.Location = new Point(167, 46);
            BowlerLabel.Name = "BowlerLabel";
            BowlerLabel.Size = new Size(55, 20);
            BowlerLabel.TabIndex = 7;
            BowlerLabel.Text = "Bowler";
            BowlerLabel.Visible = false;
            // 
            // PlaceLabel
            // 
            PlaceLabel.AutoSize = true;
            PlaceLabel.Location = new Point(364, 12);
            PlaceLabel.Name = "PlaceLabel";
            PlaceLabel.Size = new Size(44, 20);
            PlaceLabel.TabIndex = 8;
            PlaceLabel.Text = "Place";
            PlaceLabel.Visible = false;
            // 
            // AverageLabel
            // 
            AverageLabel.AutoSize = true;
            AverageLabel.Location = new Point(364, 46);
            AverageLabel.Name = "AverageLabel";
            AverageLabel.Size = new Size(64, 20);
            AverageLabel.TabIndex = 9;
            AverageLabel.Text = "Average";
            AverageLabel.Visible = false;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 334);
            Controls.Add(AverageLabel);
            Controls.Add(PlaceLabel);
            Controls.Add(BowlerLabel);
            Controls.Add(TeamLabel);
            Controls.Add(LeagueLabel);
            Controls.Add(LeagueComboBox);
            Controls.Add(StandingsButton);
            Controls.Add(WeeklyScoresTeamButton);
            Controls.Add(WeeklyScoresPlayerButton);
            Controls.Add(backButton);
            Name = "UserMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMenu";
            Load += UserMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button WeeklyScoresPlayerButton;
        private Button WeeklyScoresTeamButton;
        private Button StandingsButton;
        private ComboBox LeagueComboBox;
        private Label LeagueLabel;
        private Label TeamLabel;
        private Label BowlerLabel;
        private Label PlaceLabel;
        private Label AverageLabel;
    }
}