using System;
using System.Collections.Generic;

namespace ExerciseList01 {
    public class Program {
        public static void Main(string[] args) {
            Console.Write("Quantos empregados serão registrados? ");
            int empregados = int.Parse(Console.ReadLine());

            List<Employee> lista = new List<Employee>();

            for (int i = 1; i <= empregados; i++) {
                Console.WriteLine($"Empregado {i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                lista.Add(new Employee(id, nome, salario));
               
            }

            Console.Write("Coloque o ID do funcionário que terá o salário aumentado: ");
            int aumentoSalario = int.Parse(Console.ReadLine());

            Employee emp= lista.Find(x => x.Id == aumentoSalario);
            if (emp != null) {
                Console.Write("Quanto a porcentagem desse aumento? ");
                int porcentagemAumentoSalario = int.Parse(Console.ReadLine());
                emp.increaseSalary(porcentagemAumentoSalario);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }


        }
    }
}