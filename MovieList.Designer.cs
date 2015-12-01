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
            this.components = new System.ComponentModel.Container();
            this.wishList_BTN = new System.Windows.Forms.Button();
            this.checkOut_BTN = new System.Windows.Forms.Button();
            this.returnTo_BOX = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysForRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieRentalDataSet = new MIS220GroupProject.MovieRentalDataSet();
            this.movieTableAdapter = new MIS220GroupProject.MovieRentalDataSetTableAdapters.MovieTableAdapter();
            this.sortBy_DropBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // wishList_BTN
            // 
            this.wishList_BTN.Location = new System.Drawing.Point(233, 276);
            this.wishList_BTN.Name = "wishList_BTN";
            this.wishList_BTN.Size = new System.Drawing.Size(158, 77);
            this.wishList_BTN.TabIndex = 1;
            this.wishList_BTN.Text = "Add to Wish List";
            this.wishList_BTN.UseVisualStyleBackColor = true;
            this.wishList_BTN.Click += new System.EventHandler(this.wishList_BTN_Click);
            // 
            // checkOut_BTN
            // 
            this.checkOut_BTN.Location = new System.Drawing.Point(446, 276);
            this.checkOut_BTN.Name = "checkOut_BTN";
            this.checkOut_BTN.Size = new System.Drawing.Size(158, 77);
            this.checkOut_BTN.TabIndex = 2;
            this.checkOut_BTN.Text = "Rent or Buy Movie";
            this.checkOut_BTN.UseVisualStyleBackColor = true;
            this.checkOut_BTN.Click += new System.EventHandler(this.checkOut_BTN_Click);
            // 
            // returnTo_BOX
            // 
            this.returnTo_BOX.FormattingEnabled = true;
            this.returnTo_BOX.Items.AddRange(new object[] {
            "Home Page",
            "Wish List",
            "Account Information"});
            this.returnTo_BOX.Location = new System.Drawing.Point(664, 303);
            this.returnTo_BOX.Name = "returnTo_BOX";
            this.returnTo_BOX.Size = new System.Drawing.Size(121, 24);
            this.returnTo_BOX.TabIndex = 3;
            this.returnTo_BOX.Text = "Return To:";
            this.returnTo_BOX.SelectedIndexChanged += new System.EventHandler(this.returnTo_BOX_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.runTimeDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.daysForRentDataGridViewTextBoxColumn,
            this.rentalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.movieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 213);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            // 
            // runTimeDataGridViewTextBoxColumn
            // 
            this.runTimeDataGridViewTextBoxColumn.DataPropertyName = "RunTime";
            this.runTimeDataGridViewTextBoxColumn.HeaderText = "RunTime";
            this.runTimeDataGridViewTextBoxColumn.Name = "runTimeDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // daysForRentDataGridViewTextBoxColumn
            // 
            this.daysForRentDataGridViewTextBoxColumn.DataPropertyName = "DaysForRent";
            this.daysForRentDataGridViewTextBoxColumn.HeaderText = "DaysForRent";
            this.daysForRentDataGridViewTextBoxColumn.Name = "daysForRentDataGridViewTextBoxColumn";
            // 
            // rentalPriceDataGridViewTextBoxColumn
            // 
            this.rentalPriceDataGridViewTextBoxColumn.DataPropertyName = "RentalPrice";
            this.rentalPriceDataGridViewTextBoxColumn.HeaderText = "RentalPrice";
            this.rentalPriceDataGridViewTextBoxColumn.Name = "rentalPriceDataGridViewTextBoxColumn";
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.movieRentalDataSet;
            // 
            // movieRentalDataSet
            // 
            this.movieRentalDataSet.DataSetName = "MovieRentalDataSet";
            this.movieRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // sortBy_DropBox
            // 
            this.sortBy_DropBox.FormattingEnabled = true;
            this.sortBy_DropBox.Items.AddRange(new object[] {
            "Genre",
            "Alphabetical"});
            this.sortBy_DropBox.Location = new System.Drawing.Point(901, -3);
            this.sortBy_DropBox.Name = "sortBy_DropBox";
            this.sortBy_DropBox.Size = new System.Drawing.Size(121, 24);
            this.sortBy_DropBox.TabIndex = 5;
            this.sortBy_DropBox.Text = "Sort By:";
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 418);
            this.Controls.Add(this.sortBy_DropBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.returnTo_BOX);
            this.Controls.Add(this.checkOut_BTN);
            this.Controls.Add(this.wishList_BTN);
            this.Name = "MovieList";
            this.Text = "MovieList";
            this.Load += new System.EventHandler(this.MovieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button wishList_BTN;
        private System.Windows.Forms.Button checkOut_BTN;
        private System.Windows.Forms.ComboBox returnTo_BOX;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MovieRentalDataSet movieRentalDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private MovieRentalDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysForRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox sortBy_DropBox;
    }
}