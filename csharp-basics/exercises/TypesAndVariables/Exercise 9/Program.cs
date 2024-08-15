namespace Exercise9
{
    internal class Program
    {

        static void Main(string[] args)
        {


            // Input distance in meters
            Console.Write("Input the amount of meters ");
            decimal Meters = decimal.Parse(Console.ReadLine());

            Console.Write("How many hours: ");
            decimal Hours = decimal.Parse(Console.ReadLine());
            Console.Write("How many minutes: ");
            decimal Mins = decimal.Parse(Console.ReadLine());
            Console.Write("How many seconds: ");
            decimal Sec = decimal.Parse(Console.ReadLine());


            decimal timeSec = (Hours * 3600) + (Mins * 60) + Sec;

            decimal mps = Meters / timeSec;
            decimal kph = (Meters / 1000) / (timeSec / 3600);
            decimal mph = kph / 1.609m;


            Console.WriteLine("Your speed in meters/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
        }
    }
}

