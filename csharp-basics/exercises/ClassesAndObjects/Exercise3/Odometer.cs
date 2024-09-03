using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
    internal class Odometer
    {
        private int mileage;
        private const int MaxMileage = 999999;
        private FuelGauge fuelGauge;

        public Odometer(int initialMileage, FuelGauge fuelGauge)
        {
            mileage = initialMileage;
            this.fuelGauge = fuelGauge;
        }

        public int GetMileage()
        {
            return mileage;
        }

        public void IncreaseMileage()
        {
            if (mileage < MaxMileage)
            {
                mileage++;
            }
            else
            {
                mileage = 0;
            }

            if (mileage % (100 / 10) == 0)
            {
                fuelGauge.DecreaseFuel();
            }
        }
    }
}