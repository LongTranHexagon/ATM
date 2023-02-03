namespace ATMapplication
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
            this.Title = new System.Windows.Forms.Label();
            this.MainMenuOptionsLabel = new System.Windows.Forms.Label();
            this.MainMenuBalanceBTN = new System.Windows.Forms.Button();
            this.MainMenuFastCashBTN = new System.Windows.Forms.Button();
            this.MainMenuWithdrawBTN = new System.Windows.Forms.Button();
            this.MainMenuDepositBTN = new System.Windows.Forms.Button();
            this.MainMenu5TransactionsBTN = new System.Windows.Forms.Button();
            this.MainMenuStatementBTN = new System.Windows.Forms.Button();
            this.MainMenuChangePINBTN = new System.Windows.Forms.Button();
            this.MainMenuChangePhoneBTN = new System.Windows.Forms.Button();
            this.MainMenuCustNameLB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(177, 20);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(692, 79);
            this.Title.TabIndex = 2;
            this.Title.Text = "Welcome to Long\'s ATM";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenuOptionsLabel
            // 
            this.MainMenuOptionsLabel.AutoSize = true;
            this.MainMenuOptionsLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuOptionsLabel.Location = new System.Drawing.Point(307, 195);
            this.MainMenuOptionsLabel.Name = "MainMenuOptionsLabel";
            this.MainMenuOptionsLabel.Size = new System.Drawing.Size(414, 27);
            this.MainMenuOptionsLabel.TabIndex = 5;
            this.MainMenuOptionsLabel.Text = "Please select from the following options:";
            this.MainMenuOptionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuBalanceBTN
            // 
            this.MainMenuBalanceBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuBalanceBTN.Location = new System.Drawing.Point(279, 259);
            this.MainMenuBalanceBTN.Name = "MainMenuBalanceBTN";
            this.MainMenuBalanceBTN.Size = new System.Drawing.Size(175, 31);
            this.MainMenuBalanceBTN.TabIndex = 14;
            this.MainMenuBalanceBTN.Text = "Balance";
            this.MainMenuBalanceBTN.UseVisualStyleBackColor = true;
            this.MainMenuBalanceBTN.Click += new System.EventHandler(this.MainMenuBalanceBTN_Click);
            // 
            // MainMenuFastCashBTN
            // 
            this.MainMenuFastCashBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuFastCashBTN.Location = new System.Drawing.Point(279, 317);
            this.MainMenuFastCashBTN.Name = "MainMenuFastCashBTN";
            this.MainMenuFastCashBTN.Size = new System.Drawing.Size(175, 31);
            this.MainMenuFastCashBTN.TabIndex = 15;
            this.MainMenuFastCashBTN.Text = "Fast Cash";
            this.MainMenuFastCashBTN.UseVisualStyleBackColor = true;
            // 
            // MainMenuWithdrawBTN
            // 
            this.MainMenuWithdrawBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuWithdrawBTN.Location = new System.Drawing.Point(279, 373);
            this.MainMenuWithdrawBTN.Name = "MainMenuWithdrawBTN";
            this.MainMenuWithdrawBTN.Size = new System.Drawing.Size(175, 31);
            this.MainMenuWithdrawBTN.TabIndex = 16;
            this.MainMenuWithdrawBTN.Text = "Withdraw";
            this.MainMenuWithdrawBTN.UseVisualStyleBackColor = true;
            // 
            // MainMenuDepositBTN
            // 
            this.MainMenuDepositBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuDepositBTN.Location = new System.Drawing.Point(279, 424);
            this.MainMenuDepositBTN.Name = "MainMenuDepositBTN";
            this.MainMenuDepositBTN.Size = new System.Drawing.Size(175, 31);
            this.MainMenuDepositBTN.TabIndex = 17;
            this.MainMenuDepositBTN.Text = "Deposit";
            this.MainMenuDepositBTN.UseVisualStyleBackColor = true;
            // 
            // MainMenu5TransactionsBTN
            // 
            this.MainMenu5TransactionsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu5TransactionsBTN.Location = new System.Drawing.Point(571, 259);
            this.MainMenu5TransactionsBTN.Name = "MainMenu5TransactionsBTN";
            this.MainMenu5TransactionsBTN.Size = new System.Drawing.Size(175, 31);
            this.MainMenu5TransactionsBTN.TabIndex = 18;
            this.MainMenu5TransactionsBTN.Text = "Last 5 Transactions";
            this.MainMenu5TransactionsBTN.UseVisualStyleBackColor = true;
            // 
            // MainMenuStatementBTN
            // 
            this.MainMenuStatementBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStatementBTN.Location = new System.Drawing.Point(571, 317);
            this.MainMenuStatementBTN.Name = "MainMenuStatementBTN";
            this.MainMenuStatementBTN.Size = new System.Drawing.Size(175, 31);
            this.MainMenuStatementBTN.TabIndex = 19;
            this.MainMenuStatementBTN.Text = "Bank Statement";
            this.MainMenuStatementBTN.UseVisualStyleBackColor = true;
            // 
            // MainMenuChangePINBTN
            // 
            this.MainMenuChangePINBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuChangePINBTN.Location = new System.Drawing.Point(571, 373);
            this.MainMenuChangePINBTN.Name = "MainMenuChangePINBTN";
            this.MainMenuChangePINBTN.Size = new System.Drawing.Size(175, 31);
            this.MainMenuChangePINBTN.TabIndex = 20;
            this.MainMenuChangePINBTN.Text = "Change PIN";
            this.MainMenuChangePINBTN.UseVisualStyleBackColor = true;
            // 
            // MainMenuChangePhoneBTN
            // 
            this.MainMenuChangePhoneBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuChangePhoneBTN.Location = new System.Drawing.Point(571, 424);
            this.MainMenuChangePhoneBTN.Name = "MainMenuChangePhoneBTN";
            this.MainMenuChangePhoneBTN.Size = new System.Drawing.Size(175, 31);
            this.MainMenuChangePhoneBTN.TabIndex = 21;
            this.MainMenuChangePhoneBTN.Text = "Change Phone Number";
            this.MainMenuChangePhoneBTN.UseVisualStyleBackColor = true;
            // 
            // MainMenuCustNameLB
            // 
            this.MainMenuCustNameLB.BackColor = System.Drawing.Color.SkyBlue;
            this.MainMenuCustNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuCustNameLB.Location = new System.Drawing.Point(399, 146);
            this.MainMenuCustNameLB.Name = "MainMenuCustNameLB";
            this.MainMenuCustNameLB.Size = new System.Drawing.Size(222, 29);
            this.MainMenuCustNameLB.TabIndex = 22;
            this.MainMenuCustNameLB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(959, 521);
            this.Controls.Add(this.MainMenuCustNameLB);
            this.Controls.Add(this.MainMenuChangePhoneBTN);
            this.Controls.Add(this.MainMenuChangePINBTN);
            this.Controls.Add(this.MainMenuStatementBTN);
            this.Controls.Add(this.MainMenu5TransactionsBTN);
            this.Controls.Add(this.MainMenuDepositBTN);
            this.Controls.Add(this.MainMenuWithdrawBTN);
            this.Controls.Add(this.MainMenuFastCashBTN);
            this.Controls.Add(this.MainMenuBalanceBTN);
            this.Controls.Add(this.MainMenuOptionsLabel);
            this.Controls.Add(this.Title);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label MainMenuOptionsLabel;
        private System.Windows.Forms.Button MainMenuBalanceBTN;
        private System.Windows.Forms.Button MainMenuFastCashBTN;
        private System.Windows.Forms.Button MainMenuWithdrawBTN;
        private System.Windows.Forms.Button MainMenuDepositBTN;
        private System.Windows.Forms.Button MainMenu5TransactionsBTN;
        private System.Windows.Forms.Button MainMenuStatementBTN;
        private System.Windows.Forms.Button MainMenuChangePINBTN;
        private System.Windows.Forms.Button MainMenuChangePhoneBTN;
        private System.Windows.Forms.TextBox MainMenuCustNameLB;
    }
}