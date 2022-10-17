using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            // Conversion válida, double possui 8 bytes, e float 4
            float a = 5.1f;
            double b;
            b = a;
            Console.WriteLine(b);

            //Conversio inválida, temos que utilizar casting, ou seja, conversão explícita
            double c = 5.1f;
            float d;
            d = (float)c;
            Console.WriteLine(d);

            int N1 = 10;
            int N2 = 8;
            double N3 = (double) N1 / N2;
            Console.WriteLine(N3);
        }    
    }
}