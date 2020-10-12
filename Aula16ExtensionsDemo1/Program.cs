using System;

namespace Aula16ExtensionsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime()); //ElapsedTime is an Extension method to the DateTime

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10)); //Cut is an Extension method to the String type

        }
    }
}
