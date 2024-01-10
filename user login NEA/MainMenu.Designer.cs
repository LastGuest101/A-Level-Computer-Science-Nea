namespace user_login_NEA
{
    partial class MainMenu
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
            PlayerHandicap = new Label();
            label2 = new Label();
            AddButton = new Button();
            PlayerName = new Label();
            SignOut = new Button();
            SuspendLayout();
            // 
            // PlayerHandicap
            // 
            PlayerHandicap.AutoSize = true;
            PlayerHandicap.Location = new Point(403, 33);
            PlayerHandicap.Name = "PlayerHandicap";
            PlayerHandicap.Size = new Size(126, 20);
            PlayerHandicap.TabIndex = 0;
            PlayerHandicap.Text = "Player's Handicap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 212);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(290, 267);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(409, 172);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add (Admin Only)";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.Location = new Point(235, 33);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(129, 20);
            PlayerName.TabIndex = 7;
            PlayerName.Text = "Player's Full Name";
 
            // 
            // SignOut
            // 
            SignOut.Location = new Point(12, 12);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(94, 29);
            SignOut.TabIndex = 8;
            SignOut.Text = "SIGN OUT";
            SignOut.UseVisualStyleBackColor = true;
            SignOut.Click += SignOut_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 667);
            Controls.Add(SignOut);
            Controls.Add(PlayerName);
            Controls.Add(AddButton);
            Controls.Add(label2);
            Controls.Add(PlayerHandicap);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerHandicap;
        private Label label2;
        private Button AddButton;
        private Label PlayerName;
        private Button SignOut;
    }
}