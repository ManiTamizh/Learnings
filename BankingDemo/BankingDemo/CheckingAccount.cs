using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemo
{
    public class CheckingAccount : BankAccount
    {
        public override double Debit(double amount)
        {
            transactionFee = amount * 0.025;
            BalanceAmount -= amount + transactionFee;
            listofTransactions.Add(3, amount);
            return BalanceAmount;
        }
    }
}
