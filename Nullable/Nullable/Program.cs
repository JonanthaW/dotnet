using System;

namespace Nullable {
    public static class Program {
        public static void Main(string[] args) {

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // Pega o valor ou 0 (Caso não tenha valor algum).
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");


            // Operador de coalescência nula

            double a = x ?? 5; // Caso o valor de X seja nulo, ele pega o 5

            Console.WriteLine(a);

            
        }
    }
}