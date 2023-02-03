namespace ATMapplication
{
    partial class CheckBalance
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
            System.Windows.Forms.Button CheckBalanceMenuBTN;
            this.CheckBalanceTitle = new System.Windows.Forms.Label();
            this.CheckBalanceCustomerLabel = new System.Windows.Forms.TextBox();
            this.CheckBalanceLabel = new System.Windows.Forms.Label();
            this.CheckBalanceTextBox = new System.Windows.Forms.TextBox();
            CheckBalanceMenuBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckBalanceMenuBTN
            // 
            CheckBalanceMenuBTN.BackColor = System.Drawing.Color.LawnGreen;
            CheckBalanceMenuBTN.Location = new System.Drawing.Point(407, 367);
            CheckBalanceMenuBTN.Name = "CheckBalanceMenuBTN";
            CheckBalanceMenuBTN.Size = new System.Drawing.Size(123, 42);
            CheckBalanceMenuBTN.TabIndex = 29;
            CheckBalanceMenuBTN.Text = "Back to Main Menu";
            CheckBalanceMenuBTN.UseVisualStyleBackColor = false;
            CheckBalanceMenuBTN.Click += new System.EventHandler(this.CheckBalanceMenuBTN_Click);
            // 
            // CheckBalanceTitle
            // 
            this.CheckBalanceTitle.AutoSize = true;
            this.CheckBalanceTitle.BackColor = System.Drawing.Color.Transparent;
            this.CheckBalanceTitle.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBalanceTitle.Location = new System.Drawing.Point(145, 74);
            this.CheckBalanceTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CheckBalanceTitle.Name = "CheckBalanceTitle";
            this.CheckBalanceTitle.Size = new System.Drawing.Size(692, 79);
            this.CheckBalanceTitle.TabIndex = 4;
            this.CheckBalanceTitle.Text = "Welcome to Long\'s ATM";
            this.CheckBalanceTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CheckBalanceCustomerLabel
            // 
            this.CheckBalanceCustomerLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.CheckBalanceCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBalanceCustomerLabel.Location = new System.Drawing.Point(358, 192);
            this.CheckBalanceCustomerLabel.Name = "CheckBalanceCustomerLabel";
            this.CheckBalanceCustomerLabel.Size = new System.Drawing.Size(222, 29);
            this.CheckBalanceCustomerLabel.TabIndex = 24;
            this.CheckBalanceCustomerLabel.Text = "Hello Customer";
            this.CheckBalanceCustomerLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CheckBalanceCustomerLabel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CheckBalanceLabel
            // 
            this.CheckBalanceLabel.AutoSize = true;
            this.CheckBalanceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBalanceLabel.Location = new System.Drawing.Point(247, 257);
            this.CheckBalanceLabel.Name = "CheckBalanceLabel";
            this.CheckBalanceLabel.Size = new System.Drawing.Size(451, 27);
            this.CheckBalanceLabel.TabIndex = 27;
            this.CheckBalanceLabel.Text = "Current balance in your Checking account is:";
            this.CheckBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBalanceTextBox
            // 
            this.CheckBalanceTextBox.Location = new System.Drawing.Point(392, 319);
            this.CheckBalanceTextBox.Name = "CheckBalanceTextBox";
            this.CheckBalanceTextBox.Size = new System.Drawing.Size(155, 20);
            this.CheckBalanceTextBox.TabIndex = 28;
            this.CheckBalanceTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(998, 545);
            this.Controls.Add(CheckBalanceMenuBTN);
            this.Controls.Add(this.CheckBalanceTextBox);
            this.Controls.Add(this.CheckBalanceLabel);
            this.Controls.Add(this.CheckBalanceCustomerLabel);
            this.Controls.Add(this.CheckBalanceTitle);
            this.Name = "CheckBalance";
            this.Text = "CheckBalance";
            this.Load += new System.EventHandler(this.CheckBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CheckBalanceTitle;
        private System.Windows.Forms.TextBox CheckBalanceCustomerLabel;
        private System.Windows.Forms.Label CheckBalanceLabel;
        private System.Windows.Forms.TextBox CheckBalanceTextBox;
    }
}