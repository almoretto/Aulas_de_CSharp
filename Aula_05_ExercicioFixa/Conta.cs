using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_05_ExercicioFixa
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
       
       public Conta (double saldoinicial)
        {
            Saldo = saldoinicial;
        }
        public Conta(int numero, string nome)
        {
            Nome = nome;
            Numero = numero;
            Saldo = 0.0;
        }
        public Conta(int numero, string nome, double valor) : this(numero, nome)
        {
            Deposito(valor);
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            Saldo -= valor;
            Saldo -= 5.00; //cobrança de taxa
        }
        public override string ToString()
        {
            //Dados da conta:
            //Conta 8532, Titular: Alex Green, Saldo: $ 500.00

            return "Dados da conta:\n"
                + "Conta: " + Numero
                + ", Titular: " + Nome
                + ", Saldo: $" + Saldo.ToString("F2");
        }
    }
}
