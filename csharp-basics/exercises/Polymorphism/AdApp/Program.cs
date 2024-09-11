using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var c = new Campaign();
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500, 7, 200, true));
            c.AddAdvert(new NewspaperAd(10, 30, 20));
            c.AddAdvert(new TVAd(560, true, 1, 300));
            c.AddAdvert(new Poster(4, 100, 1, 100));
            Console.WriteLine(c);
        }
    }
}