using System;
using System.Globalization;

namespace InputValues {
    public class InputValue {
        static void Main(string[] args) {

            // bom dia!
            string frase = Console.ReadLine();
            Console.WriteLine(frase);


            // amarelo
            // azul
            // cinza
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            // batata tomate abacaxi
            string[] vetor = Console.ReadLine().Split(' ');

            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(vetor[2]);


            // conversão usando Parse

            // Números
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);

            // character
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(ch);

            // double
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(n2);

            string[] vet = Console.ReadLine().Split(" ");
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine($"{nome}, {sexo}, {idade}, {altura}");



        }
    }
}