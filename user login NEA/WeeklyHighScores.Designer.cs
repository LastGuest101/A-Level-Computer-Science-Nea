namespace user_login_NEA
{
    partial class WeeklyHighScores
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
            ScratchSeriesTableLayout = new TableLayoutPanel();
            FirstPlayerSS = new Label();
            SecondPlayerSS = new Label();
            ThirdPlayerSS = new Label();
            FirstScratchScore = new Label();
            SecondScratchScore = new Label();
            ThirdScratchScore = new Label();
            WeekLabel = new Label();
            WeeksComboBox = new ComboBox();
            BackButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            FirstPlayerHS = new Label();
            SecondPlayerHS = new Label();
            ThirdPlayerHS = new Label();
            FirstHandicapScore = new Label();
            SecondHandicapScore = new Label();
            ThirdHandicapScore = new Label();
            HighestScratchGames = new Label();
            HighestHandicapGames = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            FirstPlayerSSeries = new Label();
            SecondPlayerSSeries = new Label();
            ThirdPlayerSSeries = new Label();
            FirstScratchSeries = new Label();
            SecondScratchSeries = new Label();
            ThirdScratchSeries = new Label();
            ScratchSeriesLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            ThirdPlayerHSeries = new Label();
            SecondPlayerHSeries = new Label();
            FirstPlayerHSeries = new Label();
            ThirdHandicapSeries = new Label();
            SecondHandicapSeries = new Label();
            FirstHandicapSeries = new Label();
            HandicapSeriesLabel = new Label();
            ScratchSeriesTableLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // ScratchSeriesTableLayout
            // 
            ScratchSeriesTableLayout.ColumnCount = 2;
            ScratchSeriesTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ScratchSeriesTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ScratchSeriesTableLayout.Controls.Add(FirstPlayerSS, 0, 0);
            ScratchSeriesTableLayout.Controls.Add(SecondPlayerSS, 0, 1);
            ScratchSeriesTableLayout.Controls.Add(ThirdPlayerSS, 0, 2);
            ScratchSeriesTableLayout.Controls.Add(FirstScratchScore, 1, 0);
            ScratchSeriesTableLayout.Controls.Add(SecondScratchScore, 1, 1);
            ScratchSeriesTableLayout.Controls.Add(ThirdScratchScore, 1, 2);
            ScratchSeriesTableLayout.Location = new Point(18, 60);
            ScratchSeriesTableLayout.Name = "ScratchSeriesTableLayout";
            ScratchSeriesTableLayout.RowCount = 3;
            ScratchSeriesTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ScratchSeriesTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ScratchSeriesTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ScratchSeriesTableLayout.Size = new Size(372, 125);
            ScratchSeriesTableLayout.TabIndex = 0;
            // 
            // FirstPlayerSS
            // 
            FirstPlayerSS.AutoSize = true;
            FirstPlayerSS.Location = new Point(3, 0);
            FirstPlayerSS.Name = "FirstPlayerSS";
            FirstPlayerSS.Size = new Size(72, 20);
            FirstPlayerSS.TabIndex = 0;
            FirstPlayerSS.Text = "1st Player";
            FirstPlayerSS.Visible = false;
            // 
            // SecondPlayerSS
            // 
            SecondPlayerSS.AutoSize = true;
            SecondPlayerSS.Location = new Point(3, 41);
            SecondPlayerSS.Name = "SecondPlayerSS";
            SecondPlayerSS.Size = new Size(78, 20);
            SecondPlayerSS.TabIndex = 1;
            SecondPlayerSS.Text = "2nd Player";
            SecondPlayerSS.Visible = false;
            // 
            // ThirdPlayerSS
            // 
            ThirdPlayerSS.AutoSize = true;
            ThirdPlayerSS.Location = new Point(3, 82);
            ThirdPlayerSS.Name = "ThirdPlayerSS";
            ThirdPlayerSS.Size = new Size(75, 20);
            ThirdPlayerSS.TabIndex = 2;
            ThirdPlayerSS.Text = "3rd Player";
            ThirdPlayerSS.Visible = false;
            // 
            // FirstScratchScore
            // 
            FirstScratchScore.AutoSize = true;
            FirstScratchScore.Location = new Point(189, 0);
            FirstScratchScore.Name = "FirstScratchScore";
            FirstScratchScore.Size = new Size(121, 20);
            FirstScratchScore.TabIndex = 3;
            FirstScratchScore.Text = "FirstScratchScore";
            FirstScratchScore.Visible = false;
            // 
            // SecondScratchScore
            // 
            SecondScratchScore.AutoSize = true;
            SecondScratchScore.Location = new Point(189, 41);
            SecondScratchScore.Name = "SecondScratchScore";
            SecondScratchScore.Size = new Size(143, 20);
            SecondScratchScore.TabIndex = 4;
            SecondScratchScore.Text = "SecondScratchScore";
            SecondScratchScore.Visible = false;
            // 
            // ThirdScratchScore
            // 
            ThirdScratchScore.AutoSize = true;
            ThirdScratchScore.Location = new Point(189, 82);
            ThirdScratchScore.Name = "ThirdScratchScore";
            ThirdScratchScore.Size = new Size(128, 20);
            ThirdScratchScore.TabIndex = 5;
            ThirdScratchScore.Text = "ThirdScratchScore";
            ThirdScratchScore.Visible = false;
            // 
            // WeekLabel
            // 
            WeekLabel.AutoSize = true;
            WeekLabel.Location = new Point(342, 9);
            WeekLabel.Name = "WeekLabel";
            WeekLabel.Size = new Size(48, 20);
            WeekLabel.TabIndex = 1;
            WeekLabel.Text = "Week:";
            // 
            // WeeksComboBox
            // 
            WeeksComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WeeksComboBox.FormattingEnabled = true;
            WeeksComboBox.Location = new Point(342, 32);
            WeeksComboBox.Name = "WeeksComboBox";
            WeeksComboBox.Size = new Size(48, 28);
            WeeksComboBox.TabIndex = 2;
            WeeksComboBox.SelectedIndexChanged += WeeksComboBox_SelectedIndexChanged;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(15, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(FirstPlayerHS, 0, 0);
            tableLayoutPanel1.Controls.Add(SecondPlayerHS, 0, 1);
            tableLayoutPanel1.Controls.Add(ThirdPlayerHS, 0, 2);
            tableLayoutPanel1.Controls.Add(FirstHandicapScore, 1, 0);
            tableLayoutPanel1.Controls.Add(SecondHandicapScore, 1, 1);
            tableLayoutPanel1.Controls.Add(ThirdHandicapScore, 1, 2);
            tableLayoutPanel1.Location = new Point(447, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(341, 125);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // FirstPlayerHS
            // 
            FirstPlayerHS.AutoSize = true;
            FirstPlayerHS.Location = new Point(3, 0);
            FirstPlayerHS.Name = "FirstPlayerHS";
            FirstPlayerHS.Size = new Size(72, 20);
            FirstPlayerHS.TabIndex = 0;
            FirstPlayerHS.Text = "1st Player";
            FirstPlayerHS.Visible = false;
            // 
            // SecondPlayerHS
            // 
            SecondPlayerHS.AutoSize = true;
            SecondPlayerHS.Location = new Point(3, 41);
            SecondPlayerHS.Name = "SecondPlayerHS";
            SecondPlayerHS.Size = new Size(78, 20);
            SecondPlayerHS.TabIndex = 1;
            SecondPlayerHS.Text = "2nd Player";
            SecondPlayerHS.Visible = false;
            // 
            // ThirdPlayerHS
            // 
            ThirdPlayerHS.AutoSize = true;
            ThirdPlayerHS.Location = new Point(3, 82);
            ThirdPlayerHS.Name = "ThirdPlayerHS";
            ThirdPlayerHS.Size = new Size(75, 20);
            ThirdPlayerHS.TabIndex = 2;
            ThirdPlayerHS.Text = "3rd Player";
            ThirdPlayerHS.Visible = false;
            // 
            // FirstHandicapScore
            // 
            FirstHandicapScore.AutoSize = true;
            FirstHandicapScore.Location = new Point(173, 0);
            FirstHandicapScore.Name = "FirstHandicapScore";
            FirstHandicapScore.Size = new Size(137, 20);
            FirstHandicapScore.TabIndex = 3;
            FirstHandicapScore.Text = "FirstHandicapScore";
            FirstHandicapScore.Visible = false;
            // 
            // SecondHandicapScore
            // 
            SecondHandicapScore.AutoSize = true;
            SecondHandicapScore.Location = new Point(173, 41);
            SecondHandicapScore.Name = "SecondHandicapScore";
            SecondHandicapScore.Size = new Size(159, 20);
            SecondHandicapScore.TabIndex = 4;
            SecondHandicapScore.Text = "SecondHandicapScore";
            SecondHandicapScore.Visible = false;
            // 
            // ThirdHandicapScore
            // 
            ThirdHandicapScore.AutoSize = true;
            ThirdHandicapScore.Location = new Point(173, 82);
            ThirdHandicapScore.Name = "ThirdHandicapScore";
            ThirdHandicapScore.Size = new Size(144, 20);
            ThirdHandicapScore.TabIndex = 5;
            ThirdHandicapScore.Text = "ThirdHandicapScore";
            ThirdHandicapScore.Visible = false;
            // 
            // HighestScratchGames
            // 
            HighestScratchGames.AutoSize = true;
            HighestScratchGames.Location = new Point(143, 16);
            HighestScratchGames.Name = "HighestScratchGames";
            HighestScratchGames.Size = new Size(103, 20);
            HighestScratchGames.TabIndex = 5;
            HighestScratchGames.Text = "Scratch Game:";
            HighestScratchGames.Visible = false;
            // 
            // HighestHandicapGames
            // 
            HighestHandicapGames.AutoSize = true;
            HighestHandicapGames.Location = new Point(556, 16);
            HighestHandicapGames.Name = "HighestHandicapGames";
            HighestHandicapGames.Size = new Size(119, 20);
            HighestHandicapGames.TabIndex = 6;
            HighestHandicapGames.Text = "Handicap Game:";
            HighestHandicapGames.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(FirstPlayerSSeries, 0, 0);
            tableLayoutPanel2.Controls.Add(SecondPlayerSSeries, 0, 1);
            tableLayoutPanel2.Controls.Add(ThirdPlayerSSeries, 0, 2);
            tableLayoutPanel2.Controls.Add(FirstScratchSeries, 1, 0);
            tableLayoutPanel2.Controls.Add(SecondScratchSeries, 1, 1);
            tableLayoutPanel2.Controls.Add(ThirdScratchSeries, 1, 2);
            tableLayoutPanel2.Location = new Point(15, 282);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(369, 125);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // FirstPlayerSSeries
            // 
            FirstPlayerSSeries.AutoSize = true;
            FirstPlayerSSeries.Location = new Point(3, 0);
            FirstPlayerSSeries.Name = "FirstPlayerSSeries";
            FirstPlayerSSeries.Size = new Size(72, 20);
            FirstPlayerSSeries.TabIndex = 0;
            FirstPlayerSSeries.Text = "1st Player";
            FirstPlayerSSeries.Visible = false;
            // 
            // SecondPlayerSSeries
            // 
            SecondPlayerSSeries.AutoSize = true;
            SecondPlayerSSeries.Location = new Point(3, 41);
            SecondPlayerSSeries.Name = "SecondPlayerSSeries";
            SecondPlayerSSeries.Size = new Size(78, 20);
            SecondPlayerSSeries.TabIndex = 1;
            SecondPlayerSSeries.Text = "2nd Player";
            SecondPlayerSSeries.Visible = false;
            // 
            // ThirdPlayerSSeries
            // 
            ThirdPlayerSSeries.AutoSize = true;
            ThirdPlayerSSeries.Location = new Point(3, 82);
            ThirdPlayerSSeries.Name = "ThirdPlayerSSeries";
            ThirdPlayerSSeries.Size = new Size(75, 20);
            ThirdPlayerSSeries.TabIndex = 2;
            ThirdPlayerSSeries.Text = "3rd Player";
            ThirdPlayerSSeries.Visible = false;
            // 
            // FirstScratchSeries
            // 
            FirstScratchSeries.AutoSize = true;
            FirstScratchSeries.Location = new Point(187, 0);
            FirstScratchSeries.Name = "FirstScratchSeries";
            FirstScratchSeries.Size = new Size(123, 20);
            FirstScratchSeries.TabIndex = 3;
            FirstScratchSeries.Text = "FirstScratchSeries";
            FirstScratchSeries.Visible = false;
            // 
            // SecondScratchSeries
            // 
            SecondScratchSeries.AutoSize = true;
            SecondScratchSeries.Location = new Point(187, 41);
            SecondScratchSeries.Name = "SecondScratchSeries";
            SecondScratchSeries.Size = new Size(145, 20);
            SecondScratchSeries.TabIndex = 4;
            SecondScratchSeries.Text = "SecondScratchSeries";
            SecondScratchSeries.Visible = false;
            // 
            // ThirdScratchSeries
            // 
            ThirdScratchSeries.AutoSize = true;
            ThirdScratchSeries.Location = new Point(187, 82);
            ThirdScratchSeries.Name = "ThirdScratchSeries";
            ThirdScratchSeries.Size = new Size(130, 20);
            ThirdScratchSeries.TabIndex = 5;
            ThirdScratchSeries.Text = "ThirdScratchSeries";
            ThirdScratchSeries.Visible = false;
            // 
            // ScratchSeriesLabel
            // 
            ScratchSeriesLabel.AutoSize = true;
            ScratchSeriesLabel.Location = new Point(143, 245);
            ScratchSeriesLabel.Name = "ScratchSeriesLabel";
            ScratchSeriesLabel.Size = new Size(103, 20);
            ScratchSeriesLabel.TabIndex = 8;
            ScratchSeriesLabel.Text = "Scratch Series:";
            ScratchSeriesLabel.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(ThirdPlayerHSeries, 0, 2);
            tableLayoutPanel3.Controls.Add(SecondPlayerHSeries, 0, 1);
            tableLayoutPanel3.Controls.Add(FirstPlayerHSeries, 0, 0);
            tableLayoutPanel3.Controls.Add(ThirdHandicapSeries, 1, 2);
            tableLayoutPanel3.Controls.Add(SecondHandicapSeries, 1, 1);
            tableLayoutPanel3.Controls.Add(FirstHandicapSeries, 1, 0);
            tableLayoutPanel3.Location = new Point(447, 282);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(341, 125);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // ThirdPlayerHSeries
            // 
            ThirdPlayerHSeries.AutoSize = true;
            ThirdPlayerHSeries.Location = new Point(3, 82);
            ThirdPlayerHSeries.Name = "ThirdPlayerHSeries";
            ThirdPlayerHSeries.Size = new Size(75, 20);
            ThirdPlayerHSeries.TabIndex = 11;
            ThirdPlayerHSeries.Text = "3rd Player";
            ThirdPlayerHSeries.Visible = false;
            // 
            // SecondPlayerHSeries
            // 
            SecondPlayerHSeries.AutoSize = true;
            SecondPlayerHSeries.Location = new Point(3, 41);
            SecondPlayerHSeries.Name = "SecondPlayerHSeries";
            SecondPlayerHSeries.Size = new Size(78, 20);
            SecondPlayerHSeries.TabIndex = 12;
            SecondPlayerHSeries.Text = "2nd Player";
            SecondPlayerHSeries.Visible = false;
            // 
            // FirstPlayerHSeries
            // 
            FirstPlayerHSeries.AutoSize = true;
            FirstPlayerHSeries.Location = new Point(3, 0);
            FirstPlayerHSeries.Name = "FirstPlayerHSeries";
            FirstPlayerHSeries.Size = new Size(72, 20);
            FirstPlayerHSeries.TabIndex = 13;
            FirstPlayerHSeries.Text = "1st Player";
            FirstPlayerHSeries.Visible = false;
            // 
            // ThirdHandicapSeries
            // 
            ThirdHandicapSeries.AutoSize = true;
            ThirdHandicapSeries.Location = new Point(173, 82);
            ThirdHandicapSeries.Name = "ThirdHandicapSeries";
            ThirdHandicapSeries.Size = new Size(146, 20);
            ThirdHandicapSeries.TabIndex = 14;
            ThirdHandicapSeries.Text = "ThirdHandicapSeries";
            ThirdHandicapSeries.Visible = false;
            // 
            // SecondHandicapSeries
            // 
            SecondHandicapSeries.AutoSize = true;
            SecondHandicapSeries.Location = new Point(173, 41);
            SecondHandicapSeries.Name = "SecondHandicapSeries";
            SecondHandicapSeries.Size = new Size(161, 20);
            SecondHandicapSeries.TabIndex = 15;
            SecondHandicapSeries.Text = "SecondHandicapSeries";
            SecondHandicapSeries.Visible = false;
            // 
            // FirstHandicapSeries
            // 
            FirstHandicapSeries.AutoSize = true;
            FirstHandicapSeries.Location = new Point(173, 0);
            FirstHandicapSeries.Name = "FirstHandicapSeries";
            FirstHandicapSeries.Size = new Size(139, 20);
            FirstHandicapSeries.TabIndex = 16;
            FirstHandicapSeries.Text = "FirstHandicapSeries";
            FirstHandicapSeries.Visible = false;
            // 
            // HandicapSeriesLabel
            // 
            HandicapSeriesLabel.AutoSize = true;
            HandicapSeriesLabel.Location = new Point(556, 245);
            HandicapSeriesLabel.Name = "HandicapSeriesLabel";
            HandicapSeriesLabel.Size = new Size(119, 20);
            HandicapSeriesLabel.TabIndex = 10;
            HandicapSeriesLabel.Text = "Handicap Series:";
            HandicapSeriesLabel.Visible = false;
            // 
            // WeeklyHighScores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HandicapSeriesLabel);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(ScratchSeriesLabel);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(HighestHandicapGames);
            Controls.Add(HighestScratchGames);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(BackButton);
            Controls.Add(WeeksComboBox);
            Controls.Add(WeekLabel);
            Controls.Add(ScratchSeriesTableLayout);
            Name = "WeeklyHighScores";
            Text = "WeeklyHighScores";
            Load += WeeklyHighScores_Load;
            ScratchSeriesTableLayout.ResumeLayout(false);
            ScratchSeriesTableLayout.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel ScratchSeriesTableLayout;
        private Label FirstPlayerSS;
        private Label SecondPlayerSS;
        private Label ThirdPlayerSS;
        private Label FirstScratchScore;
        private Label SecondScratchScore;
        private Label ThirdScratchScore;
        private Label WeekLabel;
        private ComboBox WeeksComboBox;
        private Button BackButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label FirstPlayerHS;
        private Label SecondPlayerHS;
        private Label ThirdPlayerHS;
        private Label FirstHandicapScore;
        private Label SecondHandicapScore;
        private Label ThirdHandicapScore;
        private Label HighestScratchGames;
        private Label HighestHandicapGames;
        private TableLayoutPanel tableLayoutPanel2;
        private Label FirstPlayerSSeries;
        private Label SecondPlayerSSeries;
        private Label ThirdPlayerSSeries;
        private Label FirstScratchSeries;
        private Label SecondScratchSeries;
        private Label ThirdScratchSeries;
        private Label ScratchSeriesLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label ThirdPlayerHSeries;
        private Label SecondPlayerHSeries;
        private Label FirstPlayerHSeries;
        private Label ThirdHandicapSeries;
        private Label SecondHandicapSeries;
        private Label FirstHandicapSeries;
        private Label HandicapSeriesLabel;
    }
}