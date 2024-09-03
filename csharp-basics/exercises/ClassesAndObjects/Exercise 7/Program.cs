using System;


namespace Exercise7
{
    class Test
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("EHow much money is in the account?:");
            double startingBalance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the annual interest rate:");
            double annualInterestRate = double.Parse(Console.ReadLine());

            Console.WriteLine("How long has the account been opened?:");
            int months = int.Parse(Console.ReadLine());

            SavingsAccount account = new SavingsAccount(startingBalance, annualInterestRate);

            for (int i = 1; i <= months; i++)
            {
                Console.WriteLine($"Enter amount deposited for the month: {i}");
                double deposited = double.Parse(Console.ReadLine());
                account.Deposit(deposited);

                Console.WriteLine($"Enter amount withdrawn for the month: {i}");
                double withdrawn = double.Parse(Console.ReadLine());
                account.Withdraw(withdrawn);

                account.AddMonthlyInterest();
            }

            Console.WriteLine("Total deposited: " + account.GetTotalDeposits());
            Console.WriteLine("Total withdrawn: " + account.GetTotalWithdrawals());
            Console.WriteLine("Interest earned: " + account.GetTotalInterestEarned());
            Console.WriteLine("Ending balance: " + account.GetBalance());
        }
    }
}