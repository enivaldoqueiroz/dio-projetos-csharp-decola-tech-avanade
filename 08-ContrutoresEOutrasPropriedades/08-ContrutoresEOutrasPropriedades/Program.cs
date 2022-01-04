using _08_ContrutoresEOutrasPropriedades.Model;
using System;

namespace _08_ContrutoresEOutrasPropriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pessoa pessoa = new Pessoa("Enivaldo", "Queiroz");

            pessoa.Apresentar();*/

            Log log = Log.GetInstance();
            log.PropriedadeLog = "Teste Instancia";

            Log log2 = Log.GetInstance();
            Console.WriteLine(log2.PropriedadeLog);


        }
    }
}
