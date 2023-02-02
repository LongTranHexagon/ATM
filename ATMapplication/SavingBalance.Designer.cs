namespace ATMapplication
{
    partial class SavingBalance
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
            this.SavingBalanceTitle = new System.Windows.Forms.Label();
            this.SavingBalanceCustomerLabel = new System.Windows.Forms.TextBox();
            this.SavingBalanceLabel = new System.Windows.Forms.Label();
            this.SavingBalanceTextBox = new System.Windows.Forms.TextBox();
            this.SavingsBalanceMenuBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SavingBalanceTitle
            // 
            this.SavingBalanceTitle.AutoSize = true;
            this.SavingBalanceTitle.BackColor = System.Drawing.Color.Transparent;
            this.SavingBalanceTitle.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingBalanceTitle.Location = new System.Drawing.Point(141, 71);
            this.SavingBalanceTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SavingBalanceTitle.Name = "SavingBalanceTitle";
            this.SavingBalanceTitle.Size = new System.Drawing.Size(692, 79);
            this.SavingBalanceTitle.TabIndex = 5;
            this.SavingBalanceTitle.Text = "Welcome to Long\'s ATM";
            this.SavingBalanceTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SavingBalanceTitle.Click += new System.EventHandler(this.Title_Click);
            // 
            // SavingBalanceCustomerLabel
            // 
            this.SavingBalanceCustomerLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.SavingBalanceCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingBalanceCustomerLabel.Location = new System.Drawing.Point(352, 197);
            this.SavingBalanceCustomerLabel.Name = "SavingBalanceCustomerLabel";
            this.SavingBalanceCustomerLabel.Size = new System.Drawing.Size(222, 29);
            this.SavingBalanceCustomerLabel.TabIndex = 25;
            this.SavingBalanceCustomerLabel.Text = "Hello Customer";
            this.SavingBalanceCustomerLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SavingBalanceLabel
            // 
            this.SavingBalanceLabel.AutoSize = true;
            this.SavingBalanceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingBalanceLabel.Location = new System.Drawing.Point(219, 265);
            this.SavingBalanceLabel.Name = "SavingBalanceLabel";
            this.SavingBalanceLabel.Size = new System.Drawing.Size(426, 27);
            this.SavingBalanceLabel.TabIndex = 28;
            this.SavingBalanceLabel.Text = "Current balance in your Saving account is:";
            this.SavingBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavingBalanceTextBox
            // 
            this.SavingBalanceTextBox.Location = new System.Drawing.Point(385, 325);
            this.SavingBalanceTextBox.Name = "SavingBalanceTextBox";
            this.SavingBalanceTextBox.Size = new System.Drawing.Size(155, 20);
            this.SavingBalanceTextBox.TabIndex = 29;
            // 
            // SavingsBalanceMenuBTN
            // 
            this.SavingsBalanceMenuBTN.BackColor = System.Drawing.Color.LawnGreen;
            this.SavingsBalanceMenuBTN.Location = new System.Drawing.Point(401, 375);
            this.SavingsBalanceMenuBTN.Name = "SavingsBalanceMenuBTN";
            this.SavingsBalanceMenuBTN.Size = new System.Drawing.Size(123, 42);
            this.SavingsBalanceMenuBTN.TabIndex = 30;
            this.SavingsBalanceMenuBTN.Text = "Back to Main Menu";
            this.SavingsBalanceMenuBTN.UseVisualStyleBackColor = false;
            // 
            // SavingBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1038, 537);
            this.Controls.Add(this.SavingsBalanceMenuBTN);
            this.Controls.Add(this.SavingBalanceTextBox);
            this.Controls.Add(this.SavingBalanceLabel);
            this.Controls.Add(this.SavingBalanceCustomerLabel);
            this.Controls.Add(this.SavingBalanceTitle);
            this.Name = "SavingBalance";
            this.Text = "SavingBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SavingBalanceTitle;
        private System.Windows.Forms.TextBox SavingBalanceCustomerLabel;
        private System.Windows.Forms.Label SavingBalanceLabel;
        private System.Windows.Forms.TextBox SavingBalanceTextBox;
        private System.Windows.Forms.Button SavingsBalanceMenuBTN;
    }
}