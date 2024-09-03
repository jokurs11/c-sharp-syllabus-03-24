using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Dog
    {
        public string _name;
        private string _sex;
        private Dog _mother;
        private Dog _father;

        public Dog(string aName, string aSex)
        {
            _name = aName;
            _sex = aSex;
        }

        public void DogParents(Dog mother, Dog father)
        {
            _mother = mother;
            _father = father;
        }

        public string FathersName()
        {
            if (_father != null)
            {
                return _father._name;
            }

            return "Unknown";
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            if (_mother == _mother)
            {
                return true;
            }
            return false;
        }
    }
}
