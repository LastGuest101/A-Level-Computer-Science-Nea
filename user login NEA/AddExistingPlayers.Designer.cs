namespace user_login_NEA
{
    partial class AddExistingPlayers
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
            TeamComboBox = new ComboBox();
            LeagueComboBox = new ComboBox();
            PlayerComboBox = new ComboBox();
            LeagueLabel = new Label();
            TeamLabel = new Label();
            PlayerLabel = new Label();
            BackButton = new Button();
            AddButton = new Button();
            SuspendLayout();
            // 
            // TeamComboBox
            // 
            TeamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TeamComboBox.FormattingEnabled = true;
            TeamComboBox.Location = new Point(344, 126);
            TeamComboBox.Name = "TeamComboBox";
            TeamComboBox.Size = new Size(151, 28);
            TeamComboBox.TabIndex = 0;
            TeamComboBox.SelectedIndexChanged += TeamComboBox_SelectedIndexChanged;
            // 
            // LeagueComboBox
            // 
            LeagueComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LeagueComboBox.FormattingEnabled = true;
            LeagueComboBox.Location = new Point(111, 126);
            LeagueComboBox.Name = "LeagueComboBox";
            LeagueComboBox.Size = new Size(151, 28);
            LeagueComboBox.TabIndex = 1;
            LeagueComboBox.SelectedIndexChanged += LeagueComboBox_SelectedIndexChanged;
            // 
            // PlayerComboBox
            // 
            PlayerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PlayerComboBox.FormattingEnabled = true;
            PlayerComboBox.Location = new Point(581, 126);
            PlayerComboBox.Name = "PlayerComboBox";
            PlayerComboBox.Size = new Size(151, 28);
            PlayerComboBox.TabIndex = 2;
            PlayerComboBox.SelectedIndexChanged += PlayerComboBox_SelectedIndexChanged;
            // 
            // LeagueLabel
            // 
            LeagueLabel.AutoSize = true;
            LeagueLabel.Location = new Point(153, 71);
            LeagueLabel.Name = "LeagueLabel";
            LeagueLabel.Size = new Size(60, 20);
            LeagueLabel.TabIndex = 3;
            LeagueLabel.Text = "League:";
            // 
            // TeamLabel
            // 
            TeamLabel.AutoSize = true;
            TeamLabel.Location = new Point(397, 71);
            TeamLabel.Name = "TeamLabel";
            TeamLabel.Size = new Size(48, 20);
            TeamLabel.TabIndex = 4;
            TeamLabel.Text = "Team:";
            // 
            // PlayerLabel
            // 
            PlayerLabel.AutoSize = true;
            PlayerLabel.Location = new Point(623, 71);
            PlayerLabel.Name = "PlayerLabel";
            PlayerLabel.Size = new Size(52, 20);
            PlayerLabel.TabIndex = 5;
            PlayerLabel.Text = "Player:";
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
            // AddButton
            // 
            AddButton.Location = new Point(375, 237);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 7;
            AddButton.Text = "Add Player";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Visible = false;
            AddButton.Click += AddButton_Click;
            // 
            // AddExistingPlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddButton);
            Controls.Add(BackButton);
            Controls.Add(PlayerLabel);
            Controls.Add(TeamLabel);
            Controls.Add(LeagueLabel);
            Controls.Add(PlayerComboBox);
            Controls.Add(LeagueComboBox);
            Controls.Add(TeamComboBox);
            Name = "AddExistingPlayers";
            Text = "AddExistingPlayers";
            Load += AddExistingPlayers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BackButton;
        private Button button2;
        private ComboBox TeamComboBox;
        private ComboBox LeagueComboBox;
        private Label LeagueLabel;
        private Label TeamLabel;
        private Label PlayerLabel;
        private ComboBox PlayerComboBox;
        private Button AddButton;
    }
}