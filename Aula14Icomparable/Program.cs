using System;
using System.IO;
using System.Collections.Generic;
using Aula14Icomparable.Entities;

namespace Aula14Icomparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\func.csv";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employees> list = new List<Employees>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employees(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employees str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
