using System;

namespace BankAccount
{
    internal class BankAccount
    {
        private string _name { get; set; }
        private double _balance { get; set; }

        public BankAccount(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string UserNameAndBalance()
        {

            string formatBalance;

            if (_balance < 0)
            {
                formatBalance = $"-${Math.Abs(_balance):0.00}";
            }
            else
            {
                formatBalance = $"${_balance:0.00}";
            }
            return $"{_name}, {formatBalance}";
        }
    }
}