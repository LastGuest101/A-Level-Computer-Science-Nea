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
            this.AddPlayersButton = new System.Windows.Forms.Button();
            this.EditScoresButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.TeamAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPlayersButton
            // 
            this.AddPlayersButton.Location = new System.Drawing.Point(106, 79);
            this.AddPlayersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddPlayersButton.Name = "AddPlayersButton";
            this.AddPlayersButton.Size = new System.Drawing.Size(220, 22);
            this.AddPlayersButton.TabIndex = 0;
            this.AddPlayersButton.Text = "Add Players";
            this.AddPlayersButton.UseVisualStyleBackColor = true;
            this.AddPlayersButton.Click += new System.EventHandler(this.AddPlayersButton_Click);
            // 
            // EditScoresButton
            // 
            this.EditScoresButton.Location = new System.Drawing.Point(106, 135);
            this.EditScoresButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditScoresButton.Name = "EditScoresButton";
            this.EditScoresButton.Size = new System.Drawing.Size(220, 24);
            this.EditScoresButton.TabIndex = 1;
            this.EditScoresButton.Text = "Edit Scores";
            this.EditScoresButton.UseVisualStyleBackColor = true;
            this.EditScoresButton.Click += new System.EventHandler(this.EditScoresButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(10, 9);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(82, 22);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoveButton.Location = new System.Drawing.Point(430, 79);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(191, 22);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove Players";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TeamAddButton
            // 
            this.TeamAddButton.Location = new System.Drawing.Point(430, 135);
            this.TeamAddButton.Name = "TeamAddButton";
            this.TeamAddButton.Size = new System.Drawing.Size(191, 24);
            this.TeamAddButton.TabIndex = 4;
            this.TeamAddButton.Text = "Add Team";
            this.TeamAddButton.UseVisualStyleBackColor = true;
            this.TeamAddButton.Click += new System.EventHandler(this.TeamAddButton_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.TeamAddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditScoresButton);
            this.Controls.Add(this.AddPlayersButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddPlayersButton;
        private Button EditScoresButton;
        private Button BackButton;
        private Button RemoveButton;
        private Button TeamAddButton;
    }
}