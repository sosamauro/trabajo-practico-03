using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Clases
{
    public class Veterinaria
    {
        public void AceptarAnimal(Animal[] pAnimales)
        {
            foreach (Animal animal in pAnimales)
            {
                animal.Correr();
                animal.HacerRuido();
                animal.Saltar();
            }
        }
    }
}