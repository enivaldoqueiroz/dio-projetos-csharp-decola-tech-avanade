using System;

namespace Xenlongao_Desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de casos de teste: ");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidade de esferas: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int soma;
            int esferasPossiveis = 0;

            //int[] espera = new int[] { 1, 2, 3, 4, 5, 6, 7 };


            int[] espera = new int[N];

            for (int i = C - 1; i < espera.Length; i++)
            {
                espera[i] = i + 1;
            }

            foreach (var item in espera)
            {
                Console.WriteLine("Valores das esferas: " + item);
            }

            Console.WriteLine();
            //Console.WriteLine("Nº de esferas: " + contador);


            for (int i = 0; i < espera.Length; i++)
            {
                for (int j = 0; j < espera.Length; j++)
                {
                        soma = (espera[i] + espera[j + 1]);
                    
                    if (soma == 4 && soma == 4)
                    {
                        continue;
                    }
                    else if (soma % 2 == 0)
                    {
                        
                        Console.WriteLine("Soma das esferas é par " + soma);
                        esferasPossiveis++;
                    }
                    else
                    {
                        Console.WriteLine("Soma das esferas é impar " + soma);
                        esferasPossiveis++;
                    }
                }
            }

            Console.WriteLine("Nº de esferas: " + esferasPossiveis);


        }
    }
}
