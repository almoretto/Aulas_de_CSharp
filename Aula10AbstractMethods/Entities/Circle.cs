using Aula10AbstractMethods.Entities.Enums;
using System;

namespace Aula10AbstractMethods.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        // static double pi = 3.141516;
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
