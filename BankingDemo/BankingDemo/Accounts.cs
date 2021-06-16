using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemo
{
    public class BankAccount
    {
        public double transactionFee;
        public int AccountNumber { get; set; }

        public List<string> Accountname = new List<string>();
        public string AccountDate { get; set; }
        public double BalanceAmount { get; set; }

        public Dictionary<int, double> listofTransactions = new Dictionary<int, double>();
       

        public virtual double Debit(double amount)
        {
            BalanceAmount -= amount;
            listofTransactions.Add(1, amount);
            
            return BalanceAmount;
        }

        public virtual void Credit(double amount)
        {
            BalanceAmount += amount;
            listofTransactions.Add(2, amount);
        }

        public virtual double CalcBalanceAmount()
        {
            return BalanceAmount;
            
        }
        

    }

    
   
}
