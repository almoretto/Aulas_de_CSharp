using System;
using System.Collections.Generic;
using System.Linq;
using Aula17LinqSQL.Entities;

namespace Aula17LinqSQL
{
    class Program
    {
        static void Main(string[] args)
        {
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
            //Lambda sentence
            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            //LinqSQL Sentence
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;

            Print("Producs Tier 1 and Price < 900: ", r1);

            //Lambda Sentence
            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            //LinqSQL Sentence
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;

            Print("Products from Tools Category", r2);

            //Lambda Sentence Select the products where name begins with 'C' and bring only Name, Price and Category Name, 
            //we have to create an Annonymous OBJ
            //For category Name, we have to create an Alias otherwise will be collision in names Category = p.Category.Name
            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, Category = p.Category.Name });
            //LinqSQL Sentence
            var r3 =
                from p in products
                where p.Name[0] == 'c'
                select new
                {
                    p.Name,
                    p.Price,
                    Category = p.Category.Name
                };

            Print("Products that begins with 'C', And annonymous Object", r3);

            //Lambda Sentence
            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            //LinqSQL Sentence For order by Price and Name, in the SQL sentence must be inverted first Name then Price.
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name //Inverse order of KEY 
                orderby p.Price
                select p;

            Print("Products category tier 1, oder by price and then by name", r4);

            //Special Methodsis used before the LinqSQL sentence into parentesis (linqSQL).Method
            //var r5 = r4.Skip(1).Take(3);
            var r5=
                (from p in r4
                select p)
                .Skip(1)
                .Take(3);
            Print("Products category tier 1, oder by price and name, skip 1 take 3", r5);

            Console.WriteLine();

            //var r16 = products.GroupBy(p => p.Category);
            var r16 =
                from p in products
                group p by p.Category;
                
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

