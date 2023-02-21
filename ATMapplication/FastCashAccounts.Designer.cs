namespace ATMapplication
{
    partial class FastCashAccounts
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
            this.FastCastAccountTitle = new System.Windows.Forms.Label();
            this.AccountCustomerLabel = new System.Windows.Forms.TextBox();
            this.FastCashCustomerLabel = new System.Windows.Forms.TextBox();
            this.AccountsOptionLabel = new System.Windows.Forms.Label();
            this.FastCashOptionLabel = new System.Windows.Forms.Label();
            this.FastCashCheckingBTN = new System.Windows.Forms.Button();
            this.FastCashSavingBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FastCastAccountTitle
            // 
            this.FastCastAccountTitle.AutoSize = true;
            this.FastCastAccountTitle.BackColor = System.Drawing.Color.Transparent;
            this.FastCastAccountTitle.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastCastAccountTitle.Location = new System.Drawing.Point(151, 42);
            this.FastCastAccountTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FastCastAccountTitle.Name = "FastCastAccountTitle";
            this.FastCastAccountTitle.Size = new System.Drawing.Size(692, 79);
            this.FastCastAccountTitle.TabIndex = 2;
            this.FastCastAccountTitle.Text = "Welcome to Long\'s ATM";
            this.FastCastAccountTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AccountCustomerLabel
            // 
            this.AccountCustomerLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.AccountCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountCustomerLabel.Location = new System.Drawing.Point(956, 732);
            this.AccountCustomerLabel.Name = "AccountCustomerLabel";
            this.AccountCustomerLabel.Size = new System.Drawing.Size(222, 29);
            this.AccountCustomerLabel.TabIndex = 24;
            this.AccountCustomerLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FastCashCustomerLabel
            // 
            this.FastCashCustomerLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.FastCashCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastCashCustomerLabel.Location = new System.Drawing.Point(370, 175);
            this.FastCashCustomerLabel.Name = "FastCashCustomerLabel";
            this.FastCashCustomerLabel.Size = new System.Drawing.Size(222, 29);
            this.FastCashCustomerLabel.TabIndex = 26;
            this.FastCashCustomerLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AccountsOptionLabel
            // 
            this.AccountsOptionLabel.AutoSize = true;
            this.AccountsOptionLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsOptionLabel.Location = new System.Drawing.Point(504, 847);
            this.AccountsOptionLabel.Name = "AccountsOptionLabel";
            this.AccountsOptionLabel.Size = new System.Drawing.Size(556, 27);
            this.AccountsOptionLabel.TabIndex = 27;
            this.AccountsOptionLabel.Text = "Which Account would you like to check the balance of:";
            this.AccountsOptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FastCashOptionLabel
            // 
            this.FastCashOptionLabel.AutoSize = true;
            this.FastCashOptionLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastCashOptionLabel.Location = new System.Drawing.Point(228, 243);
            this.FastCashOptionLabel.Name = "FastCashOptionLabel";
            this.FastCashOptionLabel.Size = new System.Drawing.Size(505, 27);
            this.FastCashOptionLabel.TabIndex = 29;
            this.FastCashOptionLabel.Text = "Which Account would you like to Withdraw from:";
            this.FastCashOptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FastCashCheckingBTN
            // 
            this.FastCashCheckingBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastCashCheckingBTN.Location = new System.Drawing.Point(255, 314);
            this.FastCashCheckingBTN.Name = "FastCashCheckingBTN";
            this.FastCashCheckingBTN.Size = new System.Drawing.Size(175, 51);
            this.FastCashCheckingBTN.TabIndex = 30;
            this.FastCashCheckingBTN.Text = "Checking";
            this.FastCashCheckingBTN.UseVisualStyleBackColor = true;
            this.FastCashCheckingBTN.Click += new System.EventHandler(this.FastCashCheckingBTN_Click);
            // 
            // FastCashSavingBTN
            // 
            this.FastCashSavingBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastCashSavingBTN.Location = new System.Drawing.Point(519, 314);
            this.FastCashSavingBTN.Name = "FastCashSavingBTN";
            this.FastCashSavingBTN.Size = new System.Drawing.Size(175, 51);
            this.FastCashSavingBTN.TabIndex = 31;
            this.FastCashSavingBTN.Text = "Savings";
            this.FastCashSavingBTN.UseVisualStyleBackColor = true;
            this.FastCashSavingBTN.Click += new System.EventHandler(this.FastCashSavingBTN_Click);
            // 
            // FastCashAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(959, 521);
            this.Controls.Add(this.FastCashSavingBTN);
            this.Controls.Add(this.FastCashCheckingBTN);
            this.Controls.Add(this.FastCashOptionLabel);
            this.Controls.Add(this.AccountsOptionLabel);
            this.Controls.Add(this.FastCashCustomerLabel);
            this.Controls.Add(this.AccountCustomerLabel);
            this.Controls.Add(this.FastCastAccountTitle);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FastCashAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastCash";
            this.Load += new System.EventHandler(this.FastCash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FastCastAccountTitle;
        private System.Windows.Forms.TextBox AccountCustomerLabel;
        private System.Windows.Forms.TextBox FastCashCustomerLabel;
        private System.Windows.Forms.Label AccountsOptionLabel;
        private System.Windows.Forms.Label FastCashOptionLabel;
        private System.Windows.Forms.Button FastCashCheckingBTN;
        private System.Windows.Forms.Button FastCashSavingBTN;
    }
}