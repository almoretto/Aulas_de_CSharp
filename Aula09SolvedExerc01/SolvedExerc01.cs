using System;
using Aula09SolvedExerc01.Entities;
using Aula09SolvedExerc01.Entities.Enums;

namespace Aula09SolvedExerc01
{
    class SolvedExerc01
    {
        static void Main(string[] args)
        {
            //Getting worker data
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            //instancing department
            Department dept = new Department(departmentName);
            //instancing worker with worker data above
            Worker worker = new Worker(workerName, level, baseSalary, dept);
            //getting number of contracts
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            //getting n contracts data 
            for (int i = 1; i <= n; i++)
            {
                //getting contract obe contract data
                Console.WriteLine($"Enter #{i} contract data:");//inserção concatenação por interpolação
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                //instancing contract with collected data above
                HourContract contract = new HourContract(date, valuePerHour, duration);
                //Calling method AddContract() of the worker instance.
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3, 4));
            //Final Display
            Console.WriteLine("Name: " +worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": "+ worker.Income(year, month));
        }
    }
}
