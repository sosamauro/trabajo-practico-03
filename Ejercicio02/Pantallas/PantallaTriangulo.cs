﻿using Ejercicio02.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public static class PantallaTriangulo
    {
        public static void MostrarPantalla()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el primer punto");
            Console.Write("Coordenada en X: ");
            double x1 = Double.Parse(Console.ReadLine());
            Console.Write("Coordenada en Y: ");
            double y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Ingrese el segundo punto");
            Console.Write("Coordenada en X: ");
            double x2 = Double.Parse(Console.ReadLine());
            Console.Write("Coordenada en Y: ");
            double y2 = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Ingrese el tercer punto");
            Console.Write("Coordenada en X: ");
            double x3 = Double.Parse(Console.ReadLine());
            Console.Write("Coordenada en Y: ");
            double y3 = Double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("El área del triángulo es: " + FiguraGeometrica.CalcularArea(x1, x2, x3, y1, y2, y3));
            Console.WriteLine("El perímetro del triángulo es: " + FiguraGeometrica.CalcularPerimetro(x1, x2, x3, y1, y2, y3));
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
