using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public abstract class Car
    {
        protected int _currentSpeed;

        protected Car()
        {
            _currentSpeed = 0;
        }

        public abstract void SpeedUp();

        public abstract void StartEngine();

        public abstract string ShowCurrentSpeed();

        public virtual void SlowDown()
        {
            var random = new Random();
            _currentSpeed  -= random.Next(1, 10);
        }
    }
}
