using System;
using System.Globalization;

namespace Exercicio_01_Aula_04
{
    /*<summary>
    Em seguida, usando os valores das variáveis, produza a seguinte saída na tela do console:
    Produtos:
        Computador, cujo preço é $ 2100,00
        Mesa de escritório, cujo preco é $ 650,50
        Registro: 30 anos de idade, código 5290 e gênero: M
        Medida com oito casas decimais: 53,23456700 
    OBS:  Arredondado(três casas decimais) : 53,235 Separador decimal invariant culture: 53.235
    </summary>*/
    class Exercicio_01_aula3
    {
        static void Main(string[] args)
        {
            /* string produto1 = "Computador";
             string produto2 = "Mesa de escritório";
             byte idade = 30;
             int codigo = 5290;
             char genero = 'M';
             double preco1 = 2100.0;
             double preco2 = 650.50;
             double medida = 53.234567;

             Console.WriteLine("Produtos:");
             Console.WriteLine($"{produto1}, valor: R${preco1:F2}");
             Console.WriteLine($"{produto2}, valor: R${preco2:F2}");
             Console.WriteLine("Registro: " + idade + " anos de idade, código: " + codigo + " e gênero:" + genero);
             Console.WriteLine("Medida: " + medida.ToString("F8"));
             Console.WriteLine("Medida arredondada: " + medida.ToString("F3"));
             Console.WriteLine("Medida arredondada: "+medida.ToString("F3", CultureInfo.InvariantCulture));
             */

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8.0;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            //para que o C# entenda que vc quer um resultado double, então é necessário que o formato numerido informado seja com o "." decimal ou que antes do valor seja colocado (Double)
            Console.WriteLine("-------------------------------------------");
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("Delta: " + delta);
            Console.WriteLine("X1= "+x1+", X2= "+x2);
            
        }
    }
}
