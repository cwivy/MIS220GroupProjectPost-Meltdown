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
            this.movieListDataGrid = new System.Windows.Forms.DataGridView();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieRentalDataSet = new MIS220GroupProject.MovieRentalDataSet();
            this.movieTableAdapter = new MIS220GroupProject.MovieRentalDataSetTableAdapters.MovieTableAdapter();
            this.sortBy_DropBox = new System.Windows.Forms.ComboBox();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysForRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.movieListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // wishList_BTN
            // 
            this.wishList_BTN.Location = new System.Drawing.Point(25, 235);
            this.wishList_BTN.Margin = new System.Windows.Forms.Padding(2);
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
            this.checkOut_BTN.Margin = new System.Windows.Forms.Padding(2);
            this.checkOut_BTN.Name = "checkOut_BTN";
            this.checkOut_BTN.Size = new System.Drawing.Size(118, 63);
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
            this.returnTo_BOX.Location = new System.Drawing.Point(683, 11);
            this.returnTo_BOX.Margin = new System.Windows.Forms.Padding(2);
            this.returnTo_BOX.Name = "returnTo_BOX";
            this.returnTo_BOX.Size = new System.Drawing.Size(92, 21);
            this.returnTo_BOX.TabIndex = 3;
            this.returnTo_BOX.Text = "Return To:";
            this.returnTo_BOX.SelectedIndexChanged += new System.EventHandler(this.returnTo_BOX_SelectedIndexChanged);
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
            this.movieListDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.movieListDataGrid.MultiSelect = false;
            this.movieListDataGrid.Name = "movieListDataGrid";
            this.movieListDataGrid.ReadOnly = true;
            this.movieListDataGrid.RowTemplate.Height = 24;
            this.movieListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movieListDataGrid.Size = new System.Drawing.Size(764, 173);
            this.movieListDataGrid.TabIndex = 4;
            this.movieListDataGrid.SelectionChanged += new System.EventHandler(this.movieListDataGrid_SelectionChanged);
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
            this.sortBy_DropBox.Location = new System.Drawing.Point(323, 257);
            this.sortBy_DropBox.Margin = new System.Windows.Forms.Padding(2);
            this.sortBy_DropBox.Name = "sortBy_DropBox";
            this.sortBy_DropBox.Size = new System.Drawing.Size(92, 21);
            this.sortBy_DropBox.TabIndex = 5;
            this.sortBy_DropBox.Text = "Sort By:";
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
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.sortBy_DropBox);
            this.Controls.Add(this.movieListDataGrid);
            this.Controls.Add(this.returnTo_BOX);
            this.Controls.Add(this.checkOut_BTN);
            this.Controls.Add(this.wishList_BTN);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MovieList";
            this.Text = "MovieList";
            this.Load += new System.EventHandler(this.MovieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button wishList_BTN;
        private System.Windows.Forms.Button checkOut_BTN;
        private System.Windows.Forms.ComboBox returnTo_BOX;
        private System.Windows.Forms.DataGridView movieListDataGrid;
        private MovieRentalDataSet movieRentalDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private MovieRentalDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.ComboBox sortBy_DropBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysForRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalPriceDataGridViewTextBoxColumn;
    }
}