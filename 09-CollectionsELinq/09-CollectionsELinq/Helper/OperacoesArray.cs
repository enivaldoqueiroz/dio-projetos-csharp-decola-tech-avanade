using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_CollectionsELinq.Helper
{
    class OperacoesArray
    {
        public void OrdernarBubblerSort(ref int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemente => elemente > valor);
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, elemente => elemente == valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }
    }
}
