using System;

namespace Aula_05_ExercicioFixa
{
    class ContaBancaria
    {
        static void Main(string[] args)
        {
            /*
             * Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do titular da conta, 
             * e o valor de depósito inicial que o titular depositou ao abrir a conta. 
             * Este valor de depósito inicial, entretanto, é opcional, ou seja: 
             * se o titular não tiver dinheiro a depositar no momento de abrir sua conta, o depósito inicial não será feito 
             * e o saldo inicial da conta será, naturalmente, zero. 
             * Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. 
             * Já o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).
             * Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso. 
             * O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque realizado, 
             * o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo 
             * se o saldo não for suficiente para realizar o saque e/ou pagar a taxa. 
             * Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não 
             * informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque,  
             * sempre mostrando os dados da conta após cada operação.
             */
            /* Entre o número da conta: 8532
             * Entre o titular da conta: Alex Green
             * Haverá depósito inicial(s / n) ? s
             * Entre o valor de depósito inicial: 500.00
             */
            int conta;
            string nome;
            double saldoInicial=0.0;
            string dep;
            bool continuar = true;
            int opcao = 1;
            Conta cc=new Conta(saldoInicial);
            do
            {
                switch (opcao)
                {
                    case 1:
                        Console.Write("Entre com o numero da conta: ");
                        conta = int.Parse(Console.ReadLine());
                        Console.Write("Entre com o titular da conta: ");
                        nome = Console.ReadLine();
                        Console.Write("Haverá depósito inicial (S/N)?");
                        dep = Console.ReadLine().ToUpper();
                        if (dep == "S")
                        {
                            Console.Write("Digite o valor do depósitop inicial: ");
                            saldoInicial = double.Parse(Console.ReadLine());
                            cc = new Conta(conta, nome, saldoInicial);
                            Console.WriteLine(cc);
                            Console.WriteLine();

                        }
                        else
                        {
                            cc = new Conta(conta, nome);
                            Console.WriteLine(cc);
                            Console.WriteLine("");
                        }
                        break;
                    case 2:

                        Console.WriteLine("");
                        Console.Write("Digite valor a ser depositado: ");
                        double valor = double.Parse(Console.ReadLine());
                        cc.Deposito(valor);
                        Console.WriteLine(cc);
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.Write("Digite valor de saque: ");
                        valor = double.Parse(Console.ReadLine());
                        cc.Saque(valor);
                        Console.WriteLine(cc);
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine(cc);
                        break;
                    case 5:
                        Console.Write("Digite o novo titular: ");
                        nome = Console.ReadLine();
                        cc.Nome = nome;
                        Console.WriteLine("");
                        Console.WriteLine(cc);
                        break;
                    default:
                        continuar = false;
                        Console.WriteLine("Opção errada: Saindo....");
                        break;
                }
                Console.Write("Continua (S/N)? ");
                string cont = Console.ReadLine().ToUpper();
                if (cont == "N")
                {
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Opção 1: Criar Conta \n"
                   + "Opção 2: Depositar \n"
                   + "Opção 3: Sacar \n"
                   + "Opção 4: Saldo \n"
                   + "Opção 5: Alterar Titularidade \n");
                    Console.Write("Digite uma opção: ");
                    opcao = int.Parse(Console.ReadLine());
                }

            } while (continuar);



        }
    }
}
