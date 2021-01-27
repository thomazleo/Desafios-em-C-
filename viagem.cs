using System;
using static System.Math;

class Program {
    static void Main(string[] args) {

        string[] km = Console.ReadLine().Split(" ");
        int horas = Int32.Parse(km[0]);
        int velocidade = Int32.Parse(km[1]);

        double x = 12;
        double litro = (horas * velocidade);
        double total = litro/x;

        Console.WriteLine(total.ToString("N3"));
    }
}