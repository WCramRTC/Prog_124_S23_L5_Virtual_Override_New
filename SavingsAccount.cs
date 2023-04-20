using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L5_Virtual_Override_New
{
    internal class SavingsAccount : BankAccount
    {
        double _interest;

        public SavingsAccount(string name, string accountNumber, double balance, double interest = .1) : base(name, accountNumber, balance)
        {
            _interest = interest;
        }

        public override void Deposit(double amount)
        {
            base.Deposit(amount);
            Balance += (amount * _interest);
        }

    }
}
