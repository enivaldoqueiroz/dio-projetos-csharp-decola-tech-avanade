using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor);

        public void ExibirSalodo()
        {
            Console.WriteLine("Seu saldo é: " + saldo);
        }
        
    }
}
