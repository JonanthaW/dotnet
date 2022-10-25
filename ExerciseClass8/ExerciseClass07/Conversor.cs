using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClass8 {
      class Conversor {
        public static double ConversorDeMoeda(double cotacao, double valor) {
            return (valor * cotacao) + ((valor * cotacao) * 0.06);
        }
    }
}
