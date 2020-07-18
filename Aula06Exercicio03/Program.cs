using System;

namespace Aula06Exercicio03
{
    class Program
    {
        /// <summary>
        /// Fazer um programa para ler um número inteiro N e uma matriz de 
        /// ordem N contendo números inteiros.Em seguida, mostrar a diagonal 
        /// principal e a quantidade de valores negativos da matriz.
        /// </summary>
        /// <param name="args"></param>
        /*
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);

        }
    }
}
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' '); //maneira 2
                for (int j = 0; j < n; j++)
                {
                    /* matrix[i, j] = int.Parse(Console.ReadLine()); //Maneira 1*/
                    matrix[i, j] = int.Parse(values[j]); //maneira 2 usando o split
                }
            }
            Console.WriteLine();
            //imprime diag principal
            Console.Write("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, i] + " ");                
            }
            //Ver negativos
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j]<0)
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine("A matriz possui "+ count + " números negativos");
        }
    }
}
