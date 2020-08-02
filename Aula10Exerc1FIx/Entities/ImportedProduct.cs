using System.Globalization;
using System.Text;

namespace Aula10Exerc1FIx.Entities
{
    class ImportedProduct : Product
    {
        public double CustumsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double custumsFee)
            :base(name, price)
        {
            CustumsFee = custumsFee;
        }
        public double TotalPrice()
        {
            return Price += CustumsFee;
        }
        public override string PriceTag()
        {
            
            //Tablet $ 280.00 (Customs fee: $ 20.00)
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $");
            sb.Append(TotalPrice().ToString("F2",CultureInfo.InvariantCulture));
            sb.Append(" (Customs fee: $");
            sb.Append(CustumsFee.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(")");
            return sb.ToString();
        }
    }
}
