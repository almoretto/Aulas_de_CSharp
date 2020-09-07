using System;
using Aula11FixationExerc.Entities;
using Aula11FixationExerc.Exceptions;

namespace Aula11FixationExerc
{
    class Aula11FixationExerc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int acNumber = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string acHolder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());
            
            //Account Creation
            try
            {
                Account account = new Account(acNumber, acHolder, withdrawLimit);
                //try to deposit
                try
                {
                    account.Deposit(initialBalance);
                    account.GetBalance();
                }
                catch (AccountExeptions e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("unhandled exception: " + e.Message);
                }
                //try to withdraw
                try
                {
                    Console.WriteLine("Enter amount for withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    account.Withdraw(withdraw);
                    account.GetBalance();
                }
                catch (AccountExeptions e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("unhandled exception: " + e.Message);
                }
            }
            catch (AccountExeptions e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("unhandled exception: " +e.Message);
            }
           

        }
    }
}
