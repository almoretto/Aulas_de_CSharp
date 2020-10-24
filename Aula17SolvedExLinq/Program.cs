using System;
using System.Collections.Generic;
using Aula17SolvedExLinq.Entities;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Aula17SolvedExLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = @"" + Console.ReadLine();

            List<Products> listP = new List<Products>(); //instance

            using (StreamReader sr = File.OpenText(path)) //reading txt file
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    listP.Add(new Products(name, price));
                }
            }

            //Calculates de Average price of all list of prices
            var avg = listP
                .Select(p => p.Price)
                .DefaultIfEmpty(0.0)
                .Average();
            Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //Producs where price < avg orderby descending select name
            var names = listP
                .Where(p => p.Price < avg)
                .OrderByDescending(p => p.Name)
                .Select(p => p.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
