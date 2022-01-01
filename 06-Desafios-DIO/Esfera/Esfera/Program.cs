using System;
using System.Globalization;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desafio C# - 3 / 5 - Esfera
            double pi, raio = 4.0, volume = 3;
            pi = 3.14159;
            double R3 = double.Parse(Console.ReadLine());

            //double esfera = raio / volume * pi * R3 * R3 * R3;
            double esfera = raio / volume * pi * Math.Pow(R3,3);
            Console.WriteLine("VOLUME = " + esfera.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
