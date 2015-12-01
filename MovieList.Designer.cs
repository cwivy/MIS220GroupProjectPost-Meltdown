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
            this.movieListDataGrid = new System.Windows.Forms.DataGridView();
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
            this.sortByGenre_DropBox = new System.Windows.Forms.ComboBox();
            this.movieRentalDataSet1 = new MIS220GroupProject.MovieRentalDataSet();
            this.backToHome_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // wishList_BTN
            // 
            this.wishList_BTN.Location = new System.Drawing.Point(25, 235);
            this.wishList_BTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wishList_BTN.Name = "wishList_BTN";
            this.wishList_BTN.Size = new System.Drawing.Size(118, 63);
            this.wishList_BTN.TabIndex = 1;
            this.wishList_BTN.Text = "Add to Wish List";
            this.wishList_BTN.UseVisualStyleBackColor = true;
            this.wishList_BTN.Click += new System.EventHandler(this.wishList_BTN_Click);
            // 
            // checkOut_BTN
            // 
            this.checkOut_BTN.Location = new System.Drawing.Point(175, 235);
            this.checkOut_BTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkOut_BTN.Name = "checkOut_BTN";
            this.checkOut_BTN.Size = new System.Drawing.Size(118, 63);
            this.checkOut_BTN.TabIndex = 2;
            this.checkOut_BTN.Text = "Rent or Buy Movie";
            this.checkOut_BTN.UseVisualStyleBackColor = true;
            this.checkOut_BTN.Click += new System.EventHandler(this.checkOut_BTN_Click);
            // 
            // movieListDataGrid
            // 
            this.movieListDataGrid.AllowUserToAddRows = false;
            this.movieListDataGrid.AllowUserToDeleteRows = false;
            this.movieListDataGrid.AllowUserToOrderColumns = true;
            this.movieListDataGrid.AllowUserToResizeColumns = false;
            this.movieListDataGrid.AllowUserToResizeRows = false;
            this.movieListDataGrid.AutoGenerateColumns = false;
            this.movieListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.runTimeDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.daysForRentDataGridViewTextBoxColumn,
            this.rentalPriceDataGridViewTextBoxColumn});
            this.movieListDataGrid.DataSource = this.movieBindingSource;
            this.movieListDataGrid.Location = new System.Drawing.Point(11, 47);
            this.movieListDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.movieListDataGrid.MultiSelect = false;
            this.movieListDataGrid.Name = "movieListDataGrid";
            this.movieListDataGrid.ReadOnly = true;
            this.movieListDataGrid.RowTemplate.Height = 24;
            this.movieListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movieListDataGrid.Size = new System.Drawing.Size(764, 173);
            this.movieListDataGrid.TabIndex = 4;
            this.movieListDataGrid.SelectionChanged += new System.EventHandler(this.movieListDataGrid_SelectionChanged);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // runTimeDataGridViewTextBoxColumn
            // 
            this.runTimeDataGridViewTextBoxColumn.DataPropertyName = "RunTime";
            this.runTimeDataGridViewTextBoxColumn.HeaderText = "RunTime";
            this.runTimeDataGridViewTextBoxColumn.Name = "runTimeDataGridViewTextBoxColumn";
            this.runTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // daysForRentDataGridViewTextBoxColumn
            // 
            this.daysForRentDataGridViewTextBoxColumn.DataPropertyName = "DaysForRent";
            this.daysForRentDataGridViewTextBoxColumn.HeaderText = "DaysForRent";
            this.daysForRentDataGridViewTextBoxColumn.Name = "daysForRentDataGridViewTextBoxColumn";
            this.daysForRentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentalPriceDataGridViewTextBoxColumn
            // 
            this.rentalPriceDataGridViewTextBoxColumn.DataPropertyName = "RentalPrice";
            this.rentalPriceDataGridViewTextBoxColumn.HeaderText = "RentalPrice";
            this.rentalPriceDataGridViewTextBoxColumn.Name = "rentalPriceDataGridViewTextBoxColumn";
            this.rentalPriceDataGridViewTextBoxColumn.ReadOnly = true;
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
            // sortByGenre_DropBox
            // 
            this.sortByGenre_DropBox.FormattingEnabled = true;
            this.sortByGenre_DropBox.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Romance",
            "Romantic-Comedy",
            "Scifi",
            "Thriller"});
            this.sortByGenre_DropBox.Location = new System.Drawing.Point(323, 257);
            this.sortByGenre_DropBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortByGenre_DropBox.Name = "sortByGenre_DropBox";
            this.sortByGenre_DropBox.Size = new System.Drawing.Size(92, 21);
            this.sortByGenre_DropBox.Sorted = true;
            this.sortByGenre_DropBox.TabIndex = 5;
            this.sortByGenre_DropBox.Text = "Sort By Genre:";
            this.sortByGenre_DropBox.SelectedIndexChanged += new System.EventHandler(this.sortBy_DropBox_SelectedIndexChanged);
            // 
            // movieRentalDataSet1
            // 
            this.movieRentalDataSet1.DataSetName = "MovieRentalDataSet";
            this.movieRentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backToHome_BTN
            // 
            this.backToHome_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToHome_BTN.Location = new System.Drawing.Point(25, 9);
            this.backToHome_BTN.Name = "backToHome_BTN";
            this.backToHome_BTN.Size = new System.Drawing.Size(62, 23);
            this.backToHome_BTN.TabIndex = 65;
            this.backToHome_BTN.Text = "<-- Home";
            this.backToHome_BTN.UseVisualStyleBackColor = true;
            this.backToHome_BTN.Click += new System.EventHandler(this.backToHome_BTN_Click);
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.backToHome_BTN);
            this.Controls.Add(this.sortByGenre_DropBox);
            this.Controls.Add(this.movieListDataGrid);
            this.Controls.Add(this.checkOut_BTN);
            this.Controls.Add(this.wishList_BTN);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MovieList";
            this.Text = "MovieList";
            this.Load += new System.EventHandler(this.MovieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button wishList_BTN;
        private System.Windows.Forms.Button checkOut_BTN;
        private System.Windows.Forms.DataGridView movieListDataGrid;
        private MovieRentalDataSet movieRentalDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private MovieRentalDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.ComboBox sortByGenre_DropBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysForRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalPriceDataGridViewTextBoxColumn;
        private MovieRentalDataSet movieRentalDataSet1;
        private System.Windows.Forms.Button backToHome_BTN;
    }
}