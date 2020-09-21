using System.Globalization;
using System;

namespace Aula14Icomparable.Entities
{
    class Employees : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employees(string csvEmployee)
        {
            string[] emp = csvEmployee.Split(';');
            Name = emp[0];
            Salary = double.Parse(emp[1], CultureInfo.InvariantCulture);

        }

        public override string ToString()
        {
            return Name + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employees))
            {
                throw new ArgumentException("Comparring error: Argument is not an Employee");
            }
            Employees other = obj as Employees;
            return Name.CompareTo(other.Name);
        }
    }
}
