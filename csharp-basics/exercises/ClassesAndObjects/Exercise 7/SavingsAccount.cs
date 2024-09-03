using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Exercise7
{
    internal class SavingsAccount
    {
        private double _balance;
        private double _annualInterestRate;
        private double _totalDeposits;
        private double _totalWithdrawals;
        private double _totalInterestEarned;

        public SavingsAccount(double startingBalance, double annualInterestRate)
        {
            _balance = startingBalance;
            _annualInterestRate = annualInterestRate;
            _totalDeposits = 0;
            _totalWithdrawals = 0;
            _totalInterestEarned = 0;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            _totalDeposits += amount;
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
            _totalWithdrawals += amount;
        }

        public void AddMonthlyInterest()
        {
            double monthlyInterestRate = _annualInterestRate / 12 / 100;
            double interest = _balance * monthlyInterestRate;
            _balance += interest;
            _totalInterestEarned += interest;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public double GetTotalDeposits()
        {
            return _totalDeposits;
        }

        public double GetTotalWithdrawals()
        {
            return _totalWithdrawals;
        }

        public double GetTotalInterestEarned()
        {
            return _totalInterestEarned;
        }
    }
}