using System;

namespace Exercise4
{
    internal class Movie
    {
        public string _title;
        public string _studio;
        private string _rating;

        public Movie(string aTitle, string aStudio, string aRating)
        {
            _title = aTitle;
            _studio = aStudio;
            GetPG = aRating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public string GetPG
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value == "PG")
                {
                    _rating = value;
                }
            }
        }
    }
}