using System;
namespace Aula10AbstractClasses
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanlimit)
            : base(number, holder, balance) //acionar construtor do Account
        {
            LoanLimit = loanlimit;
        }
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine($"Loan amount: {amount} overseeds Loan Limit: {LoanLimit}");
            }
        }
    }
}
