using System;
using System.Collections.Generic;
using System.Text;

namespace Aula15HashCodeEquals.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override int GetHashCode() //To Compare Objects we have to create the method Equals and GetHashCode to bring the content
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }
            Product toBeTested = obj as Product;
            return Name.Equals(toBeTested.Name) && Price.Equals(toBeTested.Price);
        }
    }
}
