using System;
using Aula13Exercicio.Models;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Aula13Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string souceData = Path.GetFullPath(@"C:\Temp\myfolder\docs\pedidos.csv");
            string outPath = Path.GetDirectoryName(souceData);
            List<Order> orders = new List<Order>();
            List<Sumary> sumary = new List<Sumary>();
            try
            {
                using (StreamReader sr = File.OpenText(souceData)) //forma reduzida
                {
                    int count = 0;
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(';');
                        if (count != 0)
                        {
                            //string[] values = Console.ReadLine().Split(' ');
                            string prod = line[0];
                            double price = double.Parse(line[1],CultureInfo.CurrentCulture);
                            int qty = int.Parse(line[2]);
                            orders.Add(new Order(prod, price, qty));

                        }
                        count++;

                    }
                }
                foreach (Order o in orders)
                {
                    double total = o.Price * o.Qty;
                    sumary.Add(new Sumary(o.Product, total));
                }
                Directory.CreateDirectory(outPath + @"\out");
                using (StreamWriter sw = File.AppendText(outPath+@"\out\Sumary.csv"))
                {
                    foreach (Sumary s in sumary)
                    {
                        sw.WriteLine(s.Product + ";" + s.TotalSales);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
