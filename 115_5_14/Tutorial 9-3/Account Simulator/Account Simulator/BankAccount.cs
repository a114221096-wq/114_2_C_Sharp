using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Simulator
{
    class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public decimal Balance()
        {
            get { return balance; }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;

            else if (amount <= 0)
                    {
                    throw new ArgumentException("Withdrawal amount must be positive.");
                }
                else
                {
                    throw new InvalidOperationException("Insufficient funds for withdrawal.");
                }
            }
        }
    }
}
