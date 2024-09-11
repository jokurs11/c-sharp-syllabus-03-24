using System;

namespace DragRace
{
    public class Audi: Car, Icar
    {
        private int _currentSpeed ;

        public override void SpeedUp()
        {
            _currentSpeed += 8;
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