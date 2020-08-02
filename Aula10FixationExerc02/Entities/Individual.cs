namespace Aula10FixationExerc02.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; } = 0.0;

        public Individual(string name, double anualIncome, double healthExpenditures)
            :base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            //Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com
            //renda de 20000.00 em diante pagam 25 % de imposto.Se a pessoa teve gastos com saúde, 50 %
            //destes gastos são abatidos no imposto.
            double tax;
            if (AnualIncome<=20000.00)
            {
                tax=AnualIncome*0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }
            if (HealthExpenditures>0.0)
            {
                tax -= (HealthExpenditures * 0.50);
            }
            return tax;
        }
    }
}
