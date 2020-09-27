using System;
using Aula15HashCodeEquals.Entities;

namespace Aula15HashCodeEquals
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.Write("a.Equals(b): ");
            Console.WriteLine(a.Equals(b));
            Console.Write("a==b: ");
            Console.WriteLine(a == b);
            Console.Write("a.Equals(c): ");
            Console.WriteLine(a.Equals(c));
            Console.Write("a==c: ");
            Console.WriteLine(a == c);
            int hCa = a.GetHashCode();
            int hCb = b.GetHashCode();
            int hCc = c.GetHashCode();

            Console.WriteLine("Hashcode axb: " + (hCa == hCb).ToString());
            Console.WriteLine("Hashcode axc:" + (hCa == hCc).ToString());
        }
    }
}
