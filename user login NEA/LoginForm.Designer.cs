namespace user_login_NEA
{
    partial class LoginForm
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
            titleLabel = new Label();
            passwordLabel = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            exitButton = new Button();
            clearButton = new Button();
            CheckBoxShowPass = new CheckBox();
            Sign_Up_Button = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(315, 35);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(71, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Welcome";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(246, 171);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(246, 107);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "UserName";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(392, 104);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(125, 27);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(392, 168);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(125, 27);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(518, 231);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(183, 231);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(292, 231);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // CheckBoxShowPass
            // 
            CheckBoxShowPass.AutoSize = true;
            CheckBoxShowPass.Location = new Point(392, 234);
            CheckBoxShowPass.Name = "CheckBoxShowPass";
            CheckBoxShowPass.Size = new Size(132, 24);
            CheckBoxShowPass.TabIndex = 8;
            CheckBoxShowPass.Text = "Show Password";
            CheckBoxShowPass.UseVisualStyleBackColor = true;
            CheckBoxShowPass.CheckedChanged += CheckBoxShowPass_CheckedChanged;
            // 
            // Sign_Up_Button
            // 
            Sign_Up_Button.Location = new Point(406, 284);
            Sign_Up_Button.Name = "Sign_Up_Button";
            Sign_Up_Button.Size = new Size(94, 29);
            Sign_Up_Button.TabIndex = 9;
            Sign_Up_Button.Text = "Sign Up";
            Sign_Up_Button.UseVisualStyleBackColor = true;
            Sign_Up_Button.Click += Sign_Up_Button_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sign_Up_Button);
            Controls.Add(CheckBoxShowPass);
            Controls.Add(clearButton);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(passwordLabel);
            Controls.Add(titleLabel);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button exitButton;
        private Button clearButton;
        private CheckBox CheckBoxShowPass;
        private Button Sign_Up_Button;
    }
}