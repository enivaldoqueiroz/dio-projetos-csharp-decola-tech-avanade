﻿using _09_FundamentosDeColecaoesELINQComDotNet.Helper;
using System;
using System.Collections.Generic;

namespace _09_FundamentosDeColecaoesELINQComDotNet
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> estados = new List<string>();
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");

            Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");


            Console.WriteLine("Usando Foreach");
            int indice = 0;
            foreach (var item in estados)
            {
                Console.WriteLine($"Índice {indice}, valor: {item}");
                indice++;
            }

            Console.WriteLine("Usando For");
            for (int i = 0; i < estados.Count; i++)
            {
                Console.WriteLine($"Índice {i}, valor: {estados[i]}");
            }

            //OperacoesArray op = new OperacoesArray();

            //int[] array = new int[5] { 6, 3, 8, 1, 9};
            //int[] arrayCopia = new int[10];

            //int valorProcurado = 10;

            //int indice = op.ObterIndice(array, valorProcurado);

            //if (indice > -1)
            //{
            //    Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
            //}
            //else
            //{
            //    Console.WriteLine("Valor não existente no array");
            //}

            //int valorAchado = op.ObterValor(array, valorProcurado);

            //if (valorAchado > 0)
            //{
            //    Console.WriteLine("Valor encontrado");
            //}
            //else
            //{
            //    Console.WriteLine("Valor não encontrado");
            //}

            //bool todosMairQue = op.TodosMaiorQue(array, valorProcurado);

            //if (todosMairQue)
            //{
            //    Console.WriteLine("Todos os valores são maior que {0}", valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
            //}

            //bool existe = op.Existe(array, valorProcurado);

            //if (existe)
            //{
            //    Console.WriteLine($"Valor {valorProcurado} foi encontrado");
            //}
            //else
            //{
            //    Console.WriteLine($"Valor {valorProcurado} não foi encontrado");
            //}

            //Console.WriteLine("Array Original: ");
            //op.ImprimirArray(array);

            ////op.OrdernarBubblerSort(ref array);
            //op.Ordenar(ref array);

            //Console.WriteLine("Array Ordenado: ");
            //op.ImprimirArray(array);

            //Console.WriteLine("Array antes de cópia");
            //op.ImprimirArray(arrayCopia);

            //Console.WriteLine("Array antes de cópia");
            //op.Copiar(ref array, ref arrayCopia);
            //op.ImprimirArray(arrayCopia);

            /*

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
            }*/
        }
    }
}