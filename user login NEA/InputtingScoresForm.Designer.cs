namespace user_login_NEA
{
    partial class InputtingScoresForm
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
            SelectPlayersTeam1.Size = new Size(150, 104);
            SelectPlayersTeam1.TabIndex = 2;
            SelectPlayersTeam1.SelectedIndexChanged += SelectPlayersTeam1_SelectedIndexChanged;
            // 
            // SelectPlayersTeam2
            // 
            SelectPlayersTeam2.FormattingEnabled = true;
            SelectPlayersTeam2.ItemHeight = 20;
            SelectPlayersTeam2.Location = new Point(506, 157);
            SelectPlayersTeam2.Name = "SelectPlayersTeam2";
            SelectPlayersTeam2.Size = new Size(150, 104);
            SelectPlayersTeam2.TabIndex = 3;
            // 
            // InputtingScoresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SelectPlayersTeam2);
            Controls.Add(SelectPlayersTeam1);
            Controls.Add(Team2);
            Controls.Add(Team1);
            Name = "InputtingScoresForm";
            Text = "InputtingScoresForm";
            Load += InputtingScoresForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Team1;
        private Label Team2;
        private ListBox SelectPlayersTeam1;
        private ListBox listBox1;
        private ListBox SelectPlayersTeam2;
    }
}