using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExemploPOO.Models
{
    class Professor : Pessoa
    {
        public double Salario { get; set; }
        public int Documento { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos de idade. Meu salario R${Salario.ToString("F2", CultureInfo.InvariantCulture)} e Documento : {Documento}");
        }
    }
}
