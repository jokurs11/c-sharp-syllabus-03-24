namespace Exercise8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of minutes and i will convert them to both days and years");
            string? Minutes = Console.ReadLine();


            decimal userDays = decimal.Parse(Minutes) / 1440;
            decimal userYears = decimal.Parse(Minutes) / 525600;

            Console.WriteLine("The days are " + $"{userDays:0.000}" + ".");
            Console.WriteLine("The years are " + $"{userYears:0.000}" + ".");


        }
    }
}

