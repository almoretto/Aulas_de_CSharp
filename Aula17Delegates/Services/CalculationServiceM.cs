using System;

namespace Aula17Delegates.Services
{
    class CalculationServiceM
    {
        //Multicast Delegate Exemple
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y; //Ternary test --== I need to learn more about ==--
            Console.WriteLine(max);
        }
        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }
    }
}
