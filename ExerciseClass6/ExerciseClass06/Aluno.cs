using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClass7 {
    internal class Aluno {

        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double CalcularNota() {
            return Nota1 + Nota2 + Nota3;
        }

        public string DecisaoNota() {
            if (CalcularNota() >= 60.0)
                return "APROVADO";
            else
                return $"REPROVADO\nFALTARAM {60.0 - CalcularNota()} PONTOS";
        }

    }
}
