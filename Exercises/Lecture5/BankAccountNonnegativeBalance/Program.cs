using System;

namespace BankAccountNonnegativeBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Michael", 1000);
            Console.WriteLine($"Account was created for {account.Owner}. Start balance is {account.Balance}");

            try
            {
                account.WithdrawBalance(1500);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You do not have enough balance");
            }
            
            Console.WriteLine(account.Balance);
            
        }
    }
}