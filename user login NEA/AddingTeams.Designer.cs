namespace user_login_NEA
{
    partial class AddingTeams
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
            this.backButton = new System.Windows.Forms.Button();
            this.TeamAddButton = new System.Windows.Forms.Button();
            this.TeamTextBox = new System.Windows.Forms.TextBox();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.LeagueComboBox = new System.Windows.Forms.ComboBox();
            this.LeagueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(82, 22);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // TeamAddButton
            // 
            this.TeamAddButton.Location = new System.Drawing.Point(511, 169);
            this.TeamAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeamAddButton.Name = "TeamAddButton";
            this.TeamAddButton.Size = new System.Drawing.Size(82, 22);
            this.TeamAddButton.TabIndex = 30;
            this.TeamAddButton.Text = "Add Team";
            this.TeamAddButton.UseVisualStyleBackColor = true;
            this.TeamAddButton.Click += new System.EventHandler(this.TeamAddButton_Click);
            // 
            // TeamTextBox
            // 
            this.TeamTextBox.Location = new System.Drawing.Point(324, 166);
            this.TeamTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeamTextBox.Name = "TeamTextBox";
            this.TeamTextBox.Size = new System.Drawing.Size(110, 23);
            this.TeamTextBox.TabIndex = 28;
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Location = new System.Drawing.Point(214, 169);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(35, 15);
            this.TeamLabel.TabIndex = 26;
            this.TeamLabel.Text = "Team";
            // 
            // LeagueComboBox
            // 
            this.LeagueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeagueComboBox.FormattingEnabled = true;
            this.LeagueComboBox.Location = new System.Drawing.Point(312, 50);
            this.LeagueComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeagueComboBox.Name = "LeagueComboBox";
            this.LeagueComboBox.Size = new System.Drawing.Size(133, 23);
            this.LeagueComboBox.TabIndex = 23;
            this.LeagueComboBox.SelectedIndexChanged += new System.EventHandler(this.LeagueComboBox_SelectedIndexChanged);
            // 
            // LeagueLabel
            // 
            this.LeagueLabel.AutoSize = true;
            this.LeagueLabel.Location = new System.Drawing.Point(350, 18);
            this.LeagueLabel.Name = "LeagueLabel";
            this.LeagueLabel.Size = new System.Drawing.Size(45, 15);
            this.LeagueLabel.TabIndex = 22;
            this.LeagueLabel.Text = "League";
            // 
            // AddingTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.TeamAddButton);
            this.Controls.Add(this.TeamTextBox);
            this.Controls.Add(this.TeamLabel);
            this.Controls.Add(this.LeagueComboBox);
            this.Controls.Add(this.LeagueLabel);
            this.Name = "AddingTeams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddingTeams";
            this.Load += new System.EventHandler(this.AddingTeams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton;
        private Button TeamAddButton;
        private TextBox TeamTextBox;
        private Label TeamLabel;
        private ComboBox LeagueComboBox;
        private Label LeagueLabel;
    }
}