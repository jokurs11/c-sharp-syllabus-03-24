﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * 2;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return length * width * 2;
        }

        public static double AreaOfTriangle(double ground, double h)
        {
            return (ground * h) / 2;
        }
    }
}
