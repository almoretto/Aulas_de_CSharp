using System;
using System.Globalization;
using System.Text;

namespace Aula10Exerc1FIx.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }
        //DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy",CultureInfo.InvariantCulture);

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            //Iphone (used) $ 400.00 (Manufacture date: 15/03/2017)
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (used) $");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Manufacture date: ");
            sb.Append(ManufactureDate.ToString("dd/MM/yyyy"));
            sb.Append(")");
            return sb.ToString();
        }
    }
}
