namespace Exercise8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of minutes and i will convert them to both days and years");
            string? minutes = Console.ReadLine();


            decimal userDays = decimal.Parse(minutes) / 1440;
            decimal userYears = decimal.Parse(minutes) / 525600;

            Console.WriteLine("The days are " + $"{userDays:0.000}" + ".");
            Console.WriteLine("The years are " + $"{userYears:0.000}" + ".");


        }
    }
}

