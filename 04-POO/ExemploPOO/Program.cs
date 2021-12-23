using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
namespace ExemploPOO
{
    class Program
    {
        static void Main()
        {
            var caminho = "D:\\DIO\\DECOLA-TECH-AVANADE\\dio-projetos-csharp-decola-tech-avanade\04-POO\\TrabalhandoComArquivos";

            Console.WriteLine(caminho);

//            FileHelper helper = new FileHelper();
//            helper.ListarDiretorios(caminho);

            /*ICalculadora calc = new Calculadora();
            
            Console.WriteLine("Valor da Soma: " + calc.Somar(10, 30));
            Console.WriteLine("Valor da Soma: " + calc.Dividir(10, 30));
            Console.WriteLine("Valor da Soma: " + calc.Multplicar(10, 30));
            Console.WriteLine("Valor da Soma: " + calc.Subtrair(10, 30));*/

            /*Corrente contaCorrente = new Corrente();
            contaCorrente.Creditar(100);
            contaCorrente.ExibirSalodo();*/

            /*Calculadora calc = new Calculadora();
            double somaComDoisParm = calc.Somar(10, 10);
            double somaComTresParm = calc.Somar(10, 10, 10);
            Console.WriteLine("Resultado da primeira soma: " + somaComDoisParm);
            Console.WriteLine("Resultado da primeira soma: " + somaComTresParm);*/

            /*Aluno p1 = new Aluno();
            
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Nota = 9;
            p1.Apresentar();

            Professor p2 = new Professor();
            
            p2.Nome = "Jonh";
            p2.Idade = 42;
            p2.Salario = 5000.00;
            p2.Documento = 123456;
            p2.Apresentar();*/
        }
    }
}