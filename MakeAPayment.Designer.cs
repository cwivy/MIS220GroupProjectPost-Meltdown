namespace MIS220GroupProject
{
    partial class MakeAPayment
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
            this.label3 = new System.Windows.Forms.Label();
            this.accBalBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.makeAPaymentBox = new System.Windows.Forms.TextBox();
            this.submitButt = new System.Windows.Forms.Button();
            this.clearButt = new System.Windows.Forms.Button();
            this.goBackButt = new System.Windows.Forms.Button();
            this.radioPaymentButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Balance";
            // 
            // accBalBox2
            // 
            this.accBalBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.accBalBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBalBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.accBalBox2.Location = new System.Drawing.Point(282, 29);
            this.accBalBox2.Name = "accBalBox2";
            this.accBalBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.accBalBox2.Size = new System.Drawing.Size(149, 76);
            this.accBalBox2.TabIndex = 3;
            this.accBalBox2.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Make A Payment:";
            // 
            // makeAPaymentBox
            // 
            this.makeAPaymentBox.Location = new System.Drawing.Point(140, 46);
            this.makeAPaymentBox.Name = "makeAPaymentBox";
            this.makeAPaymentBox.Size = new System.Drawing.Size(114, 20);
            this.makeAPaymentBox.TabIndex = 8;
            this.makeAPaymentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submitButt
            // 
            this.submitButt.Location = new System.Drawing.Point(46, 131);
            this.submitButt.Name = "submitButt";
            this.submitButt.Size = new System.Drawing.Size(109, 23);
            this.submitButt.TabIndex = 9;
            this.submitButt.Text = "Submit Payment";
            this.submitButt.UseVisualStyleBackColor = true;
            this.submitButt.Click += new System.EventHandler(this.submitButt_Click);
            // 
            // clearButt
            // 
            this.clearButt.Location = new System.Drawing.Point(165, 131);
            this.clearButt.Name = "clearButt";
            this.clearButt.Size = new System.Drawing.Size(109, 23);
            this.clearButt.TabIndex = 10;
            this.clearButt.Text = "Clear";
            this.clearButt.UseVisualStyleBackColor = true;
            this.clearButt.Click += new System.EventHandler(this.clearButt_Click);
            // 
            // goBackButt
            // 
            this.goBackButt.Location = new System.Drawing.Point(280, 131);
            this.goBackButt.Name = "goBackButt";
            this.goBackButt.Size = new System.Drawing.Size(109, 23);
            this.goBackButt.TabIndex = 11;
            this.goBackButt.Text = "Go Back";
            this.goBackButt.UseVisualStyleBackColor = true;
            // 
            // radioPaymentButton
            // 
            this.radioPaymentButton.AutoSize = true;
            this.radioPaymentButton.Location = new System.Drawing.Point(23, 49);
            this.radioPaymentButton.Name = "radioPaymentButton";
            this.radioPaymentButton.Size = new System.Drawing.Size(14, 13);
            this.radioPaymentButton.TabIndex = 12;
            this.radioPaymentButton.TabStop = true;
            this.radioPaymentButton.UseVisualStyleBackColor = true;
            // 
            // MakeAPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 189);
            this.Controls.Add(this.radioPaymentButton);
            this.Controls.Add(this.goBackButt);
            this.Controls.Add(this.clearButt);
            this.Controls.Add(this.submitButt);
            this.Controls.Add(this.makeAPaymentBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accBalBox2);
            this.Name = "MakeAPayment";
            this.Text = "MakeAPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox accBalBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox makeAPaymentBox;
        private System.Windows.Forms.Button submitButt;
        private System.Windows.Forms.Button clearButt;
        private System.Windows.Forms.Button goBackButt;
        private System.Windows.Forms.RadioButton radioPaymentButton;
    }
}