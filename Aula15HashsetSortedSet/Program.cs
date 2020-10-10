using System;
using System.Collections.Generic;

namespace Aula15HashsetSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>(); //Instanse of the SET
            //Adding itens to the set
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Notebook")); //Method to check if Contains
            Console.WriteLine(set.Contains("Computer"));
            foreach (String p in set) //loop to print all elements in the set
            {
                Console.WriteLine(p);
            }
            //Instance of the Ordered Set
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); //Set union between two or more sets equals Algebra
            Console.WriteLine("Union between sets a, b");
            printCollection(c);
            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);//Set intersection between two or more sets equals Algebra
            Console.WriteLine("Intersection between sets a, b");
            printCollection(d);
            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);//Set difference between two or more sets equals Algebra
            Console.WriteLine("Difference between sets a, b");
            printCollection(e);


        }
        //Method to print Any type of variable <T> using IEnumerable [CTRL+click] in the reserved word to follow the method
        static void printCollection<T>(IEnumerable<T> collection) 
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
