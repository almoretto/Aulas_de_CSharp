using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AUla_05_Construtores
{
    class Produto
    {

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        /*
         * declaração direta precisa criar get; set;
        private double _preco; 
        private int _quantidade;
        */
        public Produto()
        {
            Quantidade = 0;
        }
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
            // _quantidade = 0;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            //_nome = nome;
            //_preco = preco;
            Quantidade = quantidade;
        }
        public string Nome //Declaração de properties
        {
            get { return _nome; }
            set
            {
                //Utilizamos o comando value no lugar do parâmetro de entrada
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        /* criado como auto properties em cima
        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }
        */
        /*
         * Implementação manual de Get Set
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuant()
        {
            return _quantidade;
        }
        */
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
