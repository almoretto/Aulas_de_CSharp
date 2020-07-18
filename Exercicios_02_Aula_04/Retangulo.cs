﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_02_Aula_04
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (2 * (Largura + Altura));
        }
        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Largura, 2) + Math.Pow(Altura, 2)));
        }
    }

}
