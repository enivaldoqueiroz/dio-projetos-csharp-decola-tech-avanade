using System;

namespace Sequencia_S
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
                S = 1 + 1/2 + 1/3 + … + 1/100

                    Entrada
                    Não há nenhuma entrada neste problema.

                    Saída
                    A saída contém um valor correspondente ao valor de S.
                    O valor deve ser impresso com dois dígitos após o ponto decimal.
             */

            double a, c, S = 0;
            for (int i = 1; i < 101; i++)
            {
                c = (double)1/i          ;  //coloque a sua lógica nos espaços em branco
                S += c;
            }
            var x = Math.Round(S, 2);
            Console.WriteLine(x);
        }
    }
}
