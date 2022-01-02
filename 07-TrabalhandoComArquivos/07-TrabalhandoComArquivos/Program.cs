using _07_TrabalhandoComArquivos.Helper;
using System;
using System.Collections.Generic;
using System.IO;

namespace _07_TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "D:\\DIO\\DECOLA-TECH-AVANADE\\dio-projetos-csharp-decola-tech-avanade\\07-TrabalhandoComArquivos\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            FileHelper helper = new FileHelper();
            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //System.Console.WriteLine("Criando diretorio: " + caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.LerArquivoStream(caminhoArquivo);
            helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);

            //Console.WriteLine(caminho);
        }
    }
}
