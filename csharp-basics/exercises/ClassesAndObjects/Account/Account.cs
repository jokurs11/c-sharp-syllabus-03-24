using System;

namespace Account
{
    class Account
    {
        private string _name { get; set; }
        private double _balance { get; set; }
        private double _deposit { get; set; }

        public Account(double balance, double deposit)
        {
            _balance = balance;
            _deposit = deposit;
        }

        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string PrintAccount()
        {
            return $"{_name}, {_balance:0.0}, {_deposit:0.0}";
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public static void Transfer(Account from, Account to, double Amount)
        {
            from._balance -= Amount;
            to._balance += Amount;
        }

        public string PrintAccountBallance()
        {
            return $"{_name}, {_balance:0.0}";
        }
    }
}