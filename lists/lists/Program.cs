using System;
using System.Collections.Generic;

namespace lists {
    public class Program {
        public static void Main(string[] args) {
            List<string> list = new List<string>(); // Declarando e iniciando a lista

            list.Add("Pedro"); // Adicionando à lista
            list.Insert(1, "Marco"); // Adiciona com posição dita
            

            foreach(string obj in list)
                Console.WriteLine(obj);
            Console.WriteLine(list.Count); // Mostra a quantia na lista

            string s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine($"Primeiro com M no nome: {s1}");

            List<string> list2 = list.FindAll(x => x.Length == 5); // Cria nova lista filtrada

            list.Remove("Marco"); // Remove da lista
            list.RemoveAll(x => x[0] == 'M'); // remove todos que caem na lambda
            list.RemoveAt(0); // Remoção por posição
            list.RemoveRange(0, 1); // remove em range
        }
    }
}
