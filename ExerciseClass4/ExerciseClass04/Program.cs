using System;
using System.Globalization;

namespace ExerciseClass04 {
    public class Program { 
        static void Main(string[] args) {

            Produto p1;
            p1 = new Produto();
            int Quantity = 0;

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados do produto: {p1}");
            
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            Quantity = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(Quantity);
            Console.WriteLine($"Dados atualizados: {p1}");


            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            Quantity = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(Quantity);
            Console.WriteLine($"Dados atualizados: {p1}");
        }
    }
}