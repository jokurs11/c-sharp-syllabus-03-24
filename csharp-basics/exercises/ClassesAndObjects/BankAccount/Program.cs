using System.Security.Principal;
using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount benben = new BankAccount("Benson", 17.25);
            BankAccount sarah = new BankAccount("Benson", -17.50);

            Console.WriteLine(benben.UserNameAndBalance());
            Console.WriteLine(sarah.UserNameAndBalance());
        }
    }
}