using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos de idade. Minha nota é {Nota}");
        }
    }
}
