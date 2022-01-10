using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_CollectionsELinq.Helper
{
    class OperacoesLista
    {
        public void ImplimirListaString(List<string> lista)
        {
            Console.WriteLine("Usando For com seu indice");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Índice {i}, valor: {lista[i]}");
            }
        }
    }
}
