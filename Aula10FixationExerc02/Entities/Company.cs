namespace Aula10FixationExerc02.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees {get; set; }

        public Company(string name, double anualIncome,int numberOfEmployees)
            :base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            //pessoas jurídicas pagam 16% de imposto. 
            //Porém, se a empresa possuir mais de 10 funcionários, ela paga 14 % de imposto.
            double tax;
            if (NumberOfEmployees>10)
            {
                tax = AnualIncome * 0.14;
            }
            else
            {
                tax = AnualIncome * 0.16;
            }
            return tax;
        }
    }
}
