using System;

namespace Folha_Exercicios_03
{
    class Folha_EX_03
    {
        static void Main(string[] args)
        {
            //Exercício 1
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1114/uri1114/Program.cs
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
            incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.*/
            /*
            int senha = 2002;
            Console.Write("Type your password:");
            int TypedPass = int.Parse(Console.ReadLine());
            
            while (senha!=TypedPass)
            {
                Console.WriteLine("Senha Inválida!");
                Console.WriteLine("---");
                Console.Write("Type your password:");
                TypedPass = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("----=========----");
            Console.WriteLine("Acesso Permitido!");
            Console.WriteLine("----=========----");
            */

            //Exercício 02
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1115/uri1115/Program.cs
            /* Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
               cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
               menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).*/
            /*
            Console.Write("Por favor digite as coordenadas X;Y:");
            string[] coordenadas = Console.ReadLine().Split(';');
            double x = double.Parse(coordenadas[0]);
            double y = double.Parse(coordenadas[1]);
            double[] xy = new double[2];
            while (x != 0.0 && y != 0.0)
            {
                if (x < 0.0 && y < 0.0)
                {
                    Console.WriteLine("Coordenada do quadrante 3.");
                }
                else if (x < 0.0 && y > 0.0)
                {
                    Console.WriteLine("Coordenada do quadrante 2.");
                }
                else if (x > 0.0 && y < 0.0)
                {
                    Console.WriteLine("Coordenada do quadrante 4.");
                }
                else if (x > 0.0 && y > 0.0)
                {
                    Console.WriteLine("Coordenada do quadrate 1.");
                }
                else if (x == 0.0 && y != 0.0)
                {
                    Console.WriteLine("Coordenada no eixo 'X'.");
                }
                else if (x != 0.0 && y == 0)
                {
                    Console.WriteLine("Coordenada no eixo 'Y'.");
                }
                else
                {
                    Console.WriteLine("ERRO");
                }
                xy = GetCoordinates();
                x = xy[0];
                y = xy[1];
            }//While Close Bracket
            */
            //Exercício 03
            /*Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1134/uri1134/Program.cs
            Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). 
            Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até que seja válido). 
            O programa será encerrado quando o código informado for o número 4.Deve ser escrito a mensagem: "MUITO OBRIGADO" e a 
            quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.*/
            /*
            Console.WriteLine("Digite 1 para Alcool, 2 para Gasolina 3 para Diesel ou 4 FIM");
            Console.Write("Digite qual o combustivel foi abastecido: ");
            int comb = int.Parse(Console.ReadLine());
            int alc = 0, gas = 0, dsl = 0;
            while (comb != 4)
            {
                if (comb == 1)
                {
                    alc++;
                }
                else if (comb == 2)
                {
                    gas++;
                }
                else if (comb == 3)
                {
                    dsl++;
                }
                else
                {
                    Console.WriteLine();
                }
                Console.Write("Digite qual o combustivel foi abastecido: ");
                comb = int.Parse(Console.ReadLine());

            }//while close
            Console.WriteLine();
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine();
            Console.WriteLine("Resumo:");
            Console.WriteLine("Alcool: " + alc);
            Console.WriteLine("Gasolina: " + gas);
            Console.WriteLine("Diesel: " + dsl);
            */



        }//Main Close Bracket

        static double[] GetCoordinates()
        {
            Console.Write("Por favor digite as coordenadas X;Y:");
            string[] coordenadas = Console.ReadLine().Split(';');
            double x = double.Parse(coordenadas[0]);
            double y = double.Parse(coordenadas[1]);
            double[] RCoordinates = new double[2];
            RCoordinates[0] = x;
            RCoordinates[1] = y;
            return RCoordinates;
        }

    }
}
