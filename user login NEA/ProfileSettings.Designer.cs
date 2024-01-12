namespace user_login_NEA
{
    partial class ProfileSettings
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
            tableLayoutPanel1 = new TableLayoutPanel();
            UserIDLabel = new Label();
            UserID2 = new Label();
            AccountLevelLabel = new Label();
            AccountLevelDisplayLabel = new Label();
            UsernameTextBox = new TextBox();
            UsernameLabel = new Label();
            UsernameButton = new Button();
            UserCombobox = new ComboBox();
            AddAdminButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 0;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(UserIDLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(UserID2, 1, 0);
            tableLayoutPanel1.Controls.Add(AccountLevelLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(AccountLevelDisplayLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(UsernameTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(UsernameLabel, 0, 2);
            tableLayoutPanel1.Location = new Point(141, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(250, 354);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // UserIDLabel
            // 
            UserIDLabel.AutoSize = true;
            UserIDLabel.Location = new Point(3, 0);
            UserIDLabel.Name = "UserIDLabel";
            UserIDLabel.Size = new Size(53, 20);
            UserIDLabel.TabIndex = 0;
            UserIDLabel.Text = "UserID";
            // 
            // UserID2
            // 
            UserID2.AutoSize = true;
            UserID2.Location = new Point(128, 0);
            UserID2.Name = "UserID2";
            UserID2.Size = new Size(106, 20);
            UserID2.TabIndex = 1;
            UserID2.Text = "UserID Display";
            // 
            // AccountLevelLabel
            // 
            AccountLevelLabel.AutoSize = true;
            AccountLevelLabel.Location = new Point(3, 58);
            AccountLevelLabel.Name = "AccountLevelLabel";
            AccountLevelLabel.Size = new Size(104, 20);
            AccountLevelLabel.TabIndex = 2;
            AccountLevelLabel.Text = "Account Level:";
            // 
            // AccountLevelDisplayLabel
            // 
            AccountLevelDisplayLabel.AutoSize = true;
            AccountLevelDisplayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AccountLevelDisplayLabel.Location = new Point(128, 58);
            AccountLevelDisplayLabel.Name = "AccountLevelDisplayLabel";
            AccountLevelDisplayLabel.Size = new Size(97, 20);
            AccountLevelDisplayLabel.TabIndex = 4;
            AccountLevelDisplayLabel.Text = "AccountLevel";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(128, 119);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(119, 27);
            UsernameTextBox.TabIndex = 3;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AccessibleRole = AccessibleRole.None;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(3, 116);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(82, 20);
            UsernameLabel.TabIndex = 2;
            UsernameLabel.Text = "Username :";
            // 
            // UsernameButton
            // 
            UsernameButton.Location = new Point(412, 154);
            UsernameButton.Name = "UsernameButton";
            UsernameButton.Size = new Size(94, 29);
            UsernameButton.TabIndex = 2;
            UsernameButton.Text = "Change";
            UsernameButton.UseVisualStyleBackColor = true;
            UsernameButton.Visible = false;
            UsernameButton.Click += UsernameButton_Click;
            // 
            // UserCombobox
            // 
            UserCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            UserCombobox.FormattingEnabled = true;
            UserCombobox.Location = new Point(511, 35);
            UserCombobox.Name = "UserCombobox";
            UserCombobox.Size = new Size(151, 28);
            UserCombobox.TabIndex = 3;
            UserCombobox.Visible = false;
            UserCombobox.SelectedIndexChanged += UserCombobox_SelectedIndexChanged;
            // 
            // AddAdminButton
            // 
            AddAdminButton.Location = new Point(694, 35);
            AddAdminButton.Name = "AddAdminButton";
            AddAdminButton.Size = new Size(94, 29);
            AddAdminButton.TabIndex = 4;
            AddAdminButton.Text = "Add Admin";
            AddAdminButton.UseVisualStyleBackColor = true;
            AddAdminButton.Visible = false;
            AddAdminButton.Click += AddAdminButton_Click;
            // 
            // ProfileSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddAdminButton);
            Controls.Add(UserCombobox);
            Controls.Add(UsernameButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(backButton);
            Name = "ProfileSettings";
            Text = "ProfileSettings";
            Load += ProfileSettings_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label UserIDLabel;
        private Label UserID2;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Label AccountLevelLabel;
        private Label AccountLevelDisplayLabel;
        private Button UsernameButton;
        private ComboBox UserCombobox;
        private Button AddAdminButton;
    }
}