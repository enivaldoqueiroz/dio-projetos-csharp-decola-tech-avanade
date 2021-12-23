using System;
using System.IO;

namespace ListarDiretorios.Helper
{
    class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.EnumerateDirectories(caminho);
            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
        }
    }
}
