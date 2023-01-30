using System;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;


namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            
                Console.Clear();
                Console.WriteLine("Escriba el encriptador a elegir ('Cesar', 'AES', 'TDES'): ");
                Console.WriteLine();
                Console.Write("Encriptador: ");
                string encriptador = Console.ReadLine();
                Console.Clear();
                Console.Write("Ingrese la cadena a encriptar: ");
                string cadena = Console.ReadLine();
                string cadenaEncriptada = GestorEncriptadores.EncriptarCadena(cadena, encriptador);
                string cadenaDesencriptada = GestorEncriptadores.DesencriptarCadena(cadenaEncriptada, encriptador);
                Console.WriteLine();
                Console.WriteLine($"La cadena encriptada es: {cadenaEncriptada}");
                Console.WriteLine();
                Console.WriteLine($"La cadena desencriptada es: {cadenaDesencriptada}");
                Console.ReadKey();
        }
    }
}