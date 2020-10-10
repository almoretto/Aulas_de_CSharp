using System;
using System.Collections.Generic;
using Aula15HashCodeEquals.Entities;

namespace Aula15HashCodeEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The string has the HashCode() and Equals() metod Implemented.
             * in that case we just use the method Contains(), wich uses HashCode()
             * to check a probable match and before that uses Equals() to verify the 
             * real deal. SEE Below
            */
            HashSet<string> st = new HashSet<string> { "Maria", "Alex" };
            Console.WriteLine(st.Contains("Maria"));
            
            Client a = new Client
            {
                Name = "André",
                Email = "amoretto@outlook.com.br"
            };
            Client b = new Client
            {
                Name = "Mary",
                Email = "mmoretto@outlook.com.br"
            };
            Client c = new Client
            {
                Name = "André",
                Email = "amoretto@outlook.com.br"
            };
            /* The Client Class has´t the HashCode() and Equals() metod Implemented.
             * in that case we need to implement both Methods See in the file Client.Cs
             * SEE Below some tests
            */
            Console.Write("a.Equals(b): ");
            Console.WriteLine(a.Equals(b)); //Checks Client a and b according with the rules implemented on Overrided class
            Console.Write("a==b: ");
            Console.WriteLine(a == b);
            Console.Write("a.Equals(c): ");
            Console.WriteLine(a.Equals(c));
            Console.Write("a==c: ");
            Console.WriteLine(a == c);
            int hCa = a.GetHashCode(); //Atributes to an int var the HashCode of a to posterior comparation
            int hCb = b.GetHashCode();
            int hCc = c.GetHashCode();

            Console.WriteLine("Hashcode axb: " + (hCa == hCb).ToString());
            Console.WriteLine("Hashcode axc:" + (hCa == hCc).ToString());

            Console.WriteLine("----======Sets part2 =====-------");
            Console.WriteLine();

            HashSet<Product> prod = new HashSet<Product>();

            prod.Add(new Product("TV", 900.0));
            prod.Add(new Product("Notebook", 1200.0));

            HashSet<Point> point = new HashSet<Point>();
            
            point.Add(new Point(3, 4));
            point.Add(new Point(5, 10));

            Product prodt = new Product("Notebook", 1200.0); //New Object new memory address

            Console.WriteLine(prod.Contains(prodt)); // Returns False because they are both difrent objects, 
                                                    //it´s checks the mem ref not content

            Point pointp = new Point(5, 10);

            Console.WriteLine(point.Contains(pointp)); //In one Struct the return is true because Contains() gets the content not the referense.


        }
    }
}
