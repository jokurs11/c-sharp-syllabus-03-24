namespace Excercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new (string name, decimal basePay, int hoursWorked)[]
            {
                ("Employee 1", 7.50m, 35),
                ("Employee 2", 8.20m, 47),
                ("Employee 3", 10.00m, 73)
            };

            const decimal minimumWage = 8.00m;
            const int maxHoursWorked = 60;
            const int baseHours = 40;

            foreach (var (name, basePay, hoursWorked) in employees)
            {
                if (basePay < minimumWage)
                {
                    Console.WriteLine("Error: " + name + " has a base pay below the minimum wage.");
                }
                else if (hoursWorked > maxHoursWorked)
                {
                    Console.WriteLine("Error: " + name + " has worked more than the allowed 60 hours.");
                }
                else
                {
                    decimal regularPay;
                    decimal overtimePay;
                    if (hoursWorked <= baseHours)
                    {
                        regularPay = hoursWorked * basePay;
                        overtimePay = 0;
                    }
                    else
                    {
                        regularPay = baseHours * basePay;
                        overtimePay = (hoursWorked - baseHours) * basePay * 1.5m;
                    }
                    decimal totalPay = regularPay + overtimePay;
                    Console.WriteLine($"{name}'s total pay is: ${totalPay:0.00}");
                }

            }
        }
    }
}