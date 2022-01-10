using System;
using System.Collections.Generic;

namespace _09_CollectionsELinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP", "São Paulo");
            estados.Add("MG", "Minas Gerais");
            estados.Add("CE", "Ceará");

            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            //Stack<string> pilhaLivros = new Stack<string>();

            //pilhaLivros.Push(".NET");
            //pilhaLivros.Push("DDD");
            //pilhaLivros.Push("Código Limpo");

            //Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            //while (pilhaLivros.Count > 0)
            //{
            //    Console.WriteLine($"Próximo Livro para a leitura: {pilhaLivros.Peek()}");
            //    Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            //}

            //Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

            //Queue<string> fila = new Queue<string>();

            //fila.Enqueue("Enivaldo");
            //fila.Enqueue("Lana");
            //fila.Enqueue("Mila");
            //fila.Enqueue("Maia");

            //Console.WriteLine($"Pessoas na fila: {fila.Count}");
            //while (fila.Count > 0)
            //{
            //    Console.WriteLine($"Vez de: {fila.Peek()}");
            //    Console.WriteLine($"{fila.Dequeue()} atendido");
            //}

            //Console.WriteLine($"Pessoas na fila: {fila.Count}");

            //OperacoesLista opLista = new OperacoesLista();
            //List<string> estados = new List<string> { "SP", "MG", "BA" };
            //string[] estadosArray = new string[2] { "SC", "MT" };

            //estados.Add("SP");
            //estados.Add("MG");
            //estados.Add("BA");

            //Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            //opLista.ImplimirListaString(estados);

            //Console.WriteLine("Removenodo o elemento");
            //estados.Remove("MG");

            //estados.AddRange(estadosArray);
            //estados.Insert(1, "RJ");
            //opLista.ImplimirListaString(estados);


            //Console.WriteLine("Usando Foreach");
            //int indice = 0;
            //foreach (var item in estados)
            //{
            //    Console.WriteLine($"Índice {indice}, valor: {item}");
            //    indice++;
            //}

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
