using _05_Encapsulamento.Models;
using System;

namespace _05_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valores validos

            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);
            System.Console.WriteLine($"Área: {r.ObterArea()}");

            
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 30);
            System.Console.WriteLine($"Área: {r2.ObterArea()}");

            
        }
    }
}
