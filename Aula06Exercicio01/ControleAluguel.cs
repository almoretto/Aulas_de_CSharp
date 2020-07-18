using System;

namespace Aula06Exercicio01
{
    class ControleAluguel
    {
        /// <summary>
        ///     A dona de um pensionato possui dez quartos para alugar para estudantes,
        ///     sendo esses quartos identificados pelos números 0 a 9.
        ///     Quando um estudante deseja alugar um quarto, deve-se registrar o nome e email deste estudante.
        ///     1) Fazer um programa que inicie com todos os dez quartos vazios, e depois
        ///     2)leia uma quantidade N representando o número de estudantes que vão alugar quartos (N pode ser de 1 a 10). 
        ///     Em seguida, registre o aluguel dos N estudantes.
        ///     Para cada registro de aluguel, informar o nome e email do estudante, bem como qual dos quartos ele escolheu(de 0 a 9). 
        ///     Suponha que seja escolhido um quarto vago.
        ///     Ao final, seu programa deve imprimir um relatório de todas ocupações do pensionato, por ordem de quarto, conforme exemplo.
        /// </summary>
        static void Main(string[] args)
        {
            //1) inicialização dos 10 quartos
            HostStudent[] hostel = new HostStudent[10];
            //2) Ler quantos hospedes
            int n = 11;
            while (n > 10) //Garantir se a entrada não ultrapassa 10 quartos
            {
                Console.Write("Digite a quentidade de hóspedes: ");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++) //populando a classe
            {
                Console.Write("Nome do Hospede: ");
                string nome = Console.ReadLine();
                Console.Write("Email do Hospede: ");
                string email = Console.ReadLine();
                Console.Write("Selecione o Quarto (de 0 a 9): ");
                int quarto = int.Parse(Console.ReadLine());
                //"hospedando" o hospede no quarto desejado
                hostel[quarto] = new HostStudent { Name = nome, Email = email, Room = quarto };
            }
            for (int i = 0; i < 10; i++)
            {
                if (hostel[i] != null)
                {
                    Console.WriteLine(hostel[i]);
                }
            }

        }
    }
}
