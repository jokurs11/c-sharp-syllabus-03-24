using System;
using System.Collections.Generic;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace AdApp
{
    public class Poster : Advert
    {
        private int _dimensions { get; set; }
        private int _copies { get; set; }
        private int _cost { get; set; }

        public Poster(int dimensions, int copies, int cost, int fee) : base(fee)
        {
            _dimensions = dimensions;
            _copies = copies;
            _cost = cost;
        }

        public override int Cost()
        {
            return (_copies * _cost) +  base.Cost() ;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nPoster Details: Dimensions = {_dimensions}, " +
                   $"Copies = {_copies}, Cost Per Copy = {_cost:C}";
        }
    }
}
