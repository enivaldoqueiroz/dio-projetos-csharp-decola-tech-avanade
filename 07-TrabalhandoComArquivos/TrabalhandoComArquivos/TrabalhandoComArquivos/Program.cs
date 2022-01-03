using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhandoComArquivos.Helper;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos\\PastaTeste1";
            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            helper.ListarArquivosDiretorios(caminho);

            Console.ReadLine();
        }
    }
}
