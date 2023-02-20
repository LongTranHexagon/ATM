namespace ATMapplication
{
    partial class Register
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
            this.RegisterTitleLB = new System.Windows.Forms.Label();
            this.RegisterIntroTextBox = new System.Windows.Forms.TextBox();
            this.RegisterSubmitBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterTitleLB
            // 
            this.RegisterTitleLB.AutoSize = true;
            this.RegisterTitleLB.BackColor = System.Drawing.Color.Transparent;
            this.RegisterTitleLB.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterTitleLB.Location = new System.Drawing.Point(151, 42);
            this.RegisterTitleLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RegisterTitleLB.Name = "RegisterTitleLB";
            this.RegisterTitleLB.Size = new System.Drawing.Size(692, 79);
            this.RegisterTitleLB.TabIndex = 2;
            this.RegisterTitleLB.Text = "Welcome to Long\'s ATM";
            this.RegisterTitleLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegisterIntroTextBox
            // 
            this.RegisterIntroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterIntroTextBox.Location = new System.Drawing.Point(300, 147);
            this.RegisterIntroTextBox.Multiline = true;
            this.RegisterIntroTextBox.Name = "RegisterIntroTextBox";
            this.RegisterIntroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.RegisterIntroTextBox.Size = new System.Drawing.Size(361, 71);
            this.RegisterIntroTextBox.TabIndex = 3;
            this.RegisterIntroTextBox.Text = "Thank you for your interest in our banking service. To register, please fill out " +
    "the information below.";
            this.RegisterIntroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RegisterIntroTextBox.TextChanged += new System.EventHandler(this.RegisterIntroTextBox_TextChanged);
            // 
            // RegisterSubmitBTN
            // 
            this.RegisterSubmitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegisterSubmitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterSubmitBTN.Location = new System.Drawing.Point(430, 445);
            this.RegisterSubmitBTN.Name = "RegisterSubmitBTN";
            this.RegisterSubmitBTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RegisterSubmitBTN.Size = new System.Drawing.Size(97, 31);
            this.RegisterSubmitBTN.TabIndex = 4;
            this.RegisterSubmitBTN.Text = "Submit";
            this.RegisterSubmitBTN.UseVisualStyleBackColor = false;
            this.RegisterSubmitBTN.Click += new System.EventHandler(this.RegisterSubmitBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(587, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 290);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Checking",
            "Saving",
            "Both"});
            this.comboBox1.Location = new System.Drawing.Point(414, 381);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberLabel.Location = new System.Drawing.Point(160, 245);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(257, 27);
            this.CardNumberLabel.TabIndex = 8;
            this.CardNumberLabel.Text = "Enter in your First Name:";
            this.CardNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter in your Last Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 330);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(180, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type of Account:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(959, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RegisterSubmitBTN);
            this.Controls.Add(this.RegisterIntroTextBox);
            this.Controls.Add(this.RegisterTitleLB);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegisterTitleLB;
        private System.Windows.Forms.TextBox RegisterIntroTextBox;
        private System.Windows.Forms.Button RegisterSubmitBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}