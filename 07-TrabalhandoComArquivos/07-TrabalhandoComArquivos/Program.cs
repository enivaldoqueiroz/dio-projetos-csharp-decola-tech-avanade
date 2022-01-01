using _07_TrabalhandoComArquivos.Helper;
using System;
using System.IO;

namespace _07_TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "D:\\DIO\\DECOLA-TECH-AVANADE\\dio-projetos-csharp-decola-tech-avanade\\07-TrabalhandoComArquivos\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            FileHelper helper = new FileHelper();
            System.Console.WriteLine("Criando diretorio: " + caminhoPathCombine);
            helper.ApagarDiretorio(caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);

            //Console.WriteLine(caminho);
        }
    }
}
