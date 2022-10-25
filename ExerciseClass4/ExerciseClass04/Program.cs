using System;
using System.Globalization;

namespace ExerciseClass04 {
    public class Program { 
        static void Main(string[] args) {


            Console.WriteLine("Entre os dados do produto");

            Console.Write("Nome: ");
            string Nome = Console.ReadLine();

            Console.Write("Preço: ");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int Quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(Nome, Preco, Quantidade);

            Console.WriteLine($"Dados do produto: {p1}");
            
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int Quantity = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(Quantity);
            Console.WriteLine($"Dados atualizados: {p1}");


            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            Quantity = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(Quantity);
            Console.WriteLine($"Dados atualizados: {p1}");
        }
    }
}