using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    internal class Employee : Person, IPerson
    {
        private string _jobTitle { get; set; }

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName,
            lastName, address, id)
        {
            _jobTitle = jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {_firstName} {_lastName}, Address: {_address}, Employee ID: {_id}, Job title: {_jobTitle}.");
        }
    }
}
