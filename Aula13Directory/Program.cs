using System;
using System.IO;
using System.Collections.Generic;

namespace Aula13Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string soucePath = @"C:\temp\myfolder";
            //string targetPath = @"C:\temp\File_2.txt";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(soucePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }
                IEnumerable<string> files = Directory.EnumerateFiles(soucePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }
                Directory.CreateDirectory(soucePath + @"\Criado"); //We have to use @ before the string or "\\Criado"
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
