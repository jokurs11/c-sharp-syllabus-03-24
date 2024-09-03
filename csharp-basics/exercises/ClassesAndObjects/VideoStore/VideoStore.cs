using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    public class VideoStore
    {
        private readonly List<Video> _inventory;

        public VideoStore()
        {
            _inventory = new List<Video>();
        }
        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }

        public Video CheckOut(string title)
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

        public void Return(string title)
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


        public void ReceiveRating(string title, double rating)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    video.ReceiveRating(rating);
                    return;
                }
            }
        }

        public double? AverageRating(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    return video.AverageRating();
                }
            }

            return null;
        }

        public List<Video> ListInventory()
        {
            return _inventory.ToList();
        }
    }
}