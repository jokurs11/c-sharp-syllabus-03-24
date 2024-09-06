using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {

        private SortedDictionary<string, string> _directory;

        public PhoneDirectory()
        {
            _directory = new SortedDictionary<string, string>();
        }

        public string GetNumber(string name)
        {
            if (_directory.TryGetValue(name, out var number))
            {
                return number; ;
            }
            return null;
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("Name and number cannot be null");
            }

            _directory[name] = number;
        }
    }
}