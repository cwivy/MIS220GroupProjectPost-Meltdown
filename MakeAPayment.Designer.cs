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
            this.submitButt = new System.Windows.Forms.Button();
            this.backToHome_BTN = new System.Windows.Forms.Button();
            this.paymentUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.paymentUpDown)).BeginInit();
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
            this.accBalBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Make A Payment:";
            // 
            // submitButt
            // 
            this.submitButt.Location = new System.Drawing.Point(155, 89);
            this.submitButt.Name = "submitButt";
            this.submitButt.Size = new System.Drawing.Size(109, 23);
            this.submitButt.TabIndex = 9;
            this.submitButt.Text = "Submit Payment";
            this.submitButt.UseVisualStyleBackColor = true;
            this.submitButt.Click += new System.EventHandler(this.submitButt_Click);
            // 
            // backToHome_BTN
            // 
            this.backToHome_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToHome_BTN.Location = new System.Drawing.Point(3, 3);
            this.backToHome_BTN.Name = "backToHome_BTN";
            this.backToHome_BTN.Size = new System.Drawing.Size(62, 23);
            this.backToHome_BTN.TabIndex = 65;
            this.backToHome_BTN.Text = "<-- Home";
            this.backToHome_BTN.UseVisualStyleBackColor = true;
            this.backToHome_BTN.Click += new System.EventHandler(this.backToHome_BTN_Click);
            // 
            // paymentUpDown
            // 
            this.paymentUpDown.DecimalPlaces = 2;
            this.paymentUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.paymentUpDown.Location = new System.Drawing.Point(144, 63);
            this.paymentUpDown.Name = "paymentUpDown";
            this.paymentUpDown.Size = new System.Drawing.Size(120, 20);
            this.paymentUpDown.TabIndex = 66;
            // 
            // MakeAPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 137);
            this.Controls.Add(this.paymentUpDown);
            this.Controls.Add(this.backToHome_BTN);
            this.Controls.Add(this.submitButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accBalBox2);
            this.Name = "MakeAPayment";
            this.Text = "MakeAPayment";
            ((System.ComponentModel.ISupportInitialize)(this.paymentUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox accBalBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButt;
        private System.Windows.Forms.Button backToHome_BTN;
        private System.Windows.Forms.NumericUpDown paymentUpDown;
    }
}