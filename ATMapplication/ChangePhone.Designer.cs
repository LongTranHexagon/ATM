namespace ATMapplication
{
    partial class ChangePhone
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
            this.ChangePhoneTitle = new System.Windows.Forms.Label();
            this.ChangePhoneCustNameLB = new System.Windows.Forms.TextBox();
            this.ChangePhoneNumberLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChangePhoneSubmitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangePhoneTitle
            // 
            this.ChangePhoneTitle.AutoSize = true;
            this.ChangePhoneTitle.BackColor = System.Drawing.Color.Transparent;
            this.ChangePhoneTitle.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePhoneTitle.Location = new System.Drawing.Point(151, 42);
            this.ChangePhoneTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ChangePhoneTitle.Name = "ChangePhoneTitle";
            this.ChangePhoneTitle.Size = new System.Drawing.Size(692, 79);
            this.ChangePhoneTitle.TabIndex = 3;
            this.ChangePhoneTitle.Text = "Welcome to Long\'s ATM";
            this.ChangePhoneTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangePhoneCustNameLB
            // 
            this.ChangePhoneCustNameLB.BackColor = System.Drawing.Color.SkyBlue;
            this.ChangePhoneCustNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePhoneCustNameLB.Location = new System.Drawing.Point(399, 146);
            this.ChangePhoneCustNameLB.Name = "ChangePhoneCustNameLB";
            this.ChangePhoneCustNameLB.Size = new System.Drawing.Size(222, 29);
            this.ChangePhoneCustNameLB.TabIndex = 23;
            this.ChangePhoneCustNameLB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangePhoneNumberLabel
            // 
            this.ChangePhoneNumberLabel.AutoSize = true;
            this.ChangePhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePhoneNumberLabel.Location = new System.Drawing.Point(339, 206);
            this.ChangePhoneNumberLabel.Name = "ChangePhoneNumberLabel";
            this.ChangePhoneNumberLabel.Size = new System.Drawing.Size(343, 27);
            this.ChangePhoneNumberLabel.TabIndex = 24;
            this.ChangePhoneNumberLabel.Text = "Please enter your Phone Number:";
            this.ChangePhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 25;
            // 
            // ChangePhoneSubmitBTN
            // 
            this.ChangePhoneSubmitBTN.BackColor = System.Drawing.Color.Lime;
            this.ChangePhoneSubmitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePhoneSubmitBTN.Location = new System.Drawing.Point(459, 316);
            this.ChangePhoneSubmitBTN.Name = "ChangePhoneSubmitBTN";
            this.ChangePhoneSubmitBTN.Size = new System.Drawing.Size(91, 29);
            this.ChangePhoneSubmitBTN.TabIndex = 26;
            this.ChangePhoneSubmitBTN.Text = "Submit";
            this.ChangePhoneSubmitBTN.UseVisualStyleBackColor = false;
            // 
            // ChangePhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(959, 521);
            this.Controls.Add(this.ChangePhoneSubmitBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChangePhoneNumberLabel);
            this.Controls.Add(this.ChangePhoneCustNameLB);
            this.Controls.Add(this.ChangePhoneTitle);
            this.Name = "ChangePhone";
            this.Text = "ChangePhone";
            this.Load += new System.EventHandler(this.ChangePhone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChangePhoneTitle;
        public System.Windows.Forms.TextBox ChangePhoneCustNameLB;
        private System.Windows.Forms.Label ChangePhoneNumberLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ChangePhoneSubmitBTN;
    }
}