using System.Globalization;
using System.Text;

namespace Aula10Exerc1FIx.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string PriceTag()
        {
            //Notebook $ 1100.00
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }

    }
}
