using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemo
{
    public abstract class BankAccount
    {
        public double transactionFee;
        public int AccountNumber { get; set; }
        public List<string> Accountname = new List<string>();
        public DateTime AccountDate { get; set; }
        public double BalanceAmount { get; set; }
        public List<double> listofTransactions = new List<double>();
        public abstract double Debit(double amount);
        public virtual void Credit(double amount)
        {
            BalanceAmount += amount;
            listofTransactions.Add(amount);
        }
        public virtual double CalcBalanceAmount()
        {
            listofTransactions.Add(BalanceAmount);
            return BalanceAmount;
        }
    }
}
