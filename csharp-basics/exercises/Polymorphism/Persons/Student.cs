using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Student : Person, IPerson
    {
        private double _gpa { get; set; }

        public Student(string firstName, string lastName, string address, int id, double gPA) :
            base(firstName, lastName, address, id)
        {
            _gpa = gPA;
        }

        public override void Display()
        {
            Console.WriteLine($"Student: {_firstName} {_lastName}, Address {_address}, Student ID: {_id}, GPA: {_gpa}.");
        }
    }
}
