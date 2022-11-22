using System;

namespace ExerciseClass9 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n): ");
            char deposito = char.Parse(Console.ReadLine());

            ContaBancaria account = new ContaBancaria();

            if (deposito == 'n' || deposito == 'N') {
                account = new ContaBancaria(conta, nome);
            }
            else if (deposito == 's' || deposito == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double valor = double.Parse(Console.ReadLine());
                account = new ContaBancaria(conta, nome, valor);
            }

            Console.WriteLine(account);

            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            account.RealizarDeposito(valorDeposito);
            Console.WriteLine(account);

            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            account.RealizarSaque(valorSaque);
            Console.WriteLine(account);


        }
    }
}