using System;

namespace Xenlonguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desafio C# - 4 / 5 - Xenlonguinho
            int numero = int.Parse(Console.ReadLine());
            int[] esferas = { 1, 2, 3, 4, 5, 6, 7 };
            int somaEstralas = 0;
            int esferaPar;
            int contaEsfera = 0;

            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j < esferas.Length; j++)
                {

                    if (esferas[j] == 1 || esferas[j] == 4)
                    {
                        continue;
                    }
                    else
                    {
                        somaEstralas += esferas[j];
                        contaEsfera++;
                    }
                }

            }
            esferaPar = somaEstralas / 2;
            if ((somaEstralas-1) % 2 == 0)
            {
                Console.WriteLine(contaEsfera);

            }
        }
    }
}
