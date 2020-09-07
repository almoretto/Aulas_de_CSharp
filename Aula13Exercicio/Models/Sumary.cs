

namespace Aula13Exercicio.Models
{
    class Sumary
    {
        public string Product { get; set; }
        public double TotalSales { get; set; }

        public Sumary(string product, double totalSales)
        {
            Product = product;
            TotalSales = totalSales;
        }
    }
}
