using Aula15ExercicioResolvidoSet.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aula15ExercicioResolvidoSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecords> LogSet = new HashSet<LogRecords>();
            Console.Write("Enter file full path: ");
            string path = @"" + Console.ReadLine();
            try
            {
                using StreamReader sr = File.OpenText(path); //File Reading
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');//Line Reading And Spliting by blank space
                    string name = line[0];
                    DateTime instant = DateTime.Parse(line[1]);
                    LogSet.Add(new LogRecords(name, instant)); //Adding logs to the set necessary overrrydes Equals() e GetHashSet()
                }
                Console.WriteLine("Total users: " + LogSet.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
