using System;

namespace VideoStore
{

    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");

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
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
            var inventory = _store.ListInvetory()
        }

        private static void FillVideoStore()
        {
            _store.AddVideo("The Matrix");
            _store.AddVideo("Godfather II");
            _store.AddVideo("Star Wars Episode IV: A new Hope");
        }

        private static void RentVideo()
        {
            Console.WriteLine("enter the name of the video");
            var title = Console.ReadLine();
            var video = _store.CheckOut(title);

            if (video = null)
            {
                Console.WriteLine($"vide with the {title} was not found");
            }
            else
            {
                Console.WriteLine($"video with the {title} was found");
            }
        }

        private static void ReturnVideo()
        {

        }
    }
}
