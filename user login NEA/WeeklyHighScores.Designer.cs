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
            ScratchSeriesTableLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            ScratchSeriesTableLayout.Location = new Point(12, 60);
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
            WeekLabel.Location = new Point(393, 9);
            WeekLabel.Name = "WeekLabel";
            WeekLabel.Size = new Size(48, 20);
            WeekLabel.TabIndex = 1;
            WeekLabel.Text = "Week:";
            // 
            // WeeksComboBox
            // 
            WeeksComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WeeksComboBox.FormattingEnabled = true;
            WeeksComboBox.Location = new Point(393, 32);
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
            HighestScratchGames.Location = new Point(127, 30);
            HighestScratchGames.Name = "HighestScratchGames";
            HighestScratchGames.Size = new Size(103, 20);
            HighestScratchGames.TabIndex = 5;
            HighestScratchGames.Text = "Scratch Game:";
            HighestScratchGames.Visible = false;
            // 
            // HighestHandicapGames
            // 
            HighestHandicapGames.AutoSize = true;
            HighestHandicapGames.Location = new Point(533, 30);
            HighestHandicapGames.Name = "HighestHandicapGames";
            HighestHandicapGames.Size = new Size(119, 20);
            HighestHandicapGames.TabIndex = 6;
            HighestHandicapGames.Text = "Handicap Game:";
            HighestHandicapGames.Visible = false;
            // 
            // WeeklyHighScores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}