namespace MIS220GroupProject
{
    partial class CheckOut
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
            this.yes_BTN = new System.Windows.Forms.Button();
            this.no_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.movieName_TXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // yes_BTN
            // 
            this.yes_BTN.Location = new System.Drawing.Point(149, 165);
            this.yes_BTN.Name = "yes_BTN";
            this.yes_BTN.Size = new System.Drawing.Size(75, 23);
            this.yes_BTN.TabIndex = 0;
            this.yes_BTN.Text = "Yes";
            this.yes_BTN.UseVisualStyleBackColor = true;
            // 
            // no_BTN
            // 
            this.no_BTN.Location = new System.Drawing.Point(39, 165);
            this.no_BTN.Name = "no_BTN";
            this.no_BTN.Size = new System.Drawing.Size(75, 23);
            this.no_BTN.TabIndex = 1;
            this.no_BTN.Text = "No";
            this.no_BTN.UseVisualStyleBackColor = true;
            this.no_BTN.Click += new System.EventHandler(this.no_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure you\'d like to rent the following:";
            // 
            // movieName_TXT
            // 
            this.movieName_TXT.Location = new System.Drawing.Point(12, 77);
            this.movieName_TXT.Name = "movieName_TXT";
            this.movieName_TXT.ReadOnly = true;
            this.movieName_TXT.Size = new System.Drawing.Size(243, 22);
            this.movieName_TXT.TabIndex = 3;
            this.movieName_TXT.TabStop = false;
            this.movieName_TXT.TextChanged += new System.EventHandler(this.movieName_TXT_TextChanged);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.movieName_TXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.no_BTN);
            this.Controls.Add(this.yes_BTN);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yes_BTN;
        private System.Windows.Forms.Button no_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movieName_TXT;
    }
}