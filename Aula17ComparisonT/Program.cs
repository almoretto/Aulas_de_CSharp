using System;
using System.Collections.Generic;
using Aula17ComparisonT.Entities;

namespace Aula17ComparisonT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 1000.00));
            products.Add(new Product("Notebook", 2500.00));
            products.Add(new Product("Tablet", 800.00));
            products.Add(new Product("SmartPhone", 1500.00));

            /*This Sort could be done because we Inherit IComparable in Product Class and implement Method CompareTo();
             * The parameter CompareProducts is an Delegate and is using the auxiliary method to CompareTo() without Inhetance of IComparable
             * This could be possible because the Signature of the method Delegate Comparisson<t> and the Method CompareProducts are the Same 
            products.Sort(CompareProducts);
             * we can to insert the method assigned to a variable Comparison<T> and to assign the var to the Sort() method.
            Comparison<Product> comp = CompareProducts;
            products.Sort(comp);
             * Comparison<T> using Lambda expression
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            products.Sort(comp);
            But in C# we Can Allways Symplify the most, and we can put all the lambda in the Sort directly See below
            */
            products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }
        //Auxiliary Method to mantain the CompareTo() Without Inheritance of IComparable.
        /*
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
        */
    }
}
