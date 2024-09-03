using System;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args) 
        {
            Movie _casinoRoyale = new Movie("Casino Royale", "Eon Productions", "PG13");
            Movie _glass = new Movie("Glass", "Buena Vista International", "PG13");
            Movie _spiderman = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            Console.WriteLine(_spiderman.GetPG);
            Console.WriteLine(_casinoRoyale.GetPG);
            Console.WriteLine(_glass.GetPG);
            Console.ReadKey();
        }
    }
}