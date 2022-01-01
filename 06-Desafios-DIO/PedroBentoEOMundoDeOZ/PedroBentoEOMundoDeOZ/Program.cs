using System;
using System.Collections.Generic;
using System.Linq;

namespace PedroBentoEOMundoDeOZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desafio C# - 5 / 5 - Pedro Bento e o Mundo de OZ
            var J = new List<string>();
            while (true)
            {
                string joia = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(joia))
                    J.Add(joia);
                else
                {
                    break;
                }
            }
            var njoias = J.Distinct().ToList();
            Console.WriteLine(njoias.Count);
        }
    }
}
