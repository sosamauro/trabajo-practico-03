﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public static class ControladorCirculo
    {
        public static double CalcularArea(double x, double y, double r)
        {
            Circulo circulo = new Circulo(x, y, r);

            return Math.Round(circulo.Area, 2);
        }

        public static double CalcularPerimetro(double x, double y, double r)
        {
            Circulo circulo = new Circulo(x, y, r);

            return Math.Round(circulo.Perimetro, 2);
        }
    }
}
