using System;
using System.Globalization; // Inicializador de controlador global

namespace OutputValues {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Bom dia!");
            Console.Write("Boa tarde!"); // Não há quebra de linha, "\n"
            Console.WriteLine("Boa noite!");

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(saldo.ToString("F2")); // Controle de casas decimais
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture)); // Invariação de separador

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); // Placeholder
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); // Interpolação .net versão 6+
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); // Concatenação
        }
    }
}