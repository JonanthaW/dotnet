using System;
using System.Globalization;

namespace ExerciseClass7 {
    public class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            aluno.Nota2 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            aluno.Nota3 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            Console.WriteLine($"NOTA FINAL = {aluno.CalcularNota().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(aluno.DecisaoNota());

        }
    }
}