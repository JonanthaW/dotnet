using System;
using System.Globalization;

namespace ExerciseClass5 {
    public class Program {
        static void Main(string[] args) {

            Retangulo R;
            R = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            R.Largura = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            R.Altura = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            Console.WriteLine($"AREA = {R.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {R.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {R.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}