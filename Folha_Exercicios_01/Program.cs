using System;

namespace Folha_Exercicios_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 01
            /*
            int a, b, resultado;

            Console.Write("Digite valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite valor de b: ");
            b = int.Parse(Console.ReadLine());

            resultado = a + b;
            Console.WriteLine("A Soma de a + b = " + resultado);
            Console.WriteLine();
            //Exercicio 02
            Console.WriteLine("---------------------------Area do Circulo---------------------------");
            Console.WriteLine();

            double pi = 3.14159;
            double raio, area;
            Console.Write("Digite o raio da circunferência em centímetros: ");
            raio = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(raio, 2);
            Console.WriteLine($"A área da circunferência de {raio}cm de raio é: {area:F4}cm2");
            
            Console.WriteLine();
            //Exercicio 03
            Console.WriteLine("-------------------------Diferença entre produtos--------------------");
            Console.WriteLine();
            
            int va, vb, vc, vd, dif;
            Console.Write("digite o valor de va: ");
            va = int.Parse(Console.ReadLine());
            Console.Write("digite o valor de vb: ");
            vb = int.Parse(Console.ReadLine());
            Console.Write("digite o valor de vc: ");
            vc = int.Parse(Console.ReadLine());
            Console.Write("digite o valor de vd: ");
            vd = int.Parse(Console.ReadLine());
            dif = (va * vb) - (vc * vd);
            Console.WriteLine("A diferença entre os produtos é: " + dif);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------Valor do pedido------------------------------");
            Console.WriteLine();

            byte produto1, produto2, qte1, qte2;
            float valor1, valor2, total;
            Console.Write("Digite o codigo do produto 1: ");
            produto1 = byte.Parse(Console.ReadLine());
            Console.Write("Digite o codigo do produto 2: ");
            produto2 = byte.Parse(Console.ReadLine());
            Console.Write("digite a quantidade comprada para 1: ");
            qte1 = byte.Parse(Console.ReadLine());
            Console.Write("digite a quantidade comprada para 2: ");
            qte2 = byte.Parse(Console.ReadLine());
            Console.Write("digite o valor para 1: ");
            valor1 = float.Parse(Console.ReadLine());
            Console.Write("digite o valor para 2: ");
            valor2 = float.Parse(Console.ReadLine());
            total = (qte1 * valor1) + (qte2 * valor2);
            Console.WriteLine("pedido:");
            Console.WriteLine("COD:     Qte:    Valor:");
            Console.WriteLine(produto1 + "        " + qte1 + "        " + valor1);
            Console.WriteLine(produto2 + "        " + qte2 + "        " + valor2);
            Console.WriteLine($"O valor total do pedido é: {total:F2}");
            */
            Console.WriteLine("----------------------------Geometria Plana------------------------");
            Console.WriteLine();

            /*Exercicio 6: Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
                a) a área do triângulo retângulo que tem A por base e C por altura.
                b) a área do círculo de raio C. (pi = 3.14159)
                c) a área do trapézio que tem A e B por bases e C por altura.
                d) a área do quadrado que tem lado B.
                e) a área do retângulo que tem lados A e B.
                */

            double A, B, C, AreaT, AreaC, AreaTr, AreaQ, AreaR;
            //-----a)a área do triângulo retângulo que tem A por base e C por altura.------
            Console.Write("Digite os valores de A, B e C, digitando enter a cada inserção: ");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            AreaT = C * (A / 2);
            Console.WriteLine("Área do Triangulo base " + A + " altura " + C + " é: " + AreaT.ToString("F2"));

            //b) a área do círculo de raio C. (pi = 3.14159)
            AreaC = 3.14159 * Math.Pow(C, 2);
            Console.WriteLine("A área do circulo de raio " + C + "é: " + AreaC.ToString("F2"));

            // c) a área do trapézio que tem A e B por bases e C por altura.
            AreaTr = (A + B) * (C / 2);
            Console.WriteLine("A Area do trapézio de base menor " + A + ", Base maior " + B + " e altura " + C + " é: " + AreaTr.ToString("F2"));

            // d) a área do quadrado que tem lado B
            AreaQ = Math.Pow(B, 2);
            Console.WriteLine("A área do quadrado de lado " + B + " é: " + AreaQ.ToString("F2"));

            //e) a área do retângulo que tem lados A e B
            AreaR = A * B;
            Console.WriteLine("Area do retângulo laso "+A+ " e "+B+" é: "+AreaR.ToString("F2"));


        }


    }
}
