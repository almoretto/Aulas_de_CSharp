using System;
using System.Collections.Generic;
using System.Linq;
using Aula17Linq.Entities;

namespace Aula17Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source.

            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression.

            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => 10 * x);

            // Execute the query.

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };


            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("Producs Tier 1 and Price < 900: ", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Products from Tools Category", r2);
            //Select the products where name begins with 'C' and bring only Name, Price and Category Name, we have to create an Annonymous OBJ
            //For category Name, we have to create an Alias otherwise will be collision in names Category = p.Category.Name
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, Category = p.Category.Name });
            Print("Products that begins with 'C', And annonymous Object", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Products category tier 1, oder by price and name", r4);

            var r5 = r4.Skip(1).Take(3);
            Print("Products category tier 1, oder by price and name, skip 1 take 3", r5);

            var r6 = products.FirstOrDefault(); //using First() we need to treat the Exception case empty.
            Console.WriteLine("First or default test1: " + r6);
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);
            //DefaltIfEmpty() for treat exception iff empty
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);
            //Select Agregate is a Map Reduce  the select get de data that i want to work with and the agregate is the operation 0.0 is the exception for Empty
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r16)
            {
                //Key is an internal variable <T> in this case <Category>
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
    }
}
