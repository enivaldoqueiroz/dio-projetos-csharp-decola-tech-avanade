using System;

namespace Xenlongao_Desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Quantidade de casos de teste: ");
            int C = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Quantidade de esferass: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int somaEstralas = 0;
            int contaEsfera = 0;

            int[] esferas = new int[N];

            for (int i = 0; i < N; i++)
            {
                esferas[i] = i + 1;
            }

            for (int i = 0; i < C; i++)
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

            if ((somaEstralas - 1) % 2 == 0)
            {
                Console.WriteLine(contaEsfera);
            }
        }
    }
}
