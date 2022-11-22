using System;

namespace ParamsModifier {
    public static class Program {
        public static void Main(string[] args) {
            int result = Calculator.Sum(10, 20, 30);
            Console.WriteLine(result);

        }
    }
}
