namespace user_login_NEA
{
    partial class SignUp
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
            LoginInButton = new Button();
            SignUpLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextbox = new TextBox();
            EmailTextbox = new TextBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            EmailLabel = new Label();
            LeagueLabel = new Label();
            LeagueComboBox = new ComboBox();
            BowlerLabel = new Label();
            BowlerComboBox = new ComboBox();
            SignUpButton = new Button();
            ValidatorLabel = new Button();
            SuspendLayout();
            // 
            // LoginInButton
            // 
            LoginInButton.Location = new Point(12, 12);
            LoginInButton.Name = "LoginInButton";
            LoginInButton.Size = new Size(94, 29);
            LoginInButton.TabIndex = 3;
            LoginInButton.Text = "Login In";
            LoginInButton.UseVisualStyleBackColor = true;
            LoginInButton.Click += LoginInButton_Click;
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Location = new Point(181, 71);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(61, 20);
            SignUpLabel.TabIndex = 4;
            SignUpLabel.Text = "Sign Up";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(181, 116);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(125, 27);
            UsernameTextBox.TabIndex = 5;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(181, 184);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(125, 27);
            PasswordTextbox.TabIndex = 6;
            // 
            // EmailTextbox
            // 
            EmailTextbox.Location = new Point(181, 259);
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(125, 27);
            EmailTextbox.TabIndex = 7;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(100, 123);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(75, 20);
            UsernameLabel.TabIndex = 8;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(100, 191);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 9;
            PasswordLabel.Text = "Password";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(100, 266);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(46, 20);
            EmailLabel.TabIndex = 10;
            EmailLabel.Text = "Email";
            // 
            // LeagueLabel
            // 
            LeagueLabel.AutoSize = true;
            LeagueLabel.Location = new Point(554, 71);
            LeagueLabel.Name = "LeagueLabel";
            LeagueLabel.Size = new Size(57, 20);
            LeagueLabel.TabIndex = 11;
            LeagueLabel.Text = "League";
            // 
            // LeagueComboBox
            // 
            LeagueComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LeagueComboBox.FormattingEnabled = true;
            LeagueComboBox.Location = new Point(510, 94);
            LeagueComboBox.Name = "LeagueComboBox";
            LeagueComboBox.Size = new Size(151, 28);
            LeagueComboBox.TabIndex = 12;
            LeagueComboBox.SelectedIndexChanged += LeagueComboBox_SelectedIndexChanged;
            // 
            // BowlerLabel
            // 
            BowlerLabel.AutoSize = true;
            BowlerLabel.Location = new Point(556, 191);
            BowlerLabel.Name = "BowlerLabel";
            BowlerLabel.Size = new Size(55, 20);
            BowlerLabel.TabIndex = 13;
            BowlerLabel.Text = "Bowler";
            // 
            // BowlerComboBox
            // 
            BowlerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BowlerComboBox.FormattingEnabled = true;
            BowlerComboBox.Location = new Point(510, 214);
            BowlerComboBox.Name = "BowlerComboBox";
            BowlerComboBox.Size = new Size(151, 28);
            BowlerComboBox.TabIndex = 14;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(372, 331);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(94, 29);
            SignUpButton.TabIndex = 15;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // ValidatorLabel
            // 
            ValidatorLabel.Location = new Point(372, 266);
            ValidatorLabel.Name = "ValidatorLabel";
            ValidatorLabel.Size = new Size(94, 29);
            ValidatorLabel.TabIndex = 16;
            ValidatorLabel.Text = "button1";
            ValidatorLabel.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ValidatorLabel);
            Controls.Add(SignUpButton);
            Controls.Add(BowlerComboBox);
            Controls.Add(BowlerLabel);
            Controls.Add(LeagueComboBox);
            Controls.Add(LeagueLabel);
            Controls.Add(EmailLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(EmailTextbox);
            Controls.Add(PasswordTextbox);
            Controls.Add(UsernameTextBox);
            Controls.Add(SignUpLabel);
            Controls.Add(LoginInButton);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginInButton;
        private Label SignUpLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextbox;
        private TextBox EmailTextbox;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label EmailLabel;
        private Label LeagueLabel;
        private ComboBox LeagueComboBox;
        private Label BowlerLabel;
        private ComboBox BowlerComboBox;
        private Button SignUpButton;
        private Button ValidatorLabel;
    }
}