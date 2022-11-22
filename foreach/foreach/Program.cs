using System;

namespace forEachProgram {
    public class Program {
        public static void Main(string[] args) {
            string[] names = new string[] { "Maria", "Joao", "Jose" };
            foreach (string name in names)
                Console.WriteLine(name);

        }
    }
}