using System;
using System.IO;

namespace Aula13WorkingWithFilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string soucePath = @"C:\temp\File_1.txt";
           // string targetPath = @"C:\temp\File_2.txt";

            /*
            try
            {
                FileInfo fileInfo = new FileInfo(soucePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(soucePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }*/

            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                // fs = new FileStream(soucePath, FileMode.Open);
                // sr = new StreamReader(fs);
                //Simplyfied form for instance streamreader.
                sr = File.OpenText(soucePath); //.OpenText has an implicity call to StreamReader and FileStream
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
               

            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }

        }
    }
}
