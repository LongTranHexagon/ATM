namespace ATMapplication
{
    partial class Accounts
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
            this.AccountsTitle = new System.Windows.Forms.Label();
            this.AccountCustomerLabel = new System.Windows.Forms.TextBox();
            this.AccountCheckingBTN = new System.Windows.Forms.Button();
            this.AccountsSavingBTN = new System.Windows.Forms.Button();
            this.AccountsOptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccountsTitle
            // 
            this.AccountsTitle.AutoSize = true;
            this.AccountsTitle.BackColor = System.Drawing.Color.Transparent;
            this.AccountsTitle.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsTitle.Location = new System.Drawing.Point(151, 42);
            this.AccountsTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AccountsTitle.Name = "AccountsTitle";
            this.AccountsTitle.Size = new System.Drawing.Size(692, 79);
            this.AccountsTitle.TabIndex = 3;
            this.AccountsTitle.Text = "Welcome to Long\'s ATM";
            this.AccountsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AccountsTitle.Click += new System.EventHandler(this.Title_Click);
            // 
            // AccountCustomerLabel
            // 
            this.AccountCustomerLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.AccountCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountCustomerLabel.Location = new System.Drawing.Point(370, 175);
            this.AccountCustomerLabel.Name = "AccountCustomerLabel";
            this.AccountCustomerLabel.Size = new System.Drawing.Size(222, 29);
            this.AccountCustomerLabel.TabIndex = 23;
            this.AccountCustomerLabel.Text = "Hello Customer";
            this.AccountCustomerLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AccountCheckingBTN
            // 
            this.AccountCheckingBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountCheckingBTN.Location = new System.Drawing.Point(285, 300);
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
            this.AccountsSavingBTN.Location = new System.Drawing.Point(519, 300);
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
            this.AccountsOptionLabel.Location = new System.Drawing.Point(280, 237);
            this.AccountsOptionLabel.Name = "AccountsOptionLabel";
            this.AccountsOptionLabel.Size = new System.Drawing.Size(414, 27);
            this.AccountsOptionLabel.TabIndex = 26;
            this.AccountsOptionLabel.Text = "Please select from the following options:";
            this.AccountsOptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AccountsOptionLabel.Click += new System.EventHandler(this.CardNumberLabel_Click);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1033, 555);
            this.Controls.Add(this.AccountsOptionLabel);
            this.Controls.Add(this.AccountsSavingBTN);
            this.Controls.Add(this.AccountCheckingBTN);
            this.Controls.Add(this.AccountCustomerLabel);
            this.Controls.Add(this.AccountsTitle);
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountsTitle;
        private System.Windows.Forms.TextBox AccountCustomerLabel;
        private System.Windows.Forms.Button AccountCheckingBTN;
        private System.Windows.Forms.Button AccountsSavingBTN;
        private System.Windows.Forms.Label AccountsOptionLabel;
    }
}