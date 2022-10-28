using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Clases
{
    public abstract class Animal
    {
        public void Saltar()
        {
            Console.WriteLine("Saltando");
        }

        public void Correr()
        {
            Console.WriteLine("Corriendo");
        }

        public abstract void HacerRuido();
    }
}