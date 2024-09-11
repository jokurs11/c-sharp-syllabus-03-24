namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numDays;
        private bool _primeLocation;

        public Hoarding(int rate,int numDays, int fee,  bool primeLocation = false) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
            _primeLocation = primeLocation;
        }

        public override int Cost()
        {
            int totalCost = base.Cost() + (_rate * _numDays);
            if (_primeLocation)
            {
                totalCost += (totalCost * 50 /100);
            }
            return totalCost;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nHoarding Details: Rate = {_rate}, " +
                   $"Amount of days = {_numDays}";
        }
    }
}