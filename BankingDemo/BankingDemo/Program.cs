using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemo
{
	class Program
	{
		static void Main(string[] args)
		{
            SavingAccount savBankAcc = new SavingAccount
            {
                AccountNumber = 1005,
                AccountDate = "16/06/2021",
                BalanceAmount = 10000.00
            };
			savBankAcc.Accountname.Add("Mani");
			savBankAcc.Accountname.Add("Kandan");
			savBankAcc.Debit(1000);
			Console.WriteLine("The Balance after Debiting from Savings Account is " + savBankAcc.CalcBalanceAmount());
			Console.WriteLine("The number of transactions completed:" + savBankAcc.listofTransactions.Values.Count());

			BankAccount chkBankAcc = new CheckingAccount
			{
				AccountNumber = 1006,
				AccountDate = "17/06/2021",
				BalanceAmount = 10000.00
		    }; 
			chkBankAcc.Accountname.Add("Tamizh");
			chkBankAcc.Debit(2000);

			Console.WriteLine("The Balance after Debiting from Checking Account is " + chkBankAcc.CalcBalanceAmount());
			Console.WriteLine("The number of transactions completed:"+chkBankAcc.listofTransactions.Values.Count());
			Console.ReadLine();

			
		}
	}
}
