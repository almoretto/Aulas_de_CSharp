using System;
using System.Globalization;
using System.Collections.Generic;
namespace Course
{
    class Aula06Arrays
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Digite a quantidade de medidas a serem computadas");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite a qte de produtos para input!");
            int m = int.Parse(Console.ReadLine());
            Product[] productsInput = new Product[m];
            for (int i = 0; i < m; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o preço do produto " + nome + " :");
                double preco = double.Parse(Console.ReadLine());
                productsInput[i] = new Product { Name = nome, Price = preco };
            }
            double soma = 0.0;
            for (int i = 0; i < m; i++)
            {
                soma += productsInput[i].Price;
            }
            double media = soma / m;
            Console.WriteLine("AVERAGE PRICE = "+media.ToString("F2"));
            */
           /*
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            list.Remove("Alex");
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            */
            /*Matrizes*/


        }
    }
}