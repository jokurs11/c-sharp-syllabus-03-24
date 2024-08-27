using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _inventory;

        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }

        public Video Checkout(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    video.CheckOut();

                    return video;
                }
            }

            return null;
        }

        public void ReceiveRating(string title, double rating)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    video.ReceiveRating();

                    return;
                }
            }
        }

        public void Return(string title, double rating)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    video.Return();

                    return;
                }
            }
        }
    }
}

