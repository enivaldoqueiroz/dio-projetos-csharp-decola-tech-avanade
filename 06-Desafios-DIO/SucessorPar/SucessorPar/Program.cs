using System;

namespace SucessorPar
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Desafio 6/6
             *Para se preparar para os outros problemas, vamos fazer um teste. Dado um número X, 
             retorne o menor número par maior do que X.

                Entrada
                Uma linha contendo um número  0 < X < 107.

                Saída
                Uma linha contendo a resposta do problema.

            Dado de entrada: 9
            Saída esperada: 10
            Sua Saída: 10

             */

            int x = int.Parse(Console.ReadLine());
            int numeroPar = 0;
            int menorNumeroPar = 0;
            int maiorQueX = 0;
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    numeroPar = i;
                    menorNumeroPar = i;
                    if (menorNumeroPar <= numeroPar)
                    {
                        menorNumeroPar = numeroPar;
                    }
                }
                //Console.WriteLine(i);
            }
            maiorQueX = menorNumeroPar + 2;
            Console.WriteLine();
            Console.WriteLine("Menor numero par " + menorNumeroPar);
            Console.WriteLine("Menor numero par Maior do que x " + maiorQueX);



        }
    }
}
