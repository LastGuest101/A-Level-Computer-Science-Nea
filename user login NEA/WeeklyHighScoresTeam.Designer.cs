namespace user_login_NEA
{
    partial class WeeklyHighScoresTeam
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
            tableLayoutPanel1 = new TableLayoutPanel();
            FirstTeamSS = new Label();
            SecondTeamSS = new Label();
            ThirdTeamSS = new Label();
            ThirdScratchScore = new Label();
            SecondScratchScore = new Label();
            FirstScratchScore = new Label();
            ScratchScoreLabel = new Label();
            WeekLabel = new Label();
            WeeksComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 0;
            backButton.Text = "Back ";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(FirstTeamSS, 0, 0);
            tableLayoutPanel1.Controls.Add(SecondTeamSS, 0, 1);
            tableLayoutPanel1.Controls.Add(ThirdTeamSS, 0, 2);
            tableLayoutPanel1.Controls.Add(ThirdScratchScore, 1, 2);
            tableLayoutPanel1.Controls.Add(SecondScratchScore, 1, 1);
            tableLayoutPanel1.Controls.Add(FirstScratchScore, 1, 0);
            tableLayoutPanel1.Location = new Point(46, 127);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(250, 125);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // FirstTeamSS
            // 
            FirstTeamSS.AutoSize = true;
            FirstTeamSS.Location = new Point(3, 0);
            FirstTeamSS.Name = "FirstTeamSS";
            FirstTeamSS.Size = new Size(68, 20);
            FirstTeamSS.TabIndex = 3;
            FirstTeamSS.Text = "1st Team";
            FirstTeamSS.Visible = false;
            // 
            // SecondTeamSS
            // 
            SecondTeamSS.AutoSize = true;
            SecondTeamSS.Location = new Point(3, 41);
            SecondTeamSS.Name = "SecondTeamSS";
            SecondTeamSS.Size = new Size(74, 20);
            SecondTeamSS.TabIndex = 4;
            SecondTeamSS.Text = "2nd Team";
            SecondTeamSS.Visible = false;
            // 
            // ThirdTeamSS
            // 
            ThirdTeamSS.AutoSize = true;
            ThirdTeamSS.Location = new Point(3, 82);
            ThirdTeamSS.Name = "ThirdTeamSS";
            ThirdTeamSS.Size = new Size(71, 20);
            ThirdTeamSS.TabIndex = 5;
            ThirdTeamSS.Text = "3rd Team";
            ThirdTeamSS.Visible = false;
            // 
            // ThirdScratchScore
            // 
            ThirdScratchScore.AutoSize = true;
            ThirdScratchScore.Location = new Point(128, 82);
            ThirdScratchScore.Name = "ThirdScratchScore";
            ThirdScratchScore.Size = new Size(116, 20);
            ThirdScratchScore.TabIndex = 6;
            ThirdScratchScore.Text = "3rdScratchScore";
            ThirdScratchScore.Visible = false;
            // 
            // SecondScratchScore
            // 
            SecondScratchScore.AutoSize = true;
            SecondScratchScore.Location = new Point(128, 41);
            SecondScratchScore.Name = "SecondScratchScore";
            SecondScratchScore.Size = new Size(119, 20);
            SecondScratchScore.TabIndex = 7;
            SecondScratchScore.Text = "2ndScratchScore";
            SecondScratchScore.Visible = false;
            // 
            // FirstScratchScore
            // 
            FirstScratchScore.AutoSize = true;
            FirstScratchScore.Location = new Point(128, 0);
            FirstScratchScore.Name = "FirstScratchScore";
            FirstScratchScore.Size = new Size(113, 20);
            FirstScratchScore.TabIndex = 8;
            FirstScratchScore.Text = "1stScratchScore";
            FirstScratchScore.Visible = false;
            // 
            // ScratchScoreLabel
            // 
            ScratchScoreLabel.AutoSize = true;
            ScratchScoreLabel.Location = new Point(139, 56);
            ScratchScoreLabel.Name = "ScratchScoreLabel";
            ScratchScoreLabel.Size = new Size(101, 20);
            ScratchScoreLabel.TabIndex = 2;
            ScratchScoreLabel.Text = "Scratch Score:";
            ScratchScoreLabel.Visible = false;
            // 
            // WeekLabel
            // 
            WeekLabel.AutoSize = true;
            WeekLabel.Location = new Point(341, 16);
            WeekLabel.Name = "WeekLabel";
            WeekLabel.Size = new Size(52, 20);
            WeekLabel.TabIndex = 3;
            WeekLabel.Text = "Week :";
            // 
            // WeeksComboBox
            // 
            WeeksComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WeeksComboBox.FormattingEnabled = true;
            WeeksComboBox.Location = new Point(341, 39);
            WeeksComboBox.Name = "WeeksComboBox";
            WeeksComboBox.Size = new Size(52, 28);
            WeeksComboBox.TabIndex = 4;
            WeeksComboBox.SelectedIndexChanged += WeekComboBox_SelectedIndexChanged;
            // 
            // WeeklyHighScoresTeam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WeeksComboBox);
            Controls.Add(WeekLabel);
            Controls.Add(ScratchScoreLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(backButton);
            Name = "WeeklyHighScoresTeam";
            Text = "WeeklyHighScoresTeam";
            Load += WeeklyHighScoresTeam_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label FirstTeamSS;
        private Label SecondTeamSS;
        private Label ThirdTeamSS;
        private Label ThirdScratchScore;
        private Label SecondScratchScore;
        private Label FirstScratchScore;
        private Label ScratchScoreLabel;
        private Label WeekLabel;
        private ComboBox WeekComboBox;
        private ComboBox WeeksComboBox;
    }
}