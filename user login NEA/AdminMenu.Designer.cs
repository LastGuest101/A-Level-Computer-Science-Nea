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
            SuspendLayout();
            // 
            // AddPlayersButton
            // 
            AddPlayersButton.Location = new Point(121, 105);
            AddPlayersButton.Name = "AddPlayersButton";
            AddPlayersButton.Size = new Size(252, 29);
            AddPlayersButton.TabIndex = 0;
            AddPlayersButton.Text = "Add Players";
            AddPlayersButton.UseVisualStyleBackColor = true;
            AddPlayersButton.Click += AddPlayersButton_Click;
            // 
            // EditScoresButton
            // 
            EditScoresButton.Location = new Point(121, 180);
            EditScoresButton.Name = "EditScoresButton";
            EditScoresButton.Size = new Size(252, 32);
            EditScoresButton.TabIndex = 1;
            EditScoresButton.Text = "Edit Scores";
            EditScoresButton.UseVisualStyleBackColor = true;
            EditScoresButton.Click += EditScoresButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}