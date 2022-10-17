using System;

namespace BasicTypes {
    public class Program {
        static void Main(string[] args) {
            SByte x = 100;
            Console.WriteLine(x);

            Byte N1 = 255;
            N1++; // Overflow de valor, ele pula ao limite oposto.
            Console.WriteLine(N1);

            int N2 = 1000;
            int N3 = 217483647;
            long N4 = 2147483648;
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine(N4);

            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'f'; // aspas simples
            Console.WriteLine(genero);

            char unicode = '\u0041'; // letra A em Unicode
            Console.WriteLine(unicode);

            float N5 = 4.5f;
            Console.WriteLine(N5);

            double N6 = 4.5d;
            Console.WriteLine(N6);

            string nome = "MARIA"; /// aspas duplas
            Console.WriteLine(nome);

            object OBJ1 = "Alex Brown";
            Console.WriteLine(OBJ1);


            /*                            */
            Console.WriteLine('\n');
            // Funções para valores mínimos e máximos

            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(Int32.MinValue);

        }
    }
}