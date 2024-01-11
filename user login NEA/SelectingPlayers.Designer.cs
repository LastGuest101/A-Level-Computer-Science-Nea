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
            Team1 = new Label();
            Team2 = new Label();
            SelectPlayersTeam1 = new ListBox();
            SelectPlayersTeam2 = new ListBox();
            SelectPlayers = new Button();
            BackButton = new Button();
            WeeksCombobox = new ComboBox();
            WeekLabel = new Label();
            MatchComboBox = new ComboBox();
            MatchLabel = new Label();
            CompletedLabel = new Label();
            CompletedComboBox = new ComboBox();
            SuspendLayout();
            // 
            // Team1
            // 
            Team1.AutoSize = true;
            Team1.Location = new Point(209, 102);
            Team1.Name = "Team1";
            Team1.Size = new Size(53, 20);
            Team1.TabIndex = 0;
            Team1.Text = "Team1";
            // 
            // Team2
            // 
            Team2.AutoSize = true;
            Team2.Location = new Point(527, 102);
            Team2.Name = "Team2";
            Team2.Size = new Size(53, 20);
            Team2.TabIndex = 1;
            Team2.Text = "Team2";
            // 
            // SelectPlayersTeam1
            // 
            SelectPlayersTeam1.FormattingEnabled = true;
            SelectPlayersTeam1.ItemHeight = 20;
            SelectPlayersTeam1.Location = new Point(112, 157);
            SelectPlayersTeam1.Name = "SelectPlayersTeam1";
            SelectPlayersTeam1.SelectionMode = SelectionMode.MultiSimple;
            SelectPlayersTeam1.Size = new Size(150, 104);
            SelectPlayersTeam1.TabIndex = 2;
            // 
            // SelectPlayersTeam2
            // 
            SelectPlayersTeam2.FormattingEnabled = true;
            SelectPlayersTeam2.ItemHeight = 20;
            SelectPlayersTeam2.Location = new Point(506, 157);
            SelectPlayersTeam2.Name = "SelectPlayersTeam2";
            SelectPlayersTeam2.SelectionMode = SelectionMode.MultiSimple;
            SelectPlayersTeam2.Size = new Size(150, 104);
            SelectPlayersTeam2.TabIndex = 3;
            // 
            // SelectPlayers
            // 
            SelectPlayers.Location = new Point(327, 232);
            SelectPlayers.Name = "SelectPlayers";
            SelectPlayers.Size = new Size(94, 29);
            SelectPlayers.TabIndex = 5;
            SelectPlayers.Text = "Select";
            SelectPlayers.UseVisualStyleBackColor = true;
            SelectPlayers.Click += SelectPlayers_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // WeeksCombobox
            // 
            WeeksCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            WeeksCombobox.FormattingEnabled = true;
            WeeksCombobox.Location = new Point(156, 49);
            WeeksCombobox.Name = "WeeksCombobox";
            WeeksCombobox.Size = new Size(63, 28);
            WeeksCombobox.TabIndex = 7;
            WeeksCombobox.SelectedIndexChanged += WeeksCombobox_SelectedIndexChanged;
            // 
            // WeekLabel
            // 
            WeekLabel.AutoSize = true;
            WeekLabel.Location = new Point(156, 22);
            WeekLabel.Name = "WeekLabel";
            WeekLabel.Size = new Size(52, 20);
            WeekLabel.TabIndex = 8;
            WeekLabel.Text = "Week :";
            // 
            // MatchComboBox
            // 
            MatchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MatchComboBox.FormattingEnabled = true;
            MatchComboBox.Location = new Point(393, 49);
            MatchComboBox.Name = "MatchComboBox";
            MatchComboBox.Size = new Size(317, 28);
            MatchComboBox.TabIndex = 9;
            MatchComboBox.SelectedIndexChanged += MatchComboBox_SelectedIndexChanged;
            // 
            // MatchLabel
            // 
            MatchLabel.AutoSize = true;
            MatchLabel.Location = new Point(393, 22);
            MatchLabel.Name = "MatchLabel";
            MatchLabel.Size = new Size(57, 20);
            MatchLabel.TabIndex = 10;
            MatchLabel.Text = "Match :";
            // 
            // CompletedLabel
            // 
            CompletedLabel.AutoSize = true;
            CompletedLabel.Location = new Point(90, 318);
            CompletedLabel.Name = "CompletedLabel";
            CompletedLabel.Size = new Size(90, 20);
            CompletedLabel.TabIndex = 11;
            CompletedLabel.Text = "Completed :";
            // 
            // CompletedComboBox
            // 
            CompletedComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CompletedComboBox.FormattingEnabled = true;
            CompletedComboBox.Location = new Point(90, 351);
            CompletedComboBox.Name = "CompletedComboBox";
            CompletedComboBox.Size = new Size(305, 28);
            CompletedComboBox.TabIndex = 12;
            CompletedComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // SelectingPlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CompletedComboBox);
            Controls.Add(CompletedLabel);
            Controls.Add(MatchLabel);
            Controls.Add(MatchComboBox);
            Controls.Add(WeekLabel);
            Controls.Add(WeeksCombobox);
            Controls.Add(BackButton);
            Controls.Add(SelectPlayers);
            Controls.Add(SelectPlayersTeam2);
            Controls.Add(SelectPlayersTeam1);
            Controls.Add(Team2);
            Controls.Add(Team1);
            Name = "SelectingPlayers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SelectingPlayers";
            ResumeLayout(false);
            PerformLayout();
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
    }
}