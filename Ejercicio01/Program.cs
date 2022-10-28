using Ejercicio01.Clases;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veterinaria veterinaria = new Veterinaria();
            Perro perro = new Perro();
            Gato gato = new Gato();
            Vaca vaca = new Vaca();
            Pollo pollo = new Pollo();
            Animal[] animales = { perro, gato, vaca, pollo };
            veterinaria.AceptarAnimal(animales);
            Console.ReadKey();
        }
    }
}