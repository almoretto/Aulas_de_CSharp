using System;
using System.Collections.Generic;
using Aula17Predicate.Entities;
using System.Linq;

namespace Aula17Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*Func<Product, string> func =  *NameUpper* p => p.Name.ToUpper();*/
            // Declaration of the Delegate Func using the Method NameUpper in comments *NameUpper*
            // The declaration is completely unneeded if we put the Lambda in the select method
            //The better way is to use the Lambda Expression p=>p.Name.ToUpper();
            List<string> newList = list.Select(p => p.Name.ToUpper()/*NameUpper*/ /*func*/).ToList();//Delegate Func with Select 
            //need to convert the result ToList() because the result is TResult IEnumerable.

            Action<Product> act = UpdatePrice; //Create Action
            list.ForEach(act);

            list.ForEach(UpdatePrice); //Action Delegate
            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
            //Solution with Lambda Expression
            list.RemoveAll(p => p.Price >= 100);
            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
            //Solution with Delegate Function

            list.RemoveAll(ProductTest);


        }
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
        public static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
