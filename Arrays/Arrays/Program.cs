using System;

namespace Vector {
    public static class Program {
        public static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            double[] vector = new double[N]; // Comando criação de Vector
            for(int i = 0; i < N; i++) {
                vector[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vector.Length; i++) {
                Console.WriteLine(vector[i]);
            }

        }
    }
}