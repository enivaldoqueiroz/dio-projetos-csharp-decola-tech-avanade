using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ContrutoresEOutrasPropriedades.Model
{
    class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;

            Calculadora.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        public void EventHandler()
        {
            System.Console.WriteLine("Metodo executado");
        }
    }
}
