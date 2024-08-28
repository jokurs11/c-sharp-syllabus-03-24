namespace Excercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in kilograms!");
            var userWeightKg = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height in meters!");
            var userHeightMeters = double.Parse(Console.ReadLine());
            var userWeight = userWeightKg * 2.20462;
            var userHeight = userHeightMeters * 39.3701;

            var BMI = userWeight * 703 / Math.Pow(userHeight, 2);

            if (BMI < 18.5)
            {
                Console.WriteLine("You are underweight!");
            }
            else if (BMI >= 18.5 && BMI <= 25)
            {
                Console.WriteLine("Your weight is optimal!");
            }
            else
            {
                Console.WriteLine("You are overweight!");
            }
            Console.WriteLine($"Your BMI is {BMI:0.00}");
        }
    }
}