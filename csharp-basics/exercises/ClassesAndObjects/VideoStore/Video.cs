using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        public string Title {get; private set; }

    private bool _checkedOut {get; set; }

        private List<double> _ratings { get; set; }

        public double AverageRating => _ratings.Average();

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
    }
}
