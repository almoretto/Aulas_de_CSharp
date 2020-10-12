using System.Globalization;
/// <summary>
/// To implement Comparison<T> we are going to take of the Herance from IComparable
/// Remove the Method CompraTo()
/// </summary>
namespace Aula17ComparisonT.Entities
{
    class Product /*: IComparable<Product> Supressing Inheritance*/
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
        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
        /* Supress the method CompareTo() for further implementation of Comparison<T>
        public int CompareTo(Product other)//Signature to Inherit IComparable<T>
        {
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }
        */
    }
}
