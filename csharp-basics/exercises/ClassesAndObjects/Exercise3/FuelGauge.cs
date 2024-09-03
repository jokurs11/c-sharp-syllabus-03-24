using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
    internal class FuelGauge
    {
        private int currentFuel;
        private const double MaxFuel = 70;

        public FuelGauge(int initialFuel = 0)
        {
            currentFuel = initialFuel;
        }

        public int GetFuel()
        {
            return currentFuel;
        }

        public void IncreaseFuel()
        {
            if (currentFuel < MaxFuel)
            {
                currentFuel++;
            }
        }

        public void DecreaseFuel()
        {
            if (currentFuel > 0)
            {
                currentFuel--;
            }
        }
    }
}