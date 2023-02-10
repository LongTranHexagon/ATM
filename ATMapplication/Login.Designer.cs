namespace ATMapplication
{
    partial class Login
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
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.CardNumberSubmitBTN = new System.Windows.Forms.Button();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.PINLabel = new System.Windows.Forms.Label();
            this.PINtext = new System.Windows.Forms.TextBox();
            this.Cardtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(151, 42);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(692, 79);
            this.Title.TabIndex = 1;
            this.Title.Text = "Welcome to Long\'s ATM";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberLabel.Location = new System.Drawing.Point(160, 179);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(265, 27);
            this.CardNumberLabel.TabIndex = 4;
            this.CardNumberLabel.Text = "Select your Card Number:";
            this.CardNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardNumberSubmitBTN
            // 
            this.CardNumberSubmitBTN.BackColor = System.Drawing.Color.LawnGreen;
            this.CardNumberSubmitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberSubmitBTN.Location = new System.Drawing.Point(440, 282);
            this.CardNumberSubmitBTN.Name = "CardNumberSubmitBTN";
            this.CardNumberSubmitBTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CardNumberSubmitBTN.Size = new System.Drawing.Size(114, 36);
            this.CardNumberSubmitBTN.TabIndex = 8;
            this.CardNumberSubmitBTN.Text = "Submit";
            this.CardNumberSubmitBTN.UseVisualStyleBackColor = false;
            this.CardNumberSubmitBTN.Click += new System.EventHandler(this.CardNumberSubmitBTN_Click);
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegisterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBTN.Location = new System.Drawing.Point(416, 351);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(162, 46);
            this.RegisterBTN.TabIndex = 9;
            this.RegisterBTN.Text = "Register";
            this.RegisterBTN.UseVisualStyleBackColor = false;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // PINLabel
            // 
            this.PINLabel.AutoSize = true;
            this.PINLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINLabel.Location = new System.Drawing.Point(582, 179);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(188, 27);
            this.PINLabel.TabIndex = 10;
            this.PINLabel.Text = "Enter in your PIN:";
            this.PINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PINtext
            // 
            this.PINtext.Location = new System.Drawing.Point(621, 233);
            this.PINtext.Name = "PINtext";
            this.PINtext.PasswordChar = '*';
            this.PINtext.Size = new System.Drawing.Size(106, 20);
            this.PINtext.TabIndex = 11;
            // 
            // Cardtext
            // 
            this.Cardtext.Location = new System.Drawing.Point(193, 233);
            this.Cardtext.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Cardtext.Name = "Cardtext";
            this.Cardtext.PasswordChar = '*';
            this.Cardtext.Size = new System.Drawing.Size(186, 20);
            this.Cardtext.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(959, 521);
            this.Controls.Add(this.Cardtext);
            this.Controls.Add(this.PINtext);
            this.Controls.Add(this.PINLabel);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.CardNumberSubmitBTN);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.Title);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainTitle";
            this.Load += new System.EventHandler(this.MainTitle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.Button CardNumberSubmitBTN;
        private System.Windows.Forms.Button RegisterBTN;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.TextBox PINtext;
        private System.Windows.Forms.TextBox Cardtext;
    }
}