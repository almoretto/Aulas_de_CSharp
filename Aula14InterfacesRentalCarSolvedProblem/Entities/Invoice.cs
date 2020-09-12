using System.Globalization;
using System.Text;

namespace Aula14InterfacesRentalCarSolvedProblem.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }
        /*INVOICE:
            Basic payment: 390.00
            Tax: 58.50
            Total payment: 448.50*/
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INVOICE: ");
            sb.Append("Basic payment: ");
            sb.AppendLine(BasicPayment.ToString("F2",CultureInfo.CurrentCulture));
            sb.Append("Tax: ");
            sb.AppendLine(Tax.ToString("F2",CultureInfo.CurrentCulture));
            sb.Append("Total payment: ");
            sb.AppendLine(TotalPayment.ToString("F2",CultureInfo.CurrentCulture));

            return sb.ToString();
        }
    }
}
