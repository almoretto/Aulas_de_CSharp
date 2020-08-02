using System;
using Aula10FixationExerc02.Entities;
using System.Collections.Generic;

namespace Aula10FixationExerc02
{
    class Aula10FixationExerc02
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxes = new List<TaxPayer>();
            
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            char ch;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxes.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (ch =='c'||ch=='C')
                {
                    Console.WriteLine("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxes.Add(new Company(name, anualIncome, numberOfEmployees));
                }
                else
                {
                    Console.WriteLine("Invalid Option!");
                }
            }//fim for
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double total=0.0;
            foreach (TaxPayer t in taxes)
            {
                Console.WriteLine(t.Name+": $"+ t.Tax().ToString("F2"));
                total += t.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $"+total.ToString("F2"));
        }
    }
}
