namespace user_login_NEA
{
    partial class AddingPlayers
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
            LeagueLabel = new Label();
            LeagueComboBox = new ComboBox();
            TeamLabel = new Label();
            TeamComboBox = new ComboBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            AddPlayerButton = new Button();
            SuspendLayout();
            // 
            // LeagueLabel
            // 
            LeagueLabel.AutoSize = true;
            LeagueLabel.Location = new Point(128, 22);
            LeagueLabel.Name = "LeagueLabel";
            LeagueLabel.Size = new Size(57, 20);
            LeagueLabel.TabIndex = 12;
            LeagueLabel.Text = "League";
            // 
            // LeagueComboBox
            // 
            LeagueComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LeagueComboBox.FormattingEnabled = true;
            LeagueComboBox.Location = new Point(84, 64);
            LeagueComboBox.Name = "LeagueComboBox";
            LeagueComboBox.Size = new Size(151, 28);
            LeagueComboBox.TabIndex = 13;
            LeagueComboBox.SelectedIndexChanged += LeagueComboBox_SelectedIndexChanged;
            // 
            // TeamLabel
            // 
            TeamLabel.AutoSize = true;
            TeamLabel.Location = new Point(466, 22);
            TeamLabel.Name = "TeamLabel";
            TeamLabel.Size = new Size(45, 20);
            TeamLabel.TabIndex = 14;
            TeamLabel.Text = "Team";
            // 
            // TeamComboBox
            // 
            TeamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TeamComboBox.FormattingEnabled = true;
            TeamComboBox.Location = new Point(420, 64);
            TeamComboBox.Name = "TeamComboBox";
            TeamComboBox.Size = new Size(151, 28);
            TeamComboBox.TabIndex = 15;
            TeamComboBox.SelectedIndexChanged += TeamComboBox_SelectedIndexChanged;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(128, 132);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(73, 20);
            FirstNameLabel.TabIndex = 16;
            FirstNameLabel.Text = "Firstname";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(129, 181);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(72, 20);
            LastNameLabel.TabIndex = 17;
            LastNameLabel.Text = "Lastname";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(234, 132);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(125, 27);
            FirstNameTextBox.TabIndex = 18;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(234, 181);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(125, 27);
            LastNameTextBox.TabIndex = 19;
            // 
            // AddPlayerButton
            // 
            AddPlayerButton.Location = new Point(444, 160);
            AddPlayerButton.Name = "AddPlayerButton";
            AddPlayerButton.Size = new Size(94, 29);
            AddPlayerButton.TabIndex = 20;
            AddPlayerButton.Text = "Add Player";
            AddPlayerButton.UseVisualStyleBackColor = true;
            AddPlayerButton.Click += AddPlayerButton_Click;
            // 
            // AddingPlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddPlayerButton);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(TeamComboBox);
            Controls.Add(TeamLabel);
            Controls.Add(LeagueComboBox);
            Controls.Add(LeagueLabel);
            Name = "AddingPlayers";
            Text = "AddingPlayers";
            Load += AddingPlayers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LeagueLabel;
        private ComboBox LeagueComboBox;
        private Label TeamLabel;
        private ComboBox TeamComboBox;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private Button AddPlayerButton;
    }
}