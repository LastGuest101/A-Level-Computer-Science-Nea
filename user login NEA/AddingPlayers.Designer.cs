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
            this.LeagueLabel = new System.Windows.Forms.Label();
            this.LeagueComboBox = new System.Windows.Forms.ComboBox();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.TeamComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeagueLabel
            // 
            this.LeagueLabel.AutoSize = true;
            this.LeagueLabel.Location = new System.Drawing.Point(112, 16);
            this.LeagueLabel.Name = "LeagueLabel";
            this.LeagueLabel.Size = new System.Drawing.Size(45, 15);
            this.LeagueLabel.TabIndex = 12;
            this.LeagueLabel.Text = "League";
            // 
            // LeagueComboBox
            // 
            this.LeagueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeagueComboBox.FormattingEnabled = true;
            this.LeagueComboBox.Location = new System.Drawing.Point(74, 48);
            this.LeagueComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeagueComboBox.Name = "LeagueComboBox";
            this.LeagueComboBox.Size = new System.Drawing.Size(133, 23);
            this.LeagueComboBox.TabIndex = 13;
            this.LeagueComboBox.SelectedIndexChanged += new System.EventHandler(this.LeagueComboBox_SelectedIndexChanged_1);
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Location = new System.Drawing.Point(408, 16);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(35, 15);
            this.TeamLabel.TabIndex = 14;
            this.TeamLabel.Text = "Team";
            // 
            // TeamComboBox
            // 
            this.TeamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamComboBox.FormattingEnabled = true;
            this.TeamComboBox.Location = new System.Drawing.Point(368, 48);
            this.TeamComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeamComboBox.Name = "TeamComboBox";
            this.TeamComboBox.Size = new System.Drawing.Size(133, 23);
            this.TeamComboBox.TabIndex = 15;
            this.TeamComboBox.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged_1);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(112, 99);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(59, 15);
            this.FirstNameLabel.TabIndex = 16;
            this.FirstNameLabel.Text = "Firstname";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(113, 136);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 15);
            this.LastNameLabel.TabIndex = 17;
            this.LastNameLabel.Text = "Lastname";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(205, 99);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(110, 23);
            this.FirstNameTextBox.TabIndex = 18;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(205, 136);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(110, 23);
            this.LastNameTextBox.TabIndex = 19;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(388, 120);
            this.AddPlayerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(82, 22);
            this.AddPlayerButton.TabIndex = 20;
            this.AddPlayerButton.Text = "Add Player";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click_1);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(10, 9);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(82, 22);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // AddingPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.TeamComboBox);
            this.Controls.Add(this.TeamLabel);
            this.Controls.Add(this.LeagueComboBox);
            this.Controls.Add(this.LeagueLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddingPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddingPlayers";
            this.Load += new System.EventHandler(this.AddingPlayers_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button backButton;
    }
}