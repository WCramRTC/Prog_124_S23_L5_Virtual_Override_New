using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L5_Virtual_Override_New
{
    internal class CheckingAccount : BankAccount
    {
        double _overdraftFee;

        public CheckingAccount(string name, string accountNumber, double balance, double overdraftFee = 50) : base(name, accountNumber, balance)
        {
            _overdraftFee = overdraftFee;
        }

        public override bool Withdraw(double amount)
        {
            bool withdrewAmount = base.Withdraw(amount);

            if(!withdrewAmount)
            {
                Balance -= _overdraftFee;
            }

            return withdrewAmount;
        }



    }
}
