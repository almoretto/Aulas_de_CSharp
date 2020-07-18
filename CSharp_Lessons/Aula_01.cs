using System; //Clase System do .net CORE
using System.Globalization;

namespace CSharp_Lessons
{
    class Aula_01
    {
        /// <summary>
        /// Abaixo o bloco de código representa um Método chamado "Main"
        /// Assim como "Console" é uma classe que tem os metodos "WriteLine" e "ReadLine"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Aula01
            //Console.WriteLine("Hello World!"); 

            //Aula02 - Operações Aritméticas
            /*int x;
            int y;
            x = 7;
            y = x + 3;
            Console.Write("O valor de y=x+3 é: y= ");
            Console.WriteLine(y);
            */

            //Aula03 Declaração de variáveis

            /*
            byte var1 = 126;
            int var2 = 1000;
            long var3 = 321231564564L;  //Quando for utilizar atribuição direta de variável do tipo "long" na terminação do número colocar "L".
            bool completo = false;
            char sexo = 'N';
            char letra = '\u0040';
            float valor = 4.5f; //para variáveis do tipo float precisamos colocar o 'f' na frente do valor;
            
            Console.WriteLine(sexo);
            Console.WriteLine(letra);
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            */
            //Início da aula 4
           
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            char w = 'F';

            Console.Write("Olá¡ mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2")); //.ToString("F2") restringe o campo doubble a duas casas decimais. F3 = 3 casas, F4 = 4 Casas com arredondamento
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); //CultureInfo.InvariantCulture altera a "," do decimal para "."
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //placeholder com índice
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //Placeholder com nomes
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
            + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); //concatenação

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + saldo);
            Console.WriteLine("O valor do troco Ã© " + saldo + " reais");
            Console.WriteLine("O valor do troco Ã© " + saldo.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + nome + " tem " + idade + " anos e seu sexo é: " + w);

            Console.ReadLine();

            Console.ReadLine(); ///Pausa


        }
    }
}
