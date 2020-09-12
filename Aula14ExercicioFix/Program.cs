using Aula14ExercicioFix.Entities;
using Aula14ExercicioFix.Services;
using System;

namespace Aula14ExercicioFix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());
            Console.WriteLine("Installments:");
            Contract c = new Contract(num, date, value);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(c, installments);
            Console.WriteLine("Installments:");
            foreach (Installment installment in c.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
