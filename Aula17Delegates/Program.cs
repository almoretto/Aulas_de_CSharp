using System;
using Aula17Delegates.Services;

namespace Aula17Delegates
{
    //Delegate declarattion
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperationMulticast(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //Assign the delegate
            BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation opm = CalculationService.Max;
            //BinaryNumericOperation ops = CalculationService.Square; could not be implemente because the signature of the delegate

            double result = op(a, b);
            Console.WriteLine(result);
            Console.WriteLine(opm(a,b));

            //Exemple of Multicast Delegate
            BinaryNumericOperationMulticast opN = CalculationServiceM.ShowSum;
            opN += CalculationServiceM.ShowMax;
            opN(a, b);

        }
    }
}
