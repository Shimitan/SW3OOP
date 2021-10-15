using System;

namespace BankAccountNonnegativeBalance
{
    public class BankAccount
    {
        public double Balance { get; set; }
        public string Owner { get; set; }

        public void DepositBalance(double amount)
        {
            this.Balance += amount;
        }

        public void WithdrawBalance(double amount)
        {
            if (this.Balance - amount < 0)
            {
                throw new ArgumentException();
            }
            this.Balance -= amount;
        }

        public BankAccount(string name, double startBalance)
        {
            this.Owner = name;
            this.Balance = startBalance;
        }
    }
}