namespace user_login_NEA
{
    partial class UserMenu
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
            backButton = new Button();
            WeeklyScoresButton = new Button();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // WeeklyScoresButton
            // 
            WeeklyScoresButton.Location = new Point(464, 220);
            WeeklyScoresButton.Name = "WeeklyScoresButton";
            WeeklyScoresButton.Size = new Size(239, 63);
            WeeklyScoresButton.TabIndex = 1;
            WeeklyScoresButton.Text = "Weekly HighScores";
            WeeklyScoresButton.UseVisualStyleBackColor = true;
            WeeklyScoresButton.Click += button1_Click;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WeeklyScoresButton);
            Controls.Add(backButton);
            Name = "UserMenu";
            Text = "UserMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private Button WeeklyScoresButton;
    }
}