using System;
using System.Globalization;
namespace Aula_04_Classes
{
    class Aula_04_Classes_Ex
    {
        static void Main(string[] args)
        {
            /* 
             * O exemplo abaixo mostra como funciona o acesso a uma classe que representa um triangulo.
             * as linhas comentadas são a versão sem orientação à objeto e as ativas são as com acesso a OO e à classe triangulo criada.
             * Ver Triangulo.cs que é nossa classe
            */
            //double xA, xB, xC, yA, yB, yC;
            /*
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (xA + xB + xC) / 2.0;
            //double p = (x.A + x.B + x.C) / 2.0;

            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            //double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            double areaX = x.Area();
            //p = (yA + yB + yC) / 2.0;
            //p = (y.A + y.B + y.C) / 2.0;

            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
            //double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            double areaY = y.Area();
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            */
            //Exemplo 2 de classes (ver material onenote.)
           
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Qte = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade a ser adicionada: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite a quantidade a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

        }
    }
}
