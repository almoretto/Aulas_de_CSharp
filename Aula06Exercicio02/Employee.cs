namespace Aula06Exercicio02
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int code, string empname, double amount)
        {
            Id = code;
            Name = empname;
            SetSalary(amount);
        }
        private void SetSalary(double value)
        {
            Salary = value;
        }
        public void IncreaseSalary(double percentual)
        {
            Salary = (1 + (percentual / 100) * Salary);
        }
        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary;
        }

    }
}
