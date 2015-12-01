namespace MIS220GroupProject
{
    partial class WishList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkOut_BTN = new System.Windows.Forms.Button();
            this.removeWishList_BTN = new System.Windows.Forms.Button();
            this.returnTo_BOX = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkOut_BTN
            // 
            this.checkOut_BTN.Location = new System.Drawing.Point(307, 252);
            this.checkOut_BTN.Name = "checkOut_BTN";
            this.checkOut_BTN.Size = new System.Drawing.Size(158, 77);
            this.checkOut_BTN.TabIndex = 3;
            this.checkOut_BTN.Text = "Rent or Buy Movie";
            this.checkOut_BTN.UseVisualStyleBackColor = true;
            this.checkOut_BTN.Click += new System.EventHandler(this.checkOut_BTN_Click);
            // 
            // removeWishList_BTN
            // 
            this.removeWishList_BTN.Location = new System.Drawing.Point(97, 252);
            this.removeWishList_BTN.Name = "removeWishList_BTN";
            this.removeWishList_BTN.Size = new System.Drawing.Size(158, 77);
            this.removeWishList_BTN.TabIndex = 4;
            this.removeWishList_BTN.Text = "Remove from Wish List";
            this.removeWishList_BTN.UseVisualStyleBackColor = true;
            this.removeWishList_BTN.Click += new System.EventHandler(this.removeWishList_BTN_Click);
            // 
            // returnTo_BOX
            // 
            this.returnTo_BOX.FormattingEnabled = true;
            this.returnTo_BOX.Items.AddRange(new object[] {
            "Home Page",
            "Movie List",
            "Account Information"});
            this.returnTo_BOX.Location = new System.Drawing.Point(534, 279);
            this.returnTo_BOX.Name = "returnTo_BOX";
            this.returnTo_BOX.Size = new System.Drawing.Size(121, 24);
            this.returnTo_BOX.TabIndex = 5;
            this.returnTo_BOX.Text = "Return To:";
            this.returnTo_BOX.SelectedIndexChanged += new System.EventHandler(this.returnTo_BOX_SelectedIndexChanged);
            // 
            // WishList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 419);
            this.Controls.Add(this.returnTo_BOX);
            this.Controls.Add(this.removeWishList_BTN);
            this.Controls.Add(this.checkOut_BTN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WishList";
            this.Text = "WishList";
            this.Load += new System.EventHandler(this.WishList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button checkOut_BTN;
        private System.Windows.Forms.Button removeWishList_BTN;
        private System.Windows.Forms.ComboBox returnTo_BOX;
    }
}