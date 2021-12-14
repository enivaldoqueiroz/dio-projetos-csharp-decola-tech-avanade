using System;

namespace Sequencia_IJ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

                Entrada
                Não há nenhuma entrada neste problema.

                Saída
                Imprima a sequencia conforme exemplo abaixo
                I=1 J=7
                I=1 J=6
                I=1 J=5
                I=3 J=7
                I=3 J=6
                I=3 J=5
                I=5 J=7
                I=5 J=6
                I=5 J=5
                I=7 J=7
                I=7 J=6
                I=7 J=5
                I=9 J=7
                I=9 J=6
                I=9 J=5
             */
            for (int i = 1; i <= 9; i+=2)
            {
                for (int I = i, J = 7; J >= 5; J-=1)
                {
                    Console.WriteLine($"I={I} J={J}");
                }
            }


        }
    }
}
