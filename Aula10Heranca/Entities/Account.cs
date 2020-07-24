namespace Aula10Heranca
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //Virtual is to overrride the method on an chield class
        public virtual void WithDraw(double amount)
        {
            Balance -= amount+5.0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
