using System;

namespace Aula06Exercicio04
{
    class Program
    {
        /// <summary>
        /// Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas 
        /// contendo números inteiros, podendo haver repetições. Em seguida, ler um número inteiro X que pertence à matriz.
        /// Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver, conforme exemplo.
        /// </summary>

        static void Main(string[] args)
        {
            int m, n, x;
            Console.Write("Digite a ordem m da matriz: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite a ordem n da matriz: ");
            n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] matvar = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(matvar[j]);
                }

            }
            Console.Write("Digite um número inteiro para busca: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x == matrix[i, j])
                    {
                        Console.WriteLine("Numero: " + x + " está na posição [" + i + "," + j + "]");
                        if ((j - 1) >= 0 && (j - 1) < n)
                        {
                            Console.WriteLine("Esquerda: " + matrix[i, (j - 1)]);
                        }
                        if ((j + 1) < n && (j + 1) >= 0)
                        {
                            Console.WriteLine("Direita: " + matrix[i, (j + 1)]);
                        }
                        if ((i - 1) >= 0 && (i - 1) < m)
                        {
                            Console.WriteLine("Acima: " + matrix[(i - 1), j]);
                        }
                        if ((i + 1) < m && (i + 1) >= 0)
                        {
                            Console.WriteLine("Abaixo: " + matrix[(i + 1), j]);
                        }
                    }
                }

            }


        }
    }
}
