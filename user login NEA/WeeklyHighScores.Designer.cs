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
            ScratchSeriesTableLayout.SuspendLayout();
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
            // WeeklyHighScores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackButton);
            Controls.Add(WeeksComboBox);
            Controls.Add(WeekLabel);
            Controls.Add(ScratchSeriesTableLayout);
            Name = "WeeklyHighScores";
            Text = "WeeklyHighScores";
            Load += WeeklyHighScores_Load;
            ScratchSeriesTableLayout.ResumeLayout(false);
            ScratchSeriesTableLayout.PerformLayout();
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
    }
}