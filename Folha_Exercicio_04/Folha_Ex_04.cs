using System;

namespace Folha_Exercicio_04
{
    class Folha_Ex_04
    {
        static void Main(string[] args)
        {
            //Lista de exercícios 04 FOR
            //Exercício 01
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1067/uri1067/Program.cs
            //Leia um valor inteiro X(1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
            /*
            int x = 0, impar = 0, mod2 = 0;

            while (x < 1 || x > 1000)
            {
                Console.Write("Digite um valor: ");
                x = int.Parse(Console.ReadLine());
                if (x < 1 || x > 1000)
                {
                    Console.WriteLine("Numero fora do escopo digite novamente");
                }
            }
            //for (para inicio; ate que falso ; incremento)
            for (int i = 1; i <= x; i++)
            {
                mod2 = i % 2;
                if (mod2 != 0)
                {
                    impar = i;
                    Console.WriteLine(impar);
                }

            }*/
            //Exercício 02
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1072/uri1072/Program.cs
            //Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            /*
            Console.WriteLine("Quantos numeros você quer testar?");
            int n = int.Parse(Console.ReadLine());
            int[] X = new int[n];
            int inint=0,outint= 0;
            Console.WriteLine("Digite "+n+" números, dando enter a cada um");
            for (int i = 0; i < n; i++)
            {
                X[i] = int.Parse(Console.ReadLine());
                if (X[i]>=10 && X[i]<=20)
                {
                    inint++;
                }
                else
                {
                    outint++;
                }
            }
            Console.WriteLine(inint+" in");
            Console.WriteLine(outint+" out");
            */
            //Exercício 03
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1079/uri1079/Program.cs
            //Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            //de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            //conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
            /*
            Console.WriteLine("Quantas médias deseja calcular?");
            int n = int.Parse(Console.ReadLine());
            double[] ponderar = new double[3];
            double ponderada;
            int p1 = 2, p2 = 3, p3 = 5;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite os 3 valores para calcular separados com ';'");
                string[] temp = Console.ReadLine().Split(';');
                for (int j = 0; j < 3; j++)
                {
                    ponderar[j] = double.Parse(temp[j]);
                }
                ponderada = ((ponderar[0] * p1) + (ponderar[1] * p2) + (ponderar[2] * p3)) / (p1 + p2 + p3);
                Console.WriteLine("Média ponderada= " + ponderada.ToString("F1"));
            }*/
            //Exercício 04
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1116/uri1116/Program.cs
            //Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            //segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
            /*
            Console.WriteLine("Quantos pares deseja calcular?");
            int n = int.Parse(Console.ReadLine());
            double[] par1 = new double[n];
            double[] par2 = new double[n];
            double[] divisao = new double[n];

            for (int i = 1; i <= n; i++)
            {
                int n2 = i - 1;
                Console.WriteLine("digite cada numero seguido de enter");
                par1[n2] = int.Parse(Console.ReadLine());
                par2[n2] = int.Parse(Console.ReadLine());
                if (par2[n2] != 0)
                {
                    divisao[n2] = par1[n2] / par2[n2];
                    Console.WriteLine("Divisão "+i+" = "+divisao[n2].ToString("F2"));
                }
                else
                {
                    Console.WriteLine("Divisão Impossível");
                }
            }*/

            //Exercício 05
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1153/uri1153/Program.cs
            //Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.
            //Lembrando que, por definição, fatorial de 0 é 1.
            /*
            Console.WriteLine("Digite um numero inteiro e iremos calcular o fatorial");
            int n = int.Parse(Console.ReadLine());
            long fatorial = 1L;
            if (n==0)
            {
                Console.WriteLine("Resultado: " + n + "!= 1");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fatorial = fatorial * i;
                }
                Console.WriteLine("Resultado: " + n + "!= " + fatorial);
            }*/

            //Exercício 06
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1157/uri1157/Program.cs
            //Ler um número inteiro N e calcular todos os seus divisores.
            /*
            Console.WriteLine("Digite um numero inteiro e iremos calcular os divisores");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            //Exercício 07
            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1143/uri1143/Program.cs
            //Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            //começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor.

            Console.WriteLine("Digite um numero inteiro");
            int n = int.Parse(Console.ReadLine());
            while (n < 0)
            {
                Console.WriteLine("Não pode ser numero negativo");
                Console.WriteLine("Digite um numero inteiro");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i+" ");
                Console.Write(Math.Pow(i, 2)+" ");
                Console.Write(Math.Pow(i, 3));
                Console.WriteLine();
            }


        }//end main
    }
}
