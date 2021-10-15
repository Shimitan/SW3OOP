namespace BankAccountNonnegativeBalance
{
    public class Transaction
    {
        public double Amount { get; }

        public Transaction(double amount)
        {
            this.Amount = amount;
        }
    }
}