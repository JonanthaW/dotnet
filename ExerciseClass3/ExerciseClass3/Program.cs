using System;
using System.Globalization;

namespace ExerciseClass3 {
    public class Program {
        static void Main(string[] args) {

            funcionario p1, p2;
            p1 = new funcionario();
            p2 = new funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Salário médio {double.Parse(((p1.Salario + p2.Salario) / 2).ToString(CultureInfo.InvariantCulture))}");
        }
    }
}