using System;

namespace ExerciseClass8 {
      
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine());
            Console.Write("Qauntos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago: {Conversor.ConversorDeMoeda(dolar, quantia)}");
        }
    }

}