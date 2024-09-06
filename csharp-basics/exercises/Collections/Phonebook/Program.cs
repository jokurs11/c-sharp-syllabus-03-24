using PhoneBook;
using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new PhoneDirectory();

            directory.PutNumber("John Black", "+371255998899");

            var johnsNumber = directory.GetNumber("John Black");
            Console.WriteLine($"Alise's Wonders number is: {johnsNumber}");

            Console.WriteLine("Enter your full name:");
            var userName = Console.ReadLine();
            Console.WriteLine("Enter your phone number:");
            var userNumber = Console.ReadLine();

            directory.PutNumber(userName, userNumber);
            var usersNumber = directory.GetNumber(userName);
            Console.WriteLine($"{userName} number is: {usersNumber}");
        }
    }
}