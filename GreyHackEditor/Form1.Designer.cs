namespace GreyHackEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pathBox = new TextBox();
            pathBtn = new Button();
            compData = new Label();
            dbTime = new Label();
            dbTab = new TabControl();
            tabComputers = new TabPage();
            computerSubTab = new TabControl();
            ComputerSubtabHardware = new TabPage();
            ComputerSubtabFilesystem = new TabPage();
            computerSubtabUsers = new TabPage();
            computerUsersTable = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            karma = new DataGridViewTextBoxColumn();
            xp = new DataGridViewTextBoxColumn();
            deletable = new DataGridViewCheckBoxColumn();
            computerComboBox = new ComboBox();
            tabBanks = new TabPage();
            bankTransactionList = new TextBox();
            bankPasswordBox = new TextBox();
            label2 = new Label();
            bankBalanceBox = new NumericUpDown();
            label1 = new Label();
            bankComboBox = new ComboBox();
            tabWorld = new TabPage();
            hidePasswords = new CheckBox();
            github = new Button();
            dbTab.SuspendLayout();
            tabComputers.SuspendLayout();
            computerSubTab.SuspendLayout();
            computerSubtabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)computerUsersTable).BeginInit();
            tabBanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankBalanceBox).BeginInit();
            SuspendLayout();
            // 
            // pathBox
            // 
            pathBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pathBox.Location = new Point(12, 5);
            pathBox.Name = "pathBox";
            pathBox.Size = new Size(364, 23);
            pathBox.TabIndex = 0;
            pathBox.WordWrap = false;
            pathBox.TextChanged += pathBox_TextChanged;
            // 
            // pathBtn
            // 
            pathBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pathBtn.Location = new Point(386, 5);
            pathBtn.Name = "pathBtn";
            pathBtn.Size = new Size(75, 23);
            pathBtn.TabIndex = 1;
            pathBtn.Text = "Open";
            pathBtn.UseVisualStyleBackColor = true;
            pathBtn.Click += pathBtn_Click;
            // 
            // compData
            // 
            compData.AutoSize = true;
            compData.Location = new Point(12, 31);
            compData.Name = "compData";
            compData.Size = new Size(116, 15);
            compData.TabIndex = 2;
            compData.Text = "Select a database file";
            compData.Click += label1_Click;
            // 
            // dbTime
            // 
            dbTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dbTime.AutoSize = true;
            dbTime.Location = new Point(345, 31);
            dbTime.Name = "dbTime";
            dbTime.Size = new Size(116, 15);
            dbTime.TabIndex = 3;
            dbTime.Text = "Select a database file";
            dbTime.Click += label1_Click_1;
            // 
            // dbTab
            // 
            dbTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbTab.Controls.Add(tabComputers);
            dbTab.Controls.Add(tabBanks);
            dbTab.Controls.Add(tabWorld);
            dbTab.Location = new Point(12, 49);
            dbTab.Name = "dbTab";
            dbTab.SelectedIndex = 0;
            dbTab.Size = new Size(449, 496);
            dbTab.TabIndex = 4;
            // 
            // tabComputers
            // 
            tabComputers.Controls.Add(computerSubTab);
            tabComputers.Controls.Add(computerComboBox);
            tabComputers.Location = new Point(4, 24);
            tabComputers.Name = "tabComputers";
            tabComputers.Padding = new Padding(3);
            tabComputers.Size = new Size(441, 468);
            tabComputers.TabIndex = 0;
            tabComputers.Text = "Computers";
            tabComputers.UseVisualStyleBackColor = true;
            tabComputers.Click += tabPage1_Click;
            // 
            // computerSubTab
            // 
            computerSubTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            computerSubTab.Controls.Add(ComputerSubtabHardware);
            computerSubTab.Controls.Add(ComputerSubtabFilesystem);
            computerSubTab.Controls.Add(computerSubtabUsers);
            computerSubTab.Location = new Point(6, 35);
            computerSubTab.Name = "computerSubTab";
            computerSubTab.SelectedIndex = 0;
            computerSubTab.Size = new Size(432, 430);
            computerSubTab.TabIndex = 1;
            // 
            // ComputerSubtabHardware
            // 
            ComputerSubtabHardware.Location = new Point(4, 24);
            ComputerSubtabHardware.Name = "ComputerSubtabHardware";
            ComputerSubtabHardware.Size = new Size(424, 402);
            ComputerSubtabHardware.TabIndex = 0;
            ComputerSubtabHardware.Text = "Hardware";
            ComputerSubtabHardware.UseVisualStyleBackColor = true;
            // 
            // ComputerSubtabFilesystem
            // 
            ComputerSubtabFilesystem.Location = new Point(4, 24);
            ComputerSubtabFilesystem.Name = "ComputerSubtabFilesystem";
            ComputerSubtabFilesystem.Size = new Size(424, 402);
            ComputerSubtabFilesystem.TabIndex = 1;
            ComputerSubtabFilesystem.Text = "Filesystem";
            ComputerSubtabFilesystem.UseVisualStyleBackColor = true;
            // 
            // computerSubtabUsers
            // 
            computerSubtabUsers.Controls.Add(computerUsersTable);
            computerSubtabUsers.Location = new Point(4, 24);
            computerSubtabUsers.Name = "computerSubtabUsers";
            computerSubtabUsers.Size = new Size(424, 402);
            computerSubtabUsers.TabIndex = 2;
            computerSubtabUsers.Text = "Users";
            computerSubtabUsers.UseVisualStyleBackColor = true;
            // 
            // computerUsersTable
            // 
            computerUsersTable.AllowUserToAddRows = false;
            computerUsersTable.AllowUserToDeleteRows = false;
            computerUsersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            computerUsersTable.Columns.AddRange(new DataGridViewColumn[] { username, password, karma, xp, deletable });
            computerUsersTable.Location = new Point(3, 3);
            computerUsersTable.Name = "computerUsersTable";
            computerUsersTable.Size = new Size(418, 396);
            computerUsersTable.TabIndex = 0;
            computerUsersTable.CellValidating += computerUsersTable_CellValidating;
            // 
            // username
            // 
            username.HeaderText = "Username";
            username.Name = "username";
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.Name = "password";
            // 
            // karma
            // 
            karma.HeaderText = "Karma";
            karma.Name = "karma";
            // 
            // xp
            // 
            xp.HeaderText = "XP";
            xp.Name = "xp";
            // 
            // deletable
            // 
            deletable.HeaderText = "Deletable";
            deletable.Name = "deletable";
            // 
            // computerComboBox
            // 
            computerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            computerComboBox.FormattingEnabled = true;
            computerComboBox.Location = new Point(6, 6);
            computerComboBox.Name = "computerComboBox";
            computerComboBox.Size = new Size(429, 23);
            computerComboBox.TabIndex = 0;
            // 
            // tabBanks
            // 
            tabBanks.Controls.Add(bankTransactionList);
            tabBanks.Controls.Add(bankPasswordBox);
            tabBanks.Controls.Add(label2);
            tabBanks.Controls.Add(bankBalanceBox);
            tabBanks.Controls.Add(label1);
            tabBanks.Controls.Add(bankComboBox);
            tabBanks.Location = new Point(4, 24);
            tabBanks.Name = "tabBanks";
            tabBanks.Padding = new Padding(3);
            tabBanks.Size = new Size(441, 468);
            tabBanks.TabIndex = 1;
            tabBanks.Text = "Bank Accounts";
            tabBanks.UseVisualStyleBackColor = true;
            // 
            // bankTransactionList
            // 
            bankTransactionList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bankTransactionList.Location = new Point(6, 64);
            bankTransactionList.Multiline = true;
            bankTransactionList.Name = "bankTransactionList";
            bankTransactionList.ReadOnly = true;
            bankTransactionList.Size = new Size(429, 398);
            bankTransactionList.TabIndex = 7;
            // 
            // bankPasswordBox
            // 
            bankPasswordBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bankPasswordBox.Location = new Point(255, 35);
            bankPasswordBox.Name = "bankPasswordBox";
            bankPasswordBox.Size = new Size(180, 23);
            bankPasswordBox.TabIndex = 6;
            bankPasswordBox.Tag = "HasPassword";
            bankPasswordBox.Text = "test";
            bankPasswordBox.UseSystemPasswordChar = true;
            bankPasswordBox.TextChanged += textBox1_TextChanged_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(189, 38);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // bankBalanceBox
            // 
            bankBalanceBox.DecimalPlaces = 2;
            bankBalanceBox.Location = new Point(63, 35);
            bankBalanceBox.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            bankBalanceBox.Name = "bankBalanceBox";
            bankBalanceBox.Size = new Size(120, 23);
            bankBalanceBox.TabIndex = 4;
            bankBalanceBox.TextAlign = HorizontalAlignment.Right;
            bankBalanceBox.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Balance:";
            // 
            // bankComboBox
            // 
            bankComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bankComboBox.FormattingEnabled = true;
            bankComboBox.Location = new Point(6, 6);
            bankComboBox.Name = "bankComboBox";
            bankComboBox.Size = new Size(429, 23);
            bankComboBox.TabIndex = 1;
            bankComboBox.SelectedIndexChanged += bankComboBox_SelectedIndexChanged;
            // 
            // tabWorld
            // 
            tabWorld.Location = new Point(4, 24);
            tabWorld.Name = "tabWorld";
            tabWorld.Size = new Size(441, 468);
            tabWorld.TabIndex = 2;
            tabWorld.Text = "World";
            tabWorld.UseVisualStyleBackColor = true;
            // 
            // hidePasswords
            // 
            hidePasswords.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            hidePasswords.AutoSize = true;
            hidePasswords.Checked = true;
            hidePasswords.CheckState = CheckState.Checked;
            hidePasswords.Location = new Point(16, 551);
            hidePasswords.Name = "hidePasswords";
            hidePasswords.Size = new Size(109, 19);
            hidePasswords.TabIndex = 0;
            hidePasswords.Text = "Hide Passwords";
            hidePasswords.UseVisualStyleBackColor = true;
            hidePasswords.CheckedChanged += hidePasswords_CheckedChanged;
            // 
            // github
            // 
            github.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            github.Location = new Point(334, 551);
            github.Name = "github";
            github.Size = new Size(123, 23);
            github.TabIndex = 5;
            github.Text = "View Source Code";
            github.UseVisualStyleBackColor = true;
            github.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 579);
            Controls.Add(github);
            Controls.Add(hidePasswords);
            Controls.Add(dbTab);
            Controls.Add(dbTime);
            Controls.Add(compData);
            Controls.Add(pathBtn);
            Controls.Add(pathBox);
            Name = "Form1";
            Text = "GreyHackEditor by Wyatt";
            Load += Form1_Load;
            dbTab.ResumeLayout(false);
            tabComputers.ResumeLayout(false);
            computerSubTab.ResumeLayout(false);
            computerSubtabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)computerUsersTable).EndInit();
            tabBanks.ResumeLayout(false);
            tabBanks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bankBalanceBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox pathBox;
        public Button pathBtn;
        private Label compData;
        private Label dbTime;
        private TabControl dbTab;
        private TabPage tabComputers;
        private TabPage tabBanks;
        private CheckBox hidePasswords;
        private Button github;
        private ComboBox computerComboBox;
        private ComboBox bankComboBox;
        private NumericUpDown bankBalanceBox;
        private Label label1;
        private Label label2;
        private TextBox bankPasswordBox;
        private TabPage tabWorld;
        private TextBox bankTransactionList;
        private TabControl computerSubTab;
        private TabPage ComputerSubtabHardware;
        private TabPage ComputerSubtabFilesystem;
        private TabPage computerSubtabUsers;
        private DataGridView computerUsersTable;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn karma;
        private DataGridViewTextBoxColumn xp;
        private DataGridViewCheckBoxColumn deletable;
    }
}
