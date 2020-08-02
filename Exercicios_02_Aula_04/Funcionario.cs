namespace Exercicios_02_Aula_04
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario * (1 - (Imposto / 100));
        }
        public void AumentarSalario(double percentual)
        {
            Salario = Salario * (1 + (percentual / 100));
        }
        public override string ToString()
        {
            return "Funcionário: "
                + Nome
                + " Salário líquido: R$"
                + SalarioLiquido().ToString("F2");
           
        }

    }
}
