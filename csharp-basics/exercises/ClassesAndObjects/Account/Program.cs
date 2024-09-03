using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account acc1 = new Account(100.0, 20.0);
            Console.WriteLine(acc1.PrintAccount());
            Console.WriteLine();

            Account matt = new Account("Matt's account", 1000);
            Account myAcc = new Account("My account", 0);

            matt.Withdraw(100.0);
            myAcc.Deposit(100.0);

            Console.WriteLine(matt.PrintAccount());
            Console.WriteLine(myAcc.PrintAccount());
            Console.WriteLine();

            Account A = new Account("A", 100.0);
            Account B = new Account("B", 0.0);
            Account C = new Account("C", 0.0);

            Console.WriteLine(A.PrintAccountBallance());
            Console.WriteLine(B.PrintAccountBallance());
            Console.WriteLine(C.PrintAccountBallance());
            Console.WriteLine();

            Account.Transfer(A, B, 50.00);
            Account.Transfer(B, C, 25.00);

            Console.WriteLine("After Transfer:");
            Console.WriteLine(A.PrintAccountBallance());
            Console.WriteLine(B.PrintAccountBallance());
            Console.WriteLine(C.PrintAccountBallance());
            Console.WriteLine();
        }
    }
}