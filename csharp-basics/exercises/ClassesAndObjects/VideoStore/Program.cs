using System;

namespace VideoStore
{

    class Program
    {
        private static readonly VideoStore _store = new VideoStore();

        public static void Main(string[] args)
        {
            VideoStore _store = new VideoStore();

            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");
                Console.WriteLine("Choose 5 to give rating");
                Console.WriteLine("Choose 6 to check rating");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    case 5:
                        GiveRating();
                        break;
                    case 6:
                        AverageRating();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void GiveRating()
        {
            Console.WriteLine("enter the title of the video you want to rate");
            var title = Console.ReadLine();
            Console.WriteLine("enter the rating for the video.");
            var rating = double.Parse(Console.ReadLine());

            _store.ReceiveRating(title, rating);
        }

        private static void AverageRating()
        {
            Console.WriteLine("enter the title of the video you want to check");
            var title = Console.ReadLine();

            double? averageRating = _store.AverageRating(title);
            Console.WriteLine($"the rating is {averageRating:0.0}");
        }

        private static void ListInventory()
        {
            var inventory = _store.ListInventory();

            foreach (var video in inventory)
            {
                Console.WriteLine(video.Title);
            }
        }

        private static void FillVideoStore()
        {
            _store.AddVideo("The Matrix");
            _store.AddVideo("Godfather II");
            _store.AddVideo("Star Wars Episode IV: A New Hope");
        }

        private static void RentVideo()
        {
            Console.WriteLine("enter the name of the video");
            var title = Console.ReadLine();
            var video = _store.CheckOut(title);

            if (video == null)
            {
                Console.WriteLine($"video with the {title} was not found");
            }
            else
            {
                Console.WriteLine($"video with the {title} is checked out");
            }
        }

        private static void ReturnVideo()
        {
            Console.WriteLine("enter the name of the video you want to return");
            var title = Console.ReadLine();
            _store.Return(title);
        }
    }
}
