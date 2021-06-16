using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemo
{
    public class SavingAccount : BankAccount
    {
        public override double Debit(double amount)
        {
            transactionFee = amount * 0.01;
            BalanceAmount -= amount + transactionFee;
            listofTransactions.Add(amount);
            Console.WriteLine("The debited amount is " + amount);
            Console.WriteLine("The transaction fee 1% for the debited amount is "+ transactionFee);
            return BalanceAmount;
        }
    }
   
}
