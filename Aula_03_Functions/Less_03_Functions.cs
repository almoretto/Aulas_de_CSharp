using System;
namespace Aula_03_Functions
{
    class Less_03_Functions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
        }
        /// <summary>
        /// Inicio da função para ver qual é o maior número de 3 inteiros digitados
        /// </summary>
        /// <param name="a">número inteiro</param>
        /// <param name="b">número inteiro</param>
        /// <param name="c">número inteiro</param>
        /// <returns>um número inteiro que será o maior dentre três inteiros</returns>

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
