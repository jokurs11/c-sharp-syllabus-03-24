using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Mercedes : Car, Icar, Iboost
    {
        private int _currentSpeed ;

        public override void SpeedUp()
        {
            _currentSpeed += 9;
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

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 15;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
