using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise6
{
    class Program
    {
        private static void Main(string[] args)
        {
            Dog _max = new Dog("Max", "male");
            Dog _rocky = new Dog("Rocky", "male");
            Dog _sparky = new Dog("Sparky", "male");
            Dog _buster = new Dog("Buster", "male");
            Dog _sam = new Dog("Sam", "male");
            Dog _lady = new Dog("Lady", "female");
            Dog _molly = new Dog("_molly", "female");
            Dog _coco = new Dog("Coco", "female");

            _max.DogParents(_lady, _rocky);
            _coco.DogParents(_molly, _buster);
            _rocky.DogParents(_molly, _sam);
            _buster.DogParents(_lady, _sparky);

            Console.WriteLine($"{_coco._name}'s {_coco.FathersName()}");
            Console.WriteLine($"{_sparky._name}'s {_sparky.FathersName()}");

            Console.WriteLine(_coco.HasSameMotherAs(_rocky));
        }
    }
}