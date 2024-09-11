namespace AdApp
{
    public class TVAd : Advert
    {
        private int _airTime;
        private bool _peakTime;
        private int _cost;
        public TVAd(int airTime, bool peakTime, int cost, int fee) : base(fee)
        {
            _airTime = airTime;
            _peakTime = peakTime;
            _cost = cost;
        }

        public override int Cost()
        {
            int cost = base.Cost() + (_airTime * _cost);
            if (_peakTime)
            {
                cost *= 2;
            }
            return cost;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTVAd Details: Seconds = {_airTime}, " +
                   $"Rate = {_cost:C}, Peak Time = {_peakTime}";
        }
    }
}