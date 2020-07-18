using System;

namespace Folha_Exercicios_02
{
    class Folha_EX_02
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.                
            //Ex 01: Solução 01  https://github.com/acenelio/nivelamento-csharp/blob/master/cond01/cond01/Program.cs
            //Minha Solução:
            /*
            Console.WriteLine("Digite um numero inteiro: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Número " + num + " é negativo");
            }
            else
            {
                Console.WriteLine("Número " + num + " não é negativo");
            }
            */
            /*
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            //Ex 02: Solução 01  https://github.com/acenelio/nivelamento-csharp/blob/master/cond02/cond02/Program.cs
            //Minha Solução:
            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            */
            /*
            //Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao saoMultiplos", indicando se os valores lidos são múltiplos entre si. 
            //Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.
            //Ex 03: Solução 01 https://github.com/acenelio/nivelamento-csharp/blob/master/uri1044/uri1044/Program.cs
            //Minha Solução:
            Console.WriteLine("Digite dois valores A e B.");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int t = 0, div = 0;
            if (A > B)
            {
                t = A % B;
                if (t == 0)
                {
                    div = A / B;
                    Console.WriteLine("B: " + B + " é Multiplo de A: " + A + " por " + div);
                }
                else
                {
                    Console.WriteLine("A e B não são Multiplos");
                }
            }
            else if (A == B)
            {
                t = A / B;
                Console.WriteLine("todo numero é multiplo dele mesmo quando multiplicado por " + t);
            }
            else
            {
                t = B % A;
                if (t == 0)
                {
                    div = B / A;
                    Console.WriteLine("A: " + A + " é Multiplo de B: " + B + " por " + div);
                }
                else
                {
                    Console.WriteLine("A e B não são Multiplos");
                }
            }
            */

            //Leia a hora inicial e a hora final de um jogo. 
            //A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            //Ex 04 Solução 1: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1046/uri1046/Program.cs
            //Minha Solução 
            /*
            DateTime sTime = DateTime.Now;
            DateTime eTime = DateTime.Now;
            DateTime ifTime = new DateTime(1990, 01, 01, 12, 0, 0);
            Console.WriteLine(ifTime);

            Console.Write("Digite a hora de inicio da partida: ");
            sTime = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite a hora final da partida: ");
            eTime = DateTime.Parse(Console.ReadLine());

            TimeSpan duration = eTime.Subtract(sTime);
            Console.WriteLine("A Duração do Jogo foi de: " + duration);
            */
            //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. 
            //A seguir, calcule e mostre o valor da conta a pagar.
            // Ex 05 Solução 1:https://github.com/acenelio/nivelamento-csharp/blob/master/uri1038/uri1038/Program.cs
            //Minha Solução:
            /*
            string[] consumo;
            Console.WriteLine("Digite o cod e qte consumida");
            consumo = Console.ReadLine().Split(' ');
            int cod = int.Parse(consumo[0]);
            int qte = int.Parse(consumo[1]);
            double total = 0.0;
            if (cod == 1)
            {
                total = qte * 4.00;
                Console.WriteLine("Total: " + total);
            }
            else if (cod == 2)
            {
                total = qte * 4.50;
                Console.WriteLine("Total: " + total);
            }
            else if (cod == 3)
            {
                total = qte * 5.00;
                Console.WriteLine("Total: " + total);
            }
            else if (cod == 4)
            {
                total = qte * 2.00;
                Console.WriteLine("Total: " + total);
            }
            else if (cod == 5)
            {
                total = qte * 1.50;
                Console.WriteLine("Total: " + total);
            }
            else
            {
                Console.WriteLine("Codigo não encontrado");
            }
            */
            //Exercício 06
            // Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo 
            //em qual dos seguintes intervalos:([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. 
            //Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
            //Solução 1: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1037/uri1037/Program.cs
            //Minha Solução:
            /*
            Console.WriteLine("Digite um valor");
            int valor = int.Parse(Console.ReadLine());
            if (valor < 0 || valor > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valor <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor <= 50)
            {
                Console.WriteLine("Intervalo entre (25,50]");
            }
            else if (valor <= 75)
            {
                Console.WriteLine("Intervalo entre (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalor entre (75,100]");
            }
            */
            //Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. 
            //A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
            //Se o ponto estiver na origem, escreva a mensagem “Origem”.
            //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
            //Exercício 07 Solução 1: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1041/uri1041/Program.cs
            //Minha Solução:
            /*
            Console.Write("Por favor digite as coordenadas X,Y:");
            string[] coordenadas = Console.ReadLine().Split(',');
            double x = double.Parse(coordenadas[0]);
            double y = double.Parse(coordenadas[1]);
            x.ToString("F1");
            y.ToString("F1");
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
            else if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Coordenada na origem.");
            }
            else if (x == 0.0 && y != 0.0)
            {
                Console.WriteLine("Coordenada no eixo 'X'.");
            }
            else if (x!=0.0 && y==0)
            {
                Console.WriteLine("Coordenada no eixo 'Y'.");
            }
            else
            {
                Console.WriteLine("ERRO");
            }
            */
            //Exercício 08 
            //Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            //que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, 
            //sem qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$.
            //Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            //mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
            //Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
            //salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido(abaixo), a taxa é
            //de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
            //duas casas decimais.
            //Solução 1: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1051/uri1051/Program.cs
            //Minha Solução:
            
            Console.Write("Digite o valor do seu salário: ");
            double salario = double.Parse(Console.ReadLine());
            double faixacalc, faixa2, faixa3;
            double imposto = 0.00;
            if (salario < 2000.00)
            {
                faixacalc = salario - 2000.00;
                Console.WriteLine("Faixa de cálculo: " + faixacalc + " imposto devido: " + imposto);
            }
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                faixacalc = salario - 2000.00;
                imposto = faixacalc * 0.08;
                Console.WriteLine("salario: "+salario);
                Console.WriteLine("Faixa de cálculo: " + faixacalc + " Impsto devido: " + imposto.ToString("F2"));
            }
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                faixacalc = salario - 2000.00;
                faixa2 = faixacalc - 1000.00;
                imposto = (1000.00 * 0.08) + (faixa2 * 0.18);
                Console.WriteLine("Salario: "+salario);
                Console.WriteLine("Acima faixa 1: "+faixa2);
                Console.WriteLine("Faixa de cálculo: "+faixacalc+ " imposto devido: "+imposto.ToString("F2"));
            }
            else if (salario>4500.00)
            {
                faixacalc = salario - 2000.00;
                faixa2 = faixacalc - 1000;
                faixa3 = faixa2 - 1500;
                imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + (faixa3 * 0.28);
                Console.WriteLine("Salário: "+salario);
                Console.WriteLine("Acima da faixa 2: "+faixa3);
                Console.WriteLine("Faixa de cálculo: "+faixacalc+" imposto devido: "+imposto.ToString("F2"));
            }
            else
            {
                Console.WriteLine("ERRO");
            }
            
               
        }
    }
}
