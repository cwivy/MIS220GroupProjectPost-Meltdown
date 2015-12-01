namespace MIS220GroupProject
{
    partial class Checkout
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
            this.movieTitle_TXT = new System.Windows.Forms.TextBox();
            this.checkoutConfirm_BTN = new System.Windows.Forms.Button();
            this.checkoutCancel_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentBal_TXT = new System.Windows.Forms.TextBox();
            this.afterBal_TXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "You are about to rent:";
            this.label1.UseWaitCursor = true;
            // 
            // movieTitle_TXT
            // 
            this.movieTitle_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitle_TXT.Location = new System.Drawing.Point(100, 70);
            this.movieTitle_TXT.Margin = new System.Windows.Forms.Padding(4);
            this.movieTitle_TXT.Name = "movieTitle_TXT";
            this.movieTitle_TXT.ReadOnly = true;
            this.movieTitle_TXT.Size = new System.Drawing.Size(263, 23);
            this.movieTitle_TXT.TabIndex = 1;
            this.movieTitle_TXT.Text = "Movie Name Here";
            this.movieTitle_TXT.UseWaitCursor = true;
            // 
            // checkoutConfirm_BTN
            // 
            this.checkoutConfirm_BTN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkoutConfirm_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkoutConfirm_BTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkoutConfirm_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutConfirm_BTN.Location = new System.Drawing.Point(269, 229);
            this.checkoutConfirm_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutConfirm_BTN.Name = "checkoutConfirm_BTN";
            this.checkoutConfirm_BTN.Size = new System.Drawing.Size(125, 44);
            this.checkoutConfirm_BTN.TabIndex = 2;
            this.checkoutConfirm_BTN.Text = "Confirm";
            this.checkoutConfirm_BTN.UseVisualStyleBackColor = false;
            this.checkoutConfirm_BTN.UseWaitCursor = true;
            this.checkoutConfirm_BTN.Click += new System.EventHandler(this.checkoutConfirm_BTN_Click);
            // 
            // checkoutCancel_BTN
            // 
            this.checkoutCancel_BTN.Location = new System.Drawing.Point(77, 238);
            this.checkoutCancel_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutCancel_BTN.Name = "checkoutCancel_BTN";
            this.checkoutCancel_BTN.Size = new System.Drawing.Size(100, 28);
            this.checkoutCancel_BTN.TabIndex = 3;
            this.checkoutCancel_BTN.Text = "Cancel";
            this.checkoutCancel_BTN.UseVisualStyleBackColor = true;
            this.checkoutCancel_BTN.UseWaitCursor = true;
            this.checkoutCancel_BTN.Click += new System.EventHandler(this.checkoutCancel_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Balance:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Balance After Rental:";
            this.label3.UseWaitCursor = true;
            // 
            // currentBal_TXT
            // 
            this.currentBal_TXT.Location = new System.Drawing.Point(196, 135);
            this.currentBal_TXT.Margin = new System.Windows.Forms.Padding(4);
            this.currentBal_TXT.Name = "currentBal_TXT";
            this.currentBal_TXT.ReadOnly = true;
            this.currentBal_TXT.Size = new System.Drawing.Size(132, 22);
            this.currentBal_TXT.TabIndex = 6;
            this.currentBal_TXT.UseWaitCursor = true;
            // 
            // afterBal_TXT
            // 
            this.afterBal_TXT.Location = new System.Drawing.Point(196, 167);
            this.afterBal_TXT.Margin = new System.Windows.Forms.Padding(4);
            this.afterBal_TXT.Name = "afterBal_TXT";
            this.afterBal_TXT.ReadOnly = true;
            this.afterBal_TXT.Size = new System.Drawing.Size(132, 22);
            this.afterBal_TXT.TabIndex = 7;
            this.afterBal_TXT.UseWaitCursor = true;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 324);
            this.Controls.Add(this.afterBal_TXT);
            this.Controls.Add(this.currentBal_TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkoutCancel_BTN);
            this.Controls.Add(this.checkoutConfirm_BTN);
            this.Controls.Add(this.movieTitle_TXT);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movieTitle_TXT;
        private System.Windows.Forms.Button checkoutConfirm_BTN;
        private System.Windows.Forms.Button checkoutCancel_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentBal_TXT;
        private System.Windows.Forms.TextBox afterBal_TXT;
    }
}