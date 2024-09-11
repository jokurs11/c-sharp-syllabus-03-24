using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Volkswagen : Car, Icar
    {
        private int _currentSpeed ;

        public override void SpeedUp()
        {
            _currentSpeed += 6;
        }

        public override string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public override void SlowDown()
        {
            var random = new Random();
            _currentSpeed -= random.Next(1, 5);
        }

        public override void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
