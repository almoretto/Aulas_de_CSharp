using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_02_Aula_04
{
    class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];
        public string Status;
        public double NotaFinal;
        public string ValidarAprovado()
        {
            NotaFinal = Notas[0] + Notas[1] + Notas[2];
            if (NotaFinal >= 60)
            {
                Status = Nome
                    + " Aprovado, com "
                    + NotaFinal.ToString("F2")
                    +" pontos";
            }
            else
            {
                double falta = 60 - NotaFinal;
                Status = Nome 
                    +"Reprovado e faltam: "
                    + falta.ToString("F2")
                    + " pontos para aprovação.";
            }
            return Status;
        }
    }
}
