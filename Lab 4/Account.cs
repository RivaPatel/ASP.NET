using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Account
    {
        
        private decimal Balance;
        private string accountHolderName;

        // Constructor
        public Account(decimal initialBalance, string accountHolderName)
            {
                this.Balance = initialBalance;
                this.accountHolderName = accountHolderName;

            }

            //method to deposit cash
            public void depositcash(decimal cashDeposit)
        {
            if (cashDeposit <= 0)
            {
                Console.WriteLine("Deposit Ammount must be greater Zero");
            }
            else
            {
                Balance += cashDeposit;
                Console.WriteLine("your Balance is updated" + Balance);
            }
        }

        //methodd to deposit check
        public void Depositcheck(decimal checkDeposit)
        {
            if (checkDeposit <= 0)
            {
                Console.WriteLine("Deposit Ammount must be greater than Zero");
            }
            Balance += checkDeposit;
            Console.WriteLine("your Balance is updated" + Balance);
        }

        //method to withdraw cash
        public void Withdrawcash(decimal cashWithdraw)
        {
            if (cashWithdraw <= 0)
            {
                Console.WriteLine("Withdraw Ammount must be greater than Zero");
            }
            Balance -= cashWithdraw;
            Console.WriteLine("your Balance is updated" + Balance);

        }

        //method to withdraw check
        public void Withdrawcheck(decimal checkWithdraw)
        {
            if (checkWithdraw <= 0)
            {
                Console.WriteLine("Withdraw Ammount must be greater than Zero ");
            }
            Balance -= checkWithdraw;
            Console.WriteLine("your Balance is updated" + Balance);
        }
    }
}

