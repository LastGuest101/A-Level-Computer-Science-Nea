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
            WeeklyScoresPlayerButton.Location = new Point(464, 220);
            WeeklyScoresPlayerButton.Name = "WeeklyScoresPlayerButton";
            WeeklyScoresPlayerButton.Size = new Size(254, 63);
            WeeklyScoresPlayerButton.TabIndex = 1;
            WeeklyScoresPlayerButton.Text = "Weekly HighScores: (Players)";
            WeeklyScoresPlayerButton.UseVisualStyleBackColor = true;
            WeeklyScoresPlayerButton.Click += button1_Click;
            // 
            // WeeklyScoresTeamButton
            // 
            WeeklyScoresTeamButton.Location = new Point(49, 220);
            WeeklyScoresTeamButton.Name = "WeeklyScoresTeamButton";
            WeeklyScoresTeamButton.Size = new Size(256, 63);
            WeeklyScoresTeamButton.TabIndex = 2;
            WeeklyScoresTeamButton.Text = "Weekly HighScores: (Teams)";
            WeeklyScoresTeamButton.UseVisualStyleBackColor = true;
            WeeklyScoresTeamButton.Click += WeeklyScoresTeamButton_Click;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WeeklyScoresTeamButton);
            Controls.Add(WeeklyScoresPlayerButton);
            Controls.Add(backButton);
            Name = "UserMenu";
            Text = "UserMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private Button WeeklyScoresPlayerButton;
        private Button WeeklyScoresTeamButton;
    }
}