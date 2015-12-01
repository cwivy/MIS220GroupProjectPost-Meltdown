using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS220GroupProject
{
    class Movie
    {
        //-------Members--------
        private int movieID;
        private string title;
        private string genre;
        private DateTime releaseDate;
        private double runtime;
        private double rating;
        private DateTime dateForRent;
        private double rentalPrice;

        //----------Properties----------
        public DateTime DateForRent
        {
            get { return dateForRent; }
            set { dateForRent = value; }
        }

        public int MovieID
        {
            get { return movieID; }
            set { movieID = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public double Runtime
        {
            get { return runtime; }
            set { runtime = value; }
        }
        public double RentalPrice
        {
            get { return rentalPrice; }
            set { rentalPrice = value; }
        }
    }
}
