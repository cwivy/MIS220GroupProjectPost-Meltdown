namespace MIS220GroupProject
{
    partial class MovieList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.wishList_BTN = new System.Windows.Forms.Button();
            this.checkOut_BTN = new System.Windows.Forms.Button();
            this.returnTo_BOX = new System.Windows.Forms.ComboBox();
            this.sortBy_BOX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(549, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // wishList_BTN
            // 
            this.wishList_BTN.Location = new System.Drawing.Point(13, 309);
            this.wishList_BTN.Name = "wishList_BTN";
            this.wishList_BTN.Size = new System.Drawing.Size(158, 77);
            this.wishList_BTN.TabIndex = 1;
            this.wishList_BTN.Text = "Add to Wish List";
            this.wishList_BTN.UseVisualStyleBackColor = true;
            // 
            // checkOut_BTN
            // 
            this.checkOut_BTN.Location = new System.Drawing.Point(226, 309);
            this.checkOut_BTN.Name = "checkOut_BTN";
            this.checkOut_BTN.Size = new System.Drawing.Size(158, 77);
            this.checkOut_BTN.TabIndex = 2;
            this.checkOut_BTN.Text = "Rent or Buy Movie";
            this.checkOut_BTN.UseVisualStyleBackColor = true;
            // 
            // returnTo_BOX
            // 
            this.returnTo_BOX.FormattingEnabled = true;
            this.returnTo_BOX.Items.AddRange(new object[] {
            "Home Page",
            "Wish List",
            "Account Information"});
            this.returnTo_BOX.Location = new System.Drawing.Point(440, 309);
            this.returnTo_BOX.Name = "returnTo_BOX";
            this.returnTo_BOX.Size = new System.Drawing.Size(121, 24);
            this.returnTo_BOX.TabIndex = 3;
            this.returnTo_BOX.Text = "Return To:";
            // 
            // sortBy_BOX
            // 
            this.sortBy_BOX.FormattingEnabled = true;
            this.sortBy_BOX.Items.AddRange(new object[] {
            "Genre",
            "Alphabetical"});
            this.sortBy_BOX.Location = new System.Drawing.Point(440, 24);
            this.sortBy_BOX.Name = "sortBy_BOX";
            this.sortBy_BOX.Size = new System.Drawing.Size(121, 24);
            this.sortBy_BOX.TabIndex = 4;
            this.sortBy_BOX.Text = "Sort By:";
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 423);
            this.Controls.Add(this.sortBy_BOX);
            this.Controls.Add(this.returnTo_BOX);
            this.Controls.Add(this.checkOut_BTN);
            this.Controls.Add(this.wishList_BTN);
            this.Controls.Add(this.listBox1);
            this.Name = "MovieList";
            this.Text = "MovieList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button wishList_BTN;
        private System.Windows.Forms.Button checkOut_BTN;
        private System.Windows.Forms.ComboBox returnTo_BOX;
        private System.Windows.Forms.ComboBox sortBy_BOX;
    }
}