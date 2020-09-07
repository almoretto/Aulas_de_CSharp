
namespace Aula13Exercicio.Models
{
    class Order
    {
        public string Product { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Order(string product, double price, int qty)
        {
            Product = product;
            Price = price;
            Qty = qty;
        }

        public override string ToString()
        {
            return "Product: "
                + Product
                + " US$: "
                + Price
                + "Bought Qty: "
                + Qty;
        }
    }
}
