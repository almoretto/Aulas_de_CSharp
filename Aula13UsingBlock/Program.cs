using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Aula13UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string soucePath = @"C:\temp\File_1.txt";
            string targetPath = @"C:\temp\File_2.txt";

            try
            {
                //using FileStream fs = new FileStream(soucePath, FileMode.Open);
                //using (StreamReader sr = new StreamReader(fs))
                /*
                using (StreamReader sr = File.OpenText(soucePath)) //forma reduzida
                {
                    while (!sr.EndOfStream)
                    {
                        String line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                */
                string[] lines = File.ReadAllLines(soucePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
