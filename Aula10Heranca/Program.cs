using System;

namespace Aula10Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 500.00);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.00, 500.00);
            acc.WithDraw(10.0);
            
            //upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "jose", 100.00, 500.00);
            Account acc3 = new SavingsAccount(1004, "Alfredo", 500.00, 0.1);
            acc3.WithDraw(10.0);
            //downcasting

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);
            /*
            The line below is tring to Downcasting the Class SavingsAccount to BusinessAccount and they aren´t compatible.
            To do this we have to test the var type if is compatible using the "is" test.
            BusinessAccount acc5 = (BusinessAccount)acc3;
            */
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");

            }
            //Other form to Downcasting using the word "as"
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");

            }
            Console.WriteLine(acc.Balance.ToString("F2"));
            Console.WriteLine(acc3.Balance.ToString("F2"));
        }
    }
}
