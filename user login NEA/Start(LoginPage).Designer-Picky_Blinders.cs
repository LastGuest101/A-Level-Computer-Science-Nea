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
            showPasswordCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(315, 84);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(134, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Welcome";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(173, 245);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(173, 183);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "UserName";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = SystemColors.Window;
            usernameTextBox.Location = new Point(282, 179);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(279, 27);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(282, 241);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(279, 27);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(477, 305);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(86, 31);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(161, 399);
            exitButton.Margin = new Padding(3, 4, 3, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(86, 31);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button1_Click_1;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(282, 305);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(86, 31);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += button2_Click_1;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(406, 389);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(132, 24);
            showPasswordCheckBox.TabIndex = 8;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 495);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(clearButton);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(passwordLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Login";
            
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
        private CheckBox showPasswordCheckBox;
    }
}
