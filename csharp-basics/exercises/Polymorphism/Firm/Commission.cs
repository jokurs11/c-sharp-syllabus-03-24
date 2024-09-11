﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        public Commission(string Name, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : 
            base(Name, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate % 100;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = totalSales;
        }

        public override double Pay()
        {
            double payment = base.Pay();

            payment += _totalSales * _commissionRate;

            _totalSales = 0;

            return payment;
        }
    }
}
