using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L5_Virtual_Override_New
{
    internal class BankAccount
    {
        string _name;
        string _accountNumber;
        double _balance;

        public BankAccount(string name, string accountNumber, double balance)
        {
            _name = name;
            _accountNumber = accountNumber;
            _balance = balance;
        }

        public double Balance { 
            get => _balance; 
            protected set => _balance = value; 
        }

        public virtual void Deposit(double amount)
        {
            if(IsAmountPositive(amount))
            {
                _balance += amount;
            }
            
        } // Deposit

        public virtual bool Withdraw(double amount)
        {
            if(IsAmountPositive(amount) && CheckBalance(amount))
            {
                _balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
            
        } // Withdraw

        private bool IsAmountPositive(double amount)
        {
            return amount > 0;
        }

        private bool CheckBalance(double amount)
        {
            return amount <= _balance;
        }

        public override string ToString()
        {
            return $"{_name} {_balance}";
        }

    }
}
