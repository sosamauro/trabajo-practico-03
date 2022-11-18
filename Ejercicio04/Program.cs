namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;

            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("Elija un encriptador: ");
                Console.WriteLine();
                Console.WriteLine("1) Cesar");
                Console.WriteLine("2) Advanced Encryption Standard (AES)");
                Console.WriteLine();
                Console.WriteLine("3) Salir");
                Console.WriteLine();
                Console.Write("Opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Ingrese la cadena a encriptar: ");
                        string cadena = Console.ReadLine();
                        string cadenaEncriptada = Controlador.EncriptarCadena(cadena, "Cesar");
                        string cadenaDesencriptada = Controlador.DesencriptarCadena(cadenaEncriptada, "Cesar");
                        Console.WriteLine();
                        Console.WriteLine($"La cadena encriptada es: {cadenaEncriptada}");
                        Console.WriteLine();
                        Console.WriteLine($"La cadena desencriptada es: {cadenaDesencriptada}");
                        Console.ReadKey();
                        break;
                    case "2":
                        break;
                    case "3":
                        Console.Clear();
                        salir = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opción válida.");
                        Console.WriteLine();
                        Console.Write("Presione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}