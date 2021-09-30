namespace BankAccount
{
    public class BankAccount
    {
        private double balance;
        private double borrowingRate;
        private double savingRate;

        public double Balance
        {
            get
            {
                return balance;
            }
        }
        public double BorrowingRate { get; set; }
        public double SavingRate { get; set; }

        
    }
}