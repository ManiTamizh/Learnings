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
                AccountDate = DateTime.Today,
                BalanceAmount = 10000.00
            };
			savBankAcc.Accountname.Add("Mani");
			savBankAcc.Accountname.Add("Kandan");
            Console.WriteLine($"This is a Savings account numbered {savBankAcc.AccountNumber} created on {savBankAcc.AccountDate} with balance {savBankAcc.BalanceAmount}");
            Console.WriteLine("The Account holders of this account are:");
            savBankAcc.Accountname.ForEach(Console.WriteLine);
            savBankAcc.Debit(1000);
			Console.WriteLine("The Balance after Debiting from Savings Account is " + savBankAcc.CalcBalanceAmount());
            Console.WriteLine("The list of transactions for saving account:");
            savBankAcc.listofTransactions.ForEach(Console.WriteLine);

            BankAccount chkBankAcc = new CheckingAccount
			{
				AccountNumber = 1006,
				AccountDate = DateTime.Now,
				BalanceAmount = 10000.00
		    }; 
			chkBankAcc.Accountname.Add("Tamizh");
            chkBankAcc.Accountname.Add("arasan");
            Console.WriteLine($"This is a Checking account numbered {chkBankAcc.AccountNumber} created on {chkBankAcc.AccountDate} with balance {chkBankAcc.BalanceAmount}");
            Console.WriteLine("The Account holders of this account are:");
            chkBankAcc.Accountname.ForEach(Console.WriteLine);
            chkBankAcc.Debit(2000);
            Console.WriteLine("The Balance after Debiting from Checking Account is " + chkBankAcc.CalcBalanceAmount());
            Console.WriteLine("The list of transactions for Checking account:");
            chkBankAcc.listofTransactions.ForEach(Console.WriteLine);


            Console.ReadLine();

			
		}
	}
}
