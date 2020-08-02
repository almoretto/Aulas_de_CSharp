using System;
using System.Collections.Generic;
using System.Text;
using Aula10AbstractMethods.Entities.Enums;

namespace Aula10AbstractMethods.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }


}
