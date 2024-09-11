using System.Collections.Generic;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Create an instant of class Student and an instant of class Employee with proper values for the attributes.
             * - Display the content of each class using Display() method.
             */

            var student = new Student("John", "Black", "Random street 1234", 35, 4.0);

            student.Display();

            var employee = new Employee("Susan", "Boyle", "Random street 4321", 55, "Janitor");

            employee.Display();
        }
    }
}