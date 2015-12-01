namespace MIS220GroupProject
{
    partial class MemberHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.accBalBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toMovieList_BTN = new System.Windows.Forms.Button();
            this.toAcctInfoScreen_BTN = new System.Windows.Forms.Button();
            this.toWishlist_BTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toPaymentScreen_BTN = new System.Windows.Forms.Button();
            this.toRewardScreen_BTN = new System.Windows.Forms.Button();
            this.memNameBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, ";
            // 
            // accBalBox
            // 
            this.accBalBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.accBalBox.Font = new System.Drawing.Font("Segoe WP", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBalBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.accBalBox.Location = new System.Drawing.Point(330, 25);
            this.accBalBox.Name = "accBalBox";
            this.accBalBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.accBalBox.Size = new System.Drawing.Size(149, 76);
            this.accBalBox.TabIndex = 1;
            this.accBalBox.Text = "25.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Balance";
            // 
            // toMovieList_BTN
            // 
            this.toMovieList_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMovieList_BTN.Location = new System.Drawing.Point(12, 354);
            this.toMovieList_BTN.Name = "toMovieList_BTN";
            this.toMovieList_BTN.Size = new System.Drawing.Size(206, 73);
            this.toMovieList_BTN.TabIndex = 3;
            this.toMovieList_BTN.Text = "View and Order Movies!";
            this.toMovieList_BTN.UseVisualStyleBackColor = true;
            this.toMovieList_BTN.Click += new System.EventHandler(this.toMovieList_BTN_Click);
            // 
            // toAcctInfoScreen_BTN
            // 
            this.toAcctInfoScreen_BTN.Location = new System.Drawing.Point(29, 74);
            this.toAcctInfoScreen_BTN.Name = "toAcctInfoScreen_BTN";
            this.toAcctInfoScreen_BTN.Size = new System.Drawing.Size(102, 23);
            this.toAcctInfoScreen_BTN.TabIndex = 4;
            this.toAcctInfoScreen_BTN.Text = "Account Info";
            this.toAcctInfoScreen_BTN.UseVisualStyleBackColor = true;
            this.toAcctInfoScreen_BTN.Click += new System.EventHandler(this.toAcctInfoScreen_BTN_Click);
            // 
            // toWishlist_BTN
            // 
            this.toWishlist_BTN.Location = new System.Drawing.Point(239, 354);
            this.toWishlist_BTN.Name = "toWishlist_BTN";
            this.toWishlist_BTN.Size = new System.Drawing.Size(102, 32);
            this.toWishlist_BTN.TabIndex = 5;
            this.toWishlist_BTN.Text = "See Wishlist";
            this.toWishlist_BTN.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Top Three Movies: ";
            // 
            // toPaymentScreen_BTN
            // 
            this.toPaymentScreen_BTN.Location = new System.Drawing.Point(151, 73);
            this.toPaymentScreen_BTN.Name = "toPaymentScreen_BTN";
            this.toPaymentScreen_BTN.Size = new System.Drawing.Size(112, 23);
            this.toPaymentScreen_BTN.TabIndex = 7;
            this.toPaymentScreen_BTN.Text = "Make a Payment";
            this.toPaymentScreen_BTN.UseVisualStyleBackColor = true;
            // 
            // toRewardScreen_BTN
            // 
            this.toRewardScreen_BTN.Location = new System.Drawing.Point(239, 392);
            this.toRewardScreen_BTN.Name = "toRewardScreen_BTN";
            this.toRewardScreen_BTN.Size = new System.Drawing.Size(102, 35);
            this.toRewardScreen_BTN.TabIndex = 8;
            this.toRewardScreen_BTN.Text = "See Rewards";
            this.toRewardScreen_BTN.UseVisualStyleBackColor = true;
            // 
            // memNameBox
            // 
            this.memNameBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memNameBox.Font = new System.Drawing.Font("Segoe WP", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memNameBox.Location = new System.Drawing.Point(69, 25);
            this.memNameBox.Name = "memNameBox";
            this.memNameBox.Size = new System.Drawing.Size(130, 31);
            this.memNameBox.TabIndex = 9;
            this.memNameBox.Text = "User Name";
            // 
            // MemberHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 443);
            this.Controls.Add(this.memNameBox);
            this.Controls.Add(this.toRewardScreen_BTN);
            this.Controls.Add(this.toPaymentScreen_BTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toWishlist_BTN);
            this.Controls.Add(this.toAcctInfoScreen_BTN);
            this.Controls.Add(this.toMovieList_BTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accBalBox);
            this.Controls.Add(this.label1);
            this.Name = "MemberHome";
            this.Text = "MemberHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox accBalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toMovieList_BTN;
        private System.Windows.Forms.Button toAcctInfoScreen_BTN;
        private System.Windows.Forms.Button toWishlist_BTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toPaymentScreen_BTN;
        private System.Windows.Forms.Button toRewardScreen_BTN;
        private System.Windows.Forms.RichTextBox memNameBox;
    }
}