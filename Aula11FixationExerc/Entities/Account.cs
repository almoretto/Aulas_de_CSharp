using Aula11FixationExerc.Exceptions;
using System.Globalization;

namespace Aula11FixationExerc.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

       
        public Account(int number, string holder, double withdrawLimit)
        {
            if (withdrawLimit<=0)
            {
                throw new AccountExeptions("To set an account you must set a withdraw limit");
            }
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;

        }

        public void Deposit (double amount)
        {
            if (amount<=0)
            {
                throw new AccountExeptions("A deposit must be superior to 0");
            }
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount>WithdrawLimit)
            {
                throw new AccountExeptions("Withdraw error: The amount exceeds withdraw limit");
            }
            if (amount>Balance)
            {
                throw new AccountExeptions("Withdraw error: Not enough balance");
            }
            Balance -= amount;

        }
        public string GetBalance()
        {
            return "New balance:"
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
