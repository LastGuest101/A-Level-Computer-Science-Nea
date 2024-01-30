namespace user_login_NEA
{
    partial class SelectingPlayers
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
            this.Team1 = new System.Windows.Forms.Label();
            this.Team2 = new System.Windows.Forms.Label();
            this.SelectPlayersTeam1 = new System.Windows.Forms.ListBox();
            this.SelectPlayersTeam2 = new System.Windows.Forms.ListBox();
            this.SelectPlayers = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.WeeksCombobox = new System.Windows.Forms.ComboBox();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.MatchComboBox = new System.Windows.Forms.ComboBox();
            this.MatchLabel = new System.Windows.Forms.Label();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.CompletedComboBox = new System.Windows.Forms.ComboBox();
            this.LeagueLabel = new System.Windows.Forms.Label();
            this.LeagueComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Team1
            // 
            this.Team1.AutoSize = true;
            this.Team1.Location = new System.Drawing.Point(183, 76);
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(41, 15);
            this.Team1.TabIndex = 0;
            this.Team1.Text = "Team1";
            // 
            // Team2
            // 
            this.Team2.AutoSize = true;
            this.Team2.Location = new System.Drawing.Point(461, 76);
            this.Team2.Name = "Team2";
            this.Team2.Size = new System.Drawing.Size(41, 15);
            this.Team2.TabIndex = 1;
            this.Team2.Text = "Team2";
            // 
            // SelectPlayersTeam1
            // 
            this.SelectPlayersTeam1.FormattingEnabled = true;
            this.SelectPlayersTeam1.ItemHeight = 15;
            this.SelectPlayersTeam1.Location = new System.Drawing.Point(98, 118);
            this.SelectPlayersTeam1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectPlayersTeam1.Name = "SelectPlayersTeam1";
            this.SelectPlayersTeam1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SelectPlayersTeam1.Size = new System.Drawing.Size(132, 79);
            this.SelectPlayersTeam1.TabIndex = 2;
            // 
            // SelectPlayersTeam2
            // 
            this.SelectPlayersTeam2.FormattingEnabled = true;
            this.SelectPlayersTeam2.ItemHeight = 15;
            this.SelectPlayersTeam2.Location = new System.Drawing.Point(443, 118);
            this.SelectPlayersTeam2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectPlayersTeam2.Name = "SelectPlayersTeam2";
            this.SelectPlayersTeam2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SelectPlayersTeam2.Size = new System.Drawing.Size(132, 79);
            this.SelectPlayersTeam2.TabIndex = 3;
            // 
            // SelectPlayers
            // 
            this.SelectPlayers.Location = new System.Drawing.Point(286, 174);
            this.SelectPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectPlayers.Name = "SelectPlayers";
            this.SelectPlayers.Size = new System.Drawing.Size(82, 22);
            this.SelectPlayers.TabIndex = 5;
            this.SelectPlayers.Text = "Select";
            this.SelectPlayers.UseVisualStyleBackColor = true;
            this.SelectPlayers.Click += new System.EventHandler(this.SelectPlayers_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(10, 9);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(82, 22);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // WeeksCombobox
            // 
            this.WeeksCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeeksCombobox.FormattingEnabled = true;
            this.WeeksCombobox.Location = new System.Drawing.Point(136, 37);
            this.WeeksCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeeksCombobox.Name = "WeeksCombobox";
            this.WeeksCombobox.Size = new System.Drawing.Size(56, 23);
            this.WeeksCombobox.TabIndex = 7;
            this.WeeksCombobox.SelectedIndexChanged += new System.EventHandler(this.WeeksCombobox_SelectedIndexChanged);
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Location = new System.Drawing.Point(136, 16);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(42, 15);
            this.WeekLabel.TabIndex = 8;
            this.WeekLabel.Text = "Week :";
            // 
            // MatchComboBox
            // 
            this.MatchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchComboBox.FormattingEnabled = true;
            this.MatchComboBox.Location = new System.Drawing.Point(410, 37);
            this.MatchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatchComboBox.Name = "MatchComboBox";
            this.MatchComboBox.Size = new System.Drawing.Size(278, 23);
            this.MatchComboBox.TabIndex = 9;
            this.MatchComboBox.SelectedIndexChanged += new System.EventHandler(this.MatchComboBox_SelectedIndexChanged);
            // 
            // MatchLabel
            // 
            this.MatchLabel.AutoSize = true;
            this.MatchLabel.Location = new System.Drawing.Point(410, 16);
            this.MatchLabel.Name = "MatchLabel";
            this.MatchLabel.Size = new System.Drawing.Size(47, 15);
            this.MatchLabel.TabIndex = 10;
            this.MatchLabel.Text = "Match :";
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.AutoSize = true;
            this.CompletedLabel.Location = new System.Drawing.Point(79, 238);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(72, 15);
            this.CompletedLabel.TabIndex = 11;
            this.CompletedLabel.Text = "Completed :";
            // 
            // CompletedComboBox
            // 
            this.CompletedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompletedComboBox.FormattingEnabled = true;
            this.CompletedComboBox.Location = new System.Drawing.Point(79, 263);
            this.CompletedComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompletedComboBox.Name = "CompletedComboBox";
            this.CompletedComboBox.Size = new System.Drawing.Size(267, 23);
            this.CompletedComboBox.TabIndex = 12;
            // 
            // LeagueLabel
            // 
            this.LeagueLabel.AutoSize = true;
            this.LeagueLabel.Location = new System.Drawing.Point(286, 16);
            this.LeagueLabel.Name = "LeagueLabel";
            this.LeagueLabel.Size = new System.Drawing.Size(51, 15);
            this.LeagueLabel.TabIndex = 13;
            this.LeagueLabel.Text = "League :";
            // 
            // LeagueComboBox
            // 
            this.LeagueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeagueComboBox.FormattingEnabled = true;
            this.LeagueComboBox.Location = new System.Drawing.Point(262, 37);
            this.LeagueComboBox.Name = "LeagueComboBox";
            this.LeagueComboBox.Size = new System.Drawing.Size(121, 23);
            this.LeagueComboBox.TabIndex = 14;
            this.LeagueComboBox.SelectedIndexChanged += new System.EventHandler(this.LeagueComboBox_SelectedIndexChanged);
            // 
            // SelectingPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.LeagueComboBox);
            this.Controls.Add(this.LeagueLabel);
            this.Controls.Add(this.CompletedComboBox);
            this.Controls.Add(this.CompletedLabel);
            this.Controls.Add(this.MatchLabel);
            this.Controls.Add(this.MatchComboBox);
            this.Controls.Add(this.WeekLabel);
            this.Controls.Add(this.WeeksCombobox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SelectPlayers);
            this.Controls.Add(this.SelectPlayersTeam2);
            this.Controls.Add(this.SelectPlayersTeam1);
            this.Controls.Add(this.Team2);
            this.Controls.Add(this.Team1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectingPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectingPlayers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Team1;
        private Label Team2;
        private ListBox SelectPlayersTeam1;
        private ListBox SelectPlayersTeam2;
        private Button SelectPlayers;
        private Button BackButton;
        private ComboBox WeeksCombobox;
        private Label WeekLabel;
        private ComboBox MatchComboBox;
        private Label MatchLabel;
        private Label CompletedLabel;
        private ComboBox CompletedComboBox;
        private Label LeagueLabel;
        private ComboBox LeagueComboBox;
    }
}