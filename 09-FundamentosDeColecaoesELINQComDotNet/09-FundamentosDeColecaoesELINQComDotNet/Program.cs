using System;

namespace _09_FundamentosDeColecaoesELINQComDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // ******** - Operações com Array - ********
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = int.Parse("30");

            // Ao descomentar a linha abaixo o programa retornará uma exceção pois não é uma posição válida no array
            //arrayInteiros[3] = 30;

            // Percorrendo o array
            System.Console.WriteLine("Percorrendo o array pelo For");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                System.Console.WriteLine(arrayInteiros[i]);
            }

            System.Console.WriteLine("Percorrendo o array pelo ForEach");
            foreach (int item in arrayInteiros)
            {
                System.Console.WriteLine(item);
            }

            // ******** - Operações com matriz multidimensional, sendo composta de 4 linhas e 2 colunas - ********
            int[,] matriz = new int[4, 2]
            {
                { 8, 8 },
                { 10, 20 },
                { 50, 100 },
                { 90, 200 }
            };

            // Percorrendo a matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.WriteLine(matriz[i, j]);
                }
            }
        }
    }
}
