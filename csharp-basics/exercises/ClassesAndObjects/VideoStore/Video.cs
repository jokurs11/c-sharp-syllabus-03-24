using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    public class Video
    {
        private bool _checkedOut { get; set; }

        private List<double> _ratings { get; set; }

        public Video(string title)
        {
            Title = title;
            _checkedOut = false;
            _ratings = new List<double>();
        }

        public string Title { get; private set; }

        public void CheckOut()
        {
            _checkedOut = true;
        }

        public void Return()
        {
            _checkedOut = false;
        }

        public void ReceiveRating(double rating)
        {
            _ratings.Add(rating);
        }

        public double AverageRating()
        {
            return _ratings.Average();
        }
    }
}