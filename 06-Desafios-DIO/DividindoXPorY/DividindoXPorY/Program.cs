using System;
using System.Globalization;

namespace DividindoXPorY
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desafio C# -  2 / 5 - Dividindo X por Y

            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");

                }else if (X == 0)
                {
                    double divisao = 0;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    double divisao = X / Y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
