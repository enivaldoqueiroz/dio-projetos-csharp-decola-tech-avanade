using CSharp.Entities;
using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classes
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Maria";
            pessoa1.Estado = "Ceara";
            pessoa1.Idade = 24;

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Pedro";
            pessoa2.Estado = "Pernanbuco";
            pessoa2.Idade = 20;

            //Interfaces
            Animal animal1 = new Animal();

            animal1.Nome = "Mel";
            animal1.NomeDono = "Maria";
            animal1.Especie = "Cachorro";

            //Enum
            var pessoa = (Pessoas)0;
            Pessoas pessoa3 = Pessoas.Gionvanna;

        }
    }
}
