namespace ATMapplication
{
    partial class BalanceAccounts
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
            this.BalanceAccountsTitle = new System.Windows.Forms.Label();
            this.AccountCustomerLabel = new System.Windows.Forms.TextBox();
            this.AccountCheckingBTN = new System.Windows.Forms.Button();
            this.AccountsSavingBTN = new System.Windows.Forms.Button();
            this.AccountsOptionLabel = new System.Windows.Forms.Label();
            this.AccountsMenuBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BalanceAccountsTitle
            // 
            this.BalanceAccountsTitle.AutoSize = true;
            this.BalanceAccountsTitle.BackColor = System.Drawing.Color.Transparent;
            this.BalanceAccountsTitle.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceAccountsTitle.Location = new System.Drawing.Point(151, 42);
            this.BalanceAccountsTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BalanceAccountsTitle.Name = "BalanceAccountsTitle";
            this.BalanceAccountsTitle.Size = new System.Drawing.Size(692, 79);
            this.BalanceAccountsTitle.TabIndex = 3;
            this.BalanceAccountsTitle.Text = "Welcome to Long\'s ATM";
            this.BalanceAccountsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AccountCustomerLabel
            // 
            this.AccountCustomerLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.AccountCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountCustomerLabel.Location = new System.Drawing.Point(370, 175);
            this.AccountCustomerLabel.Name = "AccountCustomerLabel";
            this.AccountCustomerLabel.Size = new System.Drawing.Size(222, 29);
            this.AccountCustomerLabel.TabIndex = 23;
            this.AccountCustomerLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AccountCheckingBTN
            // 
            this.AccountCheckingBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountCheckingBTN.Location = new System.Drawing.Point(255, 314);
            this.AccountCheckingBTN.Name = "AccountCheckingBTN";
            this.AccountCheckingBTN.Size = new System.Drawing.Size(175, 51);
            this.AccountCheckingBTN.TabIndex = 24;
            this.AccountCheckingBTN.Text = "Checking";
            this.AccountCheckingBTN.UseVisualStyleBackColor = true;
            this.AccountCheckingBTN.Click += new System.EventHandler(this.AccountCheckingBTN_Click);
            // 
            // AccountsSavingBTN
            // 
            this.AccountsSavingBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsSavingBTN.Location = new System.Drawing.Point(519, 314);
            this.AccountsSavingBTN.Name = "AccountsSavingBTN";
            this.AccountsSavingBTN.Size = new System.Drawing.Size(175, 51);
            this.AccountsSavingBTN.TabIndex = 25;
            this.AccountsSavingBTN.Text = "Savings";
            this.AccountsSavingBTN.UseVisualStyleBackColor = true;
            this.AccountsSavingBTN.Click += new System.EventHandler(this.AccountsSavingBTN_Click);
            // 
            // AccountsOptionLabel
            // 
            this.AccountsOptionLabel.AutoSize = true;
            this.AccountsOptionLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsOptionLabel.Location = new System.Drawing.Point(191, 242);
            this.AccountsOptionLabel.Name = "AccountsOptionLabel";
            this.AccountsOptionLabel.Size = new System.Drawing.Size(556, 27);
            this.AccountsOptionLabel.TabIndex = 26;
            this.AccountsOptionLabel.Text = "Which Account would you like to check the balance of:";
            this.AccountsOptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountsMenuBTN
            // 
            this.AccountsMenuBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsMenuBTN.Location = new System.Drawing.Point(395, 401);
            this.AccountsMenuBTN.Name = "AccountsMenuBTN";
            this.AccountsMenuBTN.Size = new System.Drawing.Size(175, 51);
            this.AccountsMenuBTN.TabIndex = 42;
            this.AccountsMenuBTN.Text = "Main Menu";
            this.AccountsMenuBTN.UseVisualStyleBackColor = true;
            this.AccountsMenuBTN.Click += new System.EventHandler(this.AccountsMenuBTN_Click);
            // 
            // BalanceAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(959, 521);
            this.Controls.Add(this.AccountsMenuBTN);
            this.Controls.Add(this.AccountsOptionLabel);
            this.Controls.Add(this.AccountsSavingBTN);
            this.Controls.Add(this.AccountCheckingBTN);
            this.Controls.Add(this.AccountCustomerLabel);
            this.Controls.Add(this.BalanceAccountsTitle);
            this.Name = "BalanceAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BalanceAccountsTitle;
        private System.Windows.Forms.TextBox AccountCustomerLabel;
        private System.Windows.Forms.Button AccountCheckingBTN;
        private System.Windows.Forms.Button AccountsSavingBTN;
        private System.Windows.Forms.Label AccountsOptionLabel;
        private System.Windows.Forms.Button AccountsMenuBTN;
    }
}