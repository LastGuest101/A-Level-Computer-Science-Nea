namespace user_login_NEA
{
    partial class AdminMenu
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
            AddPlayersButton = new Button();
            EditScoresButton = new Button();
            BackButton = new Button();
            RemoveButton = new Button();
            TeamAddButton = new Button();
            AddExistingPlayersButton = new Button();
            SuspendLayout();
            // 
            // AddPlayersButton
            // 
            AddPlayersButton.Location = new Point(121, 105);
            AddPlayersButton.Name = "AddPlayersButton";
            AddPlayersButton.Size = new Size(251, 29);
            AddPlayersButton.TabIndex = 0;
            AddPlayersButton.Text = "Add Players";
            AddPlayersButton.UseVisualStyleBackColor = true;
            AddPlayersButton.Click += AddPlayersButton_Click;
            // 
            // EditScoresButton
            // 
            EditScoresButton.Location = new Point(121, 180);
            EditScoresButton.Name = "EditScoresButton";
            EditScoresButton.Size = new Size(251, 32);
            EditScoresButton.TabIndex = 1;
            EditScoresButton.Text = "Edit Scores";
            EditScoresButton.UseVisualStyleBackColor = true;
            EditScoresButton.Click += EditScoresButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(11, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackgroundImageLayout = ImageLayout.Center;
            RemoveButton.Location = new Point(491, 105);
            RemoveButton.Margin = new Padding(3, 4, 3, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(218, 29);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove Players";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // TeamAddButton
            // 
            TeamAddButton.Location = new Point(491, 180);
            TeamAddButton.Margin = new Padding(3, 4, 3, 4);
            TeamAddButton.Name = "TeamAddButton";
            TeamAddButton.Size = new Size(218, 32);
            TeamAddButton.TabIndex = 4;
            TeamAddButton.Text = "Add Team";
            TeamAddButton.UseVisualStyleBackColor = true;
            TeamAddButton.Click += TeamAddButton_Click;
            // 
            // AddExistingPlayersButton
            // 
            AddExistingPlayersButton.Location = new Point(318, 256);
            AddExistingPlayersButton.Name = "AddExistingPlayersButton";
            AddExistingPlayersButton.Size = new Size(218, 35);
            AddExistingPlayersButton.TabIndex = 5;
            AddExistingPlayersButton.Text = "Add Existing Players";
            AddExistingPlayersButton.UseVisualStyleBackColor = true;
            AddExistingPlayersButton.Click += AddExistingPlayersButton_Click;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(AddExistingPlayersButton);
            Controls.Add(TeamAddButton);
            Controls.Add(RemoveButton);
            Controls.Add(BackButton);
            Controls.Add(EditScoresButton);
            Controls.Add(AddPlayersButton);
            Name = "AdminMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button AddPlayersButton;
        private Button EditScoresButton;
        private Button BackButton;
        private Button RemoveButton;
        private Button TeamAddButton;
        private Button AddExistingPlayersButton;
    }
}