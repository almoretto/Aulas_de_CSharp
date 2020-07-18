using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_02_Aula_04
{
    class ConversorDeMoeda
    {
        public static double Cotacao;

        public static double ConverterMoeda(double compra)
        {
            return compra * Cotacao;
        }
        public static double CalcularIOF(double compra)
        {
            return (compra*Cotacao)*0.06;
        }

        

    }
}
