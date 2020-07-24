namespace Aula10Heranca
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount() { } //Default Constructor
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance) //Contructor Inheritated
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        //Sealed Methods, can be only on already overrrided methods
        public sealed override void WithDraw(double amount)
        {
            Balance -= amount;
        }
    }
}
