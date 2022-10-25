using System;
class URI {
    static void Main(string[] args) {
        int X = int.Parse(Console.ReadLine());
        int Primeiro = 1;
        int Segundo = 2;
        int Terceiro = 3;
        for (int i = 0; i < X; i++) {
            Console.WriteLine($"{Primeiro} {Segundo} {Terceiro} PUM");
            Primeiro += 4;
            Segundo += 4;
            Terceiro += 4;
        } 
    }
 }