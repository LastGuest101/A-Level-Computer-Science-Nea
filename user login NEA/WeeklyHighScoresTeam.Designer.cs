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
            ThirdScratchGame = new Label();
            SecondScratchGame = new Label();
            FirstScratchGame = new Label();
            ScratchScoreLabel = new Label();
            WeekLabel = new Label();
            WeeksComboBox = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ThirdTeamHS = new Label();
            SecondTeamHS = new Label();
            FirstTeamHS = new Label();
            ThirdHandicapGame = new Label();
            SecondHandicapGame = new Label();
            FirstHandicapGame = new Label();
            HandicapScoreLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            FirstTeamSSeries = new Label();
            SecondTeamSSeries = new Label();
            ThirdTeamSSeries = new Label();
            ThirdScratchSeries = new Label();
            SecondScratchSeries = new Label();
            FirstScratchSeries = new Label();
            ScratchSeriesLabel = new Label();
            HandicapSeriesLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            FirstTeamHSeries = new Label();
            SecondTeamHSeries = new Label();
            ThirdTeamHSeries = new Label();
            ThirdHandicapSeries = new Label();
            SecondHandicapSeries = new Label();
            FirstHandicapSeries = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(ThirdScratchGame, 1, 2);
            tableLayoutPanel1.Controls.Add(SecondScratchGame, 1, 1);
            tableLayoutPanel1.Controls.Add(FirstScratchGame, 1, 0);
            tableLayoutPanel1.Location = new Point(39, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(347, 125);
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
            // ThirdScratchGame
            // 
            ThirdScratchGame.AutoSize = true;
            ThirdScratchGame.Location = new Point(176, 82);
            ThirdScratchGame.Name = "ThirdScratchGame";
            ThirdScratchGame.Size = new Size(116, 20);
            ThirdScratchGame.TabIndex = 6;
            ThirdScratchGame.Text = "3rdScratchScore";
            ThirdScratchGame.Visible = false;
            // 
            // SecondScratchGame
            // 
            SecondScratchGame.AutoSize = true;
            SecondScratchGame.Location = new Point(176, 41);
            SecondScratchGame.Name = "SecondScratchGame";
            SecondScratchGame.Size = new Size(119, 20);
            SecondScratchGame.TabIndex = 7;
            SecondScratchGame.Text = "2ndScratchScore";
            SecondScratchGame.Visible = false;
            // 
            // FirstScratchGame
            // 
            FirstScratchGame.AutoSize = true;
            FirstScratchGame.Location = new Point(176, 0);
            FirstScratchGame.Name = "FirstScratchGame";
            FirstScratchGame.Size = new Size(113, 20);
            FirstScratchGame.TabIndex = 8;
            FirstScratchGame.Text = "1stScratchScore";
            FirstScratchGame.Visible = false;
            // 
            // ScratchScoreLabel
            // 
            ScratchScoreLabel.AutoSize = true;
            ScratchScoreLabel.Location = new Point(109, 47);
            ScratchScoreLabel.Name = "ScratchScoreLabel";
            ScratchScoreLabel.Size = new Size(103, 20);
            ScratchScoreLabel.TabIndex = 2;
            ScratchScoreLabel.Text = "Scratch Game:";
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ThirdTeamHS, 0, 2);
            tableLayoutPanel2.Controls.Add(SecondTeamHS, 0, 1);
            tableLayoutPanel2.Controls.Add(FirstTeamHS, 0, 0);
            tableLayoutPanel2.Controls.Add(ThirdHandicapGame, 1, 2);
            tableLayoutPanel2.Controls.Add(SecondHandicapGame, 1, 1);
            tableLayoutPanel2.Controls.Add(FirstHandicapGame, 1, 0);
            tableLayoutPanel2.Location = new Point(422, 89);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(347, 125);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // ThirdTeamHS
            // 
            ThirdTeamHS.AutoSize = true;
            ThirdTeamHS.Location = new Point(3, 82);
            ThirdTeamHS.Name = "ThirdTeamHS";
            ThirdTeamHS.Size = new Size(71, 20);
            ThirdTeamHS.TabIndex = 8;
            ThirdTeamHS.Text = "3rd Team";
            ThirdTeamHS.Visible = false;
            // 
            // SecondTeamHS
            // 
            SecondTeamHS.AutoSize = true;
            SecondTeamHS.Location = new Point(3, 41);
            SecondTeamHS.Name = "SecondTeamHS";
            SecondTeamHS.Size = new Size(74, 20);
            SecondTeamHS.TabIndex = 9;
            SecondTeamHS.Text = "2nd Team";
            SecondTeamHS.Visible = false;
            // 
            // FirstTeamHS
            // 
            FirstTeamHS.AutoSize = true;
            FirstTeamHS.Location = new Point(3, 0);
            FirstTeamHS.Name = "FirstTeamHS";
            FirstTeamHS.Size = new Size(68, 20);
            FirstTeamHS.TabIndex = 10;
            FirstTeamHS.Text = "1st Team";
            FirstTeamHS.Visible = false;
            // 
            // ThirdHandicapGame
            // 
            ThirdHandicapGame.AutoSize = true;
            ThirdHandicapGame.Location = new Point(176, 82);
            ThirdHandicapGame.Name = "ThirdHandicapGame";
            ThirdHandicapGame.Size = new Size(134, 20);
            ThirdHandicapGame.TabIndex = 11;
            ThirdHandicapGame.Text = "3rdHandicapGame";
            ThirdHandicapGame.Visible = false;
            // 
            // SecondHandicapGame
            // 
            SecondHandicapGame.AutoSize = true;
            SecondHandicapGame.Location = new Point(176, 41);
            SecondHandicapGame.Name = "SecondHandicapGame";
            SecondHandicapGame.Size = new Size(137, 20);
            SecondHandicapGame.TabIndex = 12;
            SecondHandicapGame.Text = "2ndHandicapGame";
            SecondHandicapGame.Visible = false;
            // 
            // FirstHandicapGame
            // 
            FirstHandicapGame.AutoSize = true;
            FirstHandicapGame.Location = new Point(176, 0);
            FirstHandicapGame.Name = "FirstHandicapGame";
            FirstHandicapGame.Size = new Size(131, 20);
            FirstHandicapGame.TabIndex = 6;
            FirstHandicapGame.Text = "1stHandicapGame";
            FirstHandicapGame.Visible = false;
            // 
            // HandicapScoreLabel
            // 
            HandicapScoreLabel.AutoSize = true;
            HandicapScoreLabel.Location = new Point(492, 47);
            HandicapScoreLabel.Name = "HandicapScoreLabel";
            HandicapScoreLabel.Size = new Size(119, 20);
            HandicapScoreLabel.TabIndex = 7;
            HandicapScoreLabel.Text = "Handicap Game:";
            HandicapScoreLabel.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(FirstTeamSSeries, 0, 0);
            tableLayoutPanel3.Controls.Add(SecondTeamSSeries, 0, 1);
            tableLayoutPanel3.Controls.Add(ThirdTeamSSeries, 0, 2);
            tableLayoutPanel3.Controls.Add(ThirdScratchSeries, 1, 2);
            tableLayoutPanel3.Controls.Add(SecondScratchSeries, 1, 1);
            tableLayoutPanel3.Controls.Add(FirstScratchSeries, 1, 0);
            tableLayoutPanel3.Location = new Point(39, 302);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(347, 125);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // FirstTeamSSeries
            // 
            FirstTeamSSeries.AutoSize = true;
            FirstTeamSSeries.Location = new Point(3, 0);
            FirstTeamSSeries.Name = "FirstTeamSSeries";
            FirstTeamSSeries.Size = new Size(68, 20);
            FirstTeamSSeries.TabIndex = 3;
            FirstTeamSSeries.Text = "1st Team";
            FirstTeamSSeries.Visible = false;
            // 
            // SecondTeamSSeries
            // 
            SecondTeamSSeries.AutoSize = true;
            SecondTeamSSeries.Location = new Point(3, 41);
            SecondTeamSSeries.Name = "SecondTeamSSeries";
            SecondTeamSSeries.Size = new Size(74, 20);
            SecondTeamSSeries.TabIndex = 4;
            SecondTeamSSeries.Text = "2nd Team";
            SecondTeamSSeries.Visible = false;
            // 
            // ThirdTeamSSeries
            // 
            ThirdTeamSSeries.AutoSize = true;
            ThirdTeamSSeries.Location = new Point(3, 82);
            ThirdTeamSSeries.Name = "ThirdTeamSSeries";
            ThirdTeamSSeries.Size = new Size(71, 20);
            ThirdTeamSSeries.TabIndex = 5;
            ThirdTeamSSeries.Text = "3rd Team";
            ThirdTeamSSeries.Visible = false;
            // 
            // ThirdScratchSeries
            // 
            ThirdScratchSeries.AutoSize = true;
            ThirdScratchSeries.Location = new Point(176, 82);
            ThirdScratchSeries.Name = "ThirdScratchSeries";
            ThirdScratchSeries.Size = new Size(118, 20);
            ThirdScratchSeries.TabIndex = 6;
            ThirdScratchSeries.Text = "3rdScratchSeries";
            ThirdScratchSeries.Visible = false;
            // 
            // SecondScratchSeries
            // 
            SecondScratchSeries.AutoSize = true;
            SecondScratchSeries.Location = new Point(176, 41);
            SecondScratchSeries.Name = "SecondScratchSeries";
            SecondScratchSeries.Size = new Size(121, 20);
            SecondScratchSeries.TabIndex = 7;
            SecondScratchSeries.Text = "2ndScratchSeries";
            SecondScratchSeries.Visible = false;
            // 
            // FirstScratchSeries
            // 
            FirstScratchSeries.AutoSize = true;
            FirstScratchSeries.Location = new Point(176, 0);
            FirstScratchSeries.Name = "FirstScratchSeries";
            FirstScratchSeries.Size = new Size(115, 20);
            FirstScratchSeries.TabIndex = 8;
            FirstScratchSeries.Text = "1stScratchSeries";
            FirstScratchSeries.Visible = false;
            // 
            // ScratchSeriesLabel
            // 
            ScratchSeriesLabel.AutoSize = true;
            ScratchSeriesLabel.Location = new Point(109, 263);
            ScratchSeriesLabel.Name = "ScratchSeriesLabel";
            ScratchSeriesLabel.Size = new Size(103, 20);
            ScratchSeriesLabel.TabIndex = 9;
            ScratchSeriesLabel.Text = "Scratch Series:";
            ScratchSeriesLabel.Visible = false;
            // 
            // HandicapSeriesLabel
            // 
            HandicapSeriesLabel.AutoSize = true;
            HandicapSeriesLabel.Location = new Point(492, 263);
            HandicapSeriesLabel.Name = "HandicapSeriesLabel";
            HandicapSeriesLabel.Size = new Size(119, 20);
            HandicapSeriesLabel.TabIndex = 11;
            HandicapSeriesLabel.Text = "Handicap Series:";
            HandicapSeriesLabel.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(FirstTeamHSeries, 0, 0);
            tableLayoutPanel4.Controls.Add(SecondTeamHSeries, 0, 1);
            tableLayoutPanel4.Controls.Add(ThirdTeamHSeries, 0, 2);
            tableLayoutPanel4.Controls.Add(ThirdHandicapSeries, 1, 2);
            tableLayoutPanel4.Controls.Add(SecondHandicapSeries, 1, 1);
            tableLayoutPanel4.Controls.Add(FirstHandicapSeries, 1, 0);
            tableLayoutPanel4.Location = new Point(422, 302);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(347, 125);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // FirstTeamHSeries
            // 
            FirstTeamHSeries.AutoSize = true;
            FirstTeamHSeries.Location = new Point(3, 0);
            FirstTeamHSeries.Name = "FirstTeamHSeries";
            FirstTeamHSeries.Size = new Size(68, 20);
            FirstTeamHSeries.TabIndex = 3;
            FirstTeamHSeries.Text = "1st Team";
            FirstTeamHSeries.Visible = false;
            // 
            // SecondTeamHSeries
            // 
            SecondTeamHSeries.AutoSize = true;
            SecondTeamHSeries.Location = new Point(3, 41);
            SecondTeamHSeries.Name = "SecondTeamHSeries";
            SecondTeamHSeries.Size = new Size(74, 20);
            SecondTeamHSeries.TabIndex = 4;
            SecondTeamHSeries.Text = "2nd Team";
            SecondTeamHSeries.Visible = false;
            // 
            // ThirdTeamHSeries
            // 
            ThirdTeamHSeries.AutoSize = true;
            ThirdTeamHSeries.Location = new Point(3, 82);
            ThirdTeamHSeries.Name = "ThirdTeamHSeries";
            ThirdTeamHSeries.Size = new Size(71, 20);
            ThirdTeamHSeries.TabIndex = 5;
            ThirdTeamHSeries.Text = "3rd Team";
            ThirdTeamHSeries.Visible = false;
            // 
            // ThirdHandicapSeries
            // 
            ThirdHandicapSeries.AutoSize = true;
            ThirdHandicapSeries.Location = new Point(176, 82);
            ThirdHandicapSeries.Name = "ThirdHandicapSeries";
            ThirdHandicapSeries.Size = new Size(134, 20);
            ThirdHandicapSeries.TabIndex = 6;
            ThirdHandicapSeries.Text = "3rdHandicapSeries";
            ThirdHandicapSeries.Visible = false;
            // 
            // SecondHandicapSeries
            // 
            SecondHandicapSeries.AutoSize = true;
            SecondHandicapSeries.Location = new Point(176, 41);
            SecondHandicapSeries.Name = "SecondHandicapSeries";
            SecondHandicapSeries.Size = new Size(137, 20);
            SecondHandicapSeries.TabIndex = 7;
            SecondHandicapSeries.Text = "2ndHandicapSeries";
            SecondHandicapSeries.Visible = false;
            // 
            // FirstHandicapSeries
            // 
            FirstHandicapSeries.AutoSize = true;
            FirstHandicapSeries.Location = new Point(176, 0);
            FirstHandicapSeries.Name = "FirstHandicapSeries";
            FirstHandicapSeries.Size = new Size(131, 20);
            FirstHandicapSeries.TabIndex = 8;
            FirstHandicapSeries.Text = "1stHandicapSeries";
            FirstHandicapSeries.Visible = false;
            // 
            // WeeklyHighScoresTeam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HandicapSeriesLabel);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(ScratchSeriesLabel);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(HandicapScoreLabel);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(WeeksComboBox);
            Controls.Add(WeekLabel);
            Controls.Add(ScratchScoreLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(backButton);
            Name = "WeeklyHighScoresTeam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WeeklyHighScoresTeam";
            Load += WeeklyHighScoresTeam_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label FirstTeamSS;
        private Label SecondTeamSS;
        private Label ThirdTeamSS;
        private Label ThirdScratchGame;
        private Label SecondScratchGame;
        private Label FirstScratchGame;
        private Label ScratchScoreLabel;
        private Label WeekLabel;
        private ComboBox WeekComboBox;
        private ComboBox WeeksComboBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label ThirdTeamHS;
        private Label SecondTeamHS;
        private Label FirstTeamHS;
        private Label ThirdHandicapGame;
        private Label SecondHandicapGame;
        private Label FirstHandicapGame;
        private Label HandicapScoreLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label FirstTeamSSeries;
        private Label SecondTeamSSeries;
        private Label ThirdTeamSSeries;
        private Label ThirdScratchSeries;
        private Label SecondScratchSeries;
        private Label FirstScratchSeries;
        private Label ScratchSeriesLabel;
        private Label HandicapSeriesLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private Label FirstTeamHSeries;
        private Label SecondTeamHSeries;
        private Label ThirdTeamHSeries;
        private Label ThirdHandicapSeries;
        private Label SecondHandicapSeries;
        private Label FirstHandicapSeries;
    }
}