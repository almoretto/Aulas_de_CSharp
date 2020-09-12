
namespace Aula14InterfacesRentalCarSolvedProblem.Services
{
    class BrazilTaxServices : ITaxService //Depency declaration same as inheritance
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.20d;
            }
            else
            {
                return amount * 0.15d;
            }
        }
    }
}
