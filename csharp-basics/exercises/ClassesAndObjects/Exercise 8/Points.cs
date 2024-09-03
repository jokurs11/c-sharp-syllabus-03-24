using System;

namespace Excercise8
{
    internal class Points
    {
        public int x { get; set; }
        public int y { get; set; }

        public Points(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public static void SwapPoints(Points p1, Points p2)
        {
            Points _p1 = p1;
            Points _p2 = p2;

            int tempx = p1.x;
            int tempy = p1.y;

            p1.x = p2.x;
            p1.y = p2.y;

            p2.x = tempx;
            p2.y = tempy;
        }
    }
}