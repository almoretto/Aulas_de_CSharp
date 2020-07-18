using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_04_Classes
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
            if (NotaFinal>=60)
            {
                Status = "Aprovado";
            }
            else
            {
                double falta = 60 - NotaFinal;
                Status = "Reprovado e faltam: "
                    + falta
                    + "pontos para aprovação.";
            }
            return Status;
        }
    }
}
