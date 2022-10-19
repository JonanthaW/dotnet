using System;
using System.Globalization;

namespace ExerciseClass6 {
    public class Program {
        static void Main(string[] args) {

            Funcionario pessoa;
            pessoa = new Funcionario();

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.Write("Imposto: ");
            pessoa.Imposto = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            Console.WriteLine($"Funcionário: {pessoa}");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double Aumento = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            pessoa.AumentarSalario(Aumento);

            Console.WriteLine($"Dados atualizados: {pessoa}");



        }
    }
}