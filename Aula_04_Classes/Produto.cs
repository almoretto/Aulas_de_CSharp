using System.Globalization;

namespace Aula_04_Classes
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qte;

        public double ValorTotalEmEstoque()
        {
            return Preco * Qte;
        }
        public void AdicionarProdutos(int quant)
        {
            Qte += quant;

        }
        public void RemoverProdutos(int quant)
        {
            Qte -= quant;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Qte
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
