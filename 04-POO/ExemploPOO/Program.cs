using System;
using ExemploPOO.Models;
namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Nota = 9;
            p1.Apresentar();

            Professor p2 = new Professor();
            
            p2.Nome = "Jonh";
            p2.Idade = 42;
            p2.Documento = 123456;
            p2.Apresentar();
        }
    }
}