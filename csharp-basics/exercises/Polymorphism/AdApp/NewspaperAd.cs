namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int column, int rate, int fee) : base(fee)
        {
            _column = column;
            _rate = rate;
        }

        public override int Cost()
        {
            return base.Cost() + (_column * _rate);
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNewspaperAd Details: Column size = {_column}, " +
                   $"Rate = {_rate:C} per cm";
        }
    }
}