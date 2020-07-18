using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Aula06Exercicio02
{
    /// <summary>
    /// Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários. Não deve haver repetição de id. 
    /// Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.Para isso, o programa deve ler um id e o valor X. 
    /// Se o id informado não existir, mostrar uma mensagem e abortar a operação. 
    /// Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos.
    /// Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente.
    /// Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada. 
    /// How many employees will be registered? 3
    /// Emplyoee #1:
    /// Id: 333
    /// Name: Maria Brown
    /// Salary: 4000.00
    /// Emplyoee #2:
    /// Id: 536
    /// Name: Alex Grey
    /// Salary: 3000.00
    /// Emplyoee #3:
    /// Id: 772
    /// Name: Bob Green
    /// Salary: 5000.00
    /// Enter the employee id that will have salary increase : 536
    /// Enter the percentage: 10.0
    /// Updated list of employees:
    /// 333, Maria Brown, 4000.00
    /// 536, Alex Grey, 3300.00
    /// 772, Bob Green, 5000.00
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type the quantity of emplyees to add: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            int ident;
            string name;
            double salary;


            for (int i = 0; i < n; i++)
            {

                Console.Write("Type the ID: ");
                ident = int.Parse(Console.ReadLine());
                Console.Write("Type the Name: ");
                name = Console.ReadLine();
                Console.Write("Type the Salary value: ");
                salary = double.Parse(Console.ReadLine());
                //The sintax below is incorrect
                //Employee employer = new Employee(ident, name, salary);
                //employees.Add(employer);
                //the sintax below is the correct
                employees.Add(new Employee(ident, name, salary));
            }
            Console.WriteLine("Type the id of the Employee for readjustment of salary: ");
            ident = int.Parse(Console.ReadLine());
            Employee emp = employees.Find(x => x.Id == ident);

            if (emp!=null)
            {
                Console.WriteLine("Type the percentage");
                double perc = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(perc);
            }
            else
            {
                Console.WriteLine("Id: " + ident + "does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
