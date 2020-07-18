using System;

namespace Exercicios_02_Aula_04
{
    class EX_02_A_04
    {
        static void Main(string[] args)
        {
            /*Exercício 01
             * Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de 
             * sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado.
             */
            /*
            Retangulo ret = new Retangulo();
            Console.Write("Digite a altura do retângulo: ");
            ret.Altura = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Área do retângulo: "+ret.Area());
            Console.WriteLine("Perímetro do retângulo: " + ret.Perimetro());
            Console.WriteLine("Diagonal do retângulo: " + ret.Diagonal().ToString("F2"));
            */
            /*Exercício 02 Fixação
             * Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). 
             * Em seguida, mostrar os dados do funcionário (nome e salário líquido). 
             * Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto éafetado pela porcentagem) 
             * e mostrar novamente os dados do funcionário. Use a classe projetada abaixo.
             */
            /*
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Digite os dados do funcionário:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(funcionario);
            Console.WriteLine();
            Console.Write("Informe o percentual de reajuste: ");
            double aumento = double.Parse(Console.ReadLine());
            //Lembrar que para chamar os métodos de uma classe eu uso minha variável tipo classe instanciada
            funcionario.AumentarSalario(aumento);
            Console.WriteLine();
            Console.WriteLine("---===Recalculo===---");
            Console.WriteLine(funcionario);
            */
            /*Exercício 03
             * Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano 
             * (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. 
             * Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). 
             * Você deve criar uma classe Aluno para resolver este problema.
             */
            /*
            Aluno aluno = new Aluno();
            Console.WriteLine("Digite dos dados do Aluno:");
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                int tri = i + 1;
                Console.Write("Nota "+tri+"º Trimestre: ");
                aluno.Notas[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(aluno.ValidarAprovado());
            */
            /* Exercicio Fixação Membros estáticos
             * Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais. 
             * Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. 
             * Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.
             */
            double compra, reais, iof, total;

            Console.Write("Digite a Cotação do Dólar: ");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares vc que compar? ");
            compra = double.Parse(Console.ReadLine());
            reais = ConversorDeMoeda.ConverterMoeda(compra);
            iof = ConversorDeMoeda.CalcularIOF(compra);
            total = reais + iof;
            Console.WriteLine("Você irá comprar " + compra + " dólares que equivale à: " + reais.ToString("F2"));
            Console.WriteLine("Total a pagar: " 
                + reais.ToString("F2") 
                + " mais 6% de IOF " 
                + iof.ToString("F2") 
                + " = " 
                + total.ToString("F2"));
        }
    }
}
