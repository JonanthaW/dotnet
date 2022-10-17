using System;
using System.Globalization;

namespace Exercise2 {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] valores = Console.ReadLine().Split(" ");

            string valNome = valores[0];
            int valIdade = int.Parse(valores[1]);
            double valAltura = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("\n");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(valNome);
            Console.WriteLine(valIdade);
            Console.WriteLine(valAltura.ToString(CultureInfo.InvariantCulture));


        }
    }
}