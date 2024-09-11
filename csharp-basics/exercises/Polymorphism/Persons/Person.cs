using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public abstract class Person : IPerson
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _address { get; set; }
        public int _id { get; set; }

        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public abstract void Display();
    }
}
