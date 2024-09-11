using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> _campaign;

        public Campaign()
        {
            _campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a)
        {
            _campaign.Add(a);
        }

        public int GetCost()
        {
            return _campaign.Sum(a => a.Cost());
        }

        public override string ToString()
        {
            return string.Join("\n", _campaign.Select(a => a.ToString())) +
                   $"\nTotal Cost: {GetCost():C}";
        }
    }
}