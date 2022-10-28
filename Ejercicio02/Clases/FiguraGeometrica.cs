using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Clases
{
    public abstract class FiguraGeometrica
    {
        public static double CalcularArea(double pX, double pY, double pRadio)
        {
            Circulo circulo = new Circulo(pX, pY, pRadio);
            return Math.PI * Math.Pow(circulo.Radio, 2);
        }

        public static double CalcularArea(double pX1, double pX2, double pX3, double pY1, double pY2, double pY3)
        {
            Punto punto1 = new Punto(pX1, pY1);
            Punto punto2 = new Punto(pX2, pY2);
            Punto punto3 = new Punto(pX3, pY3);

            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);

            double perimetro = CalcularPerimetro(pX1, pX2, pX3, pY1, pY2, pY3);

            return Math.Sqrt((perimetro / 2) * ((perimetro / 2) - punto1.CalcularDistanciaDesde(punto2)) * ((perimetro / 2) - punto1.CalcularDistanciaDesde(punto3)) * ((perimetro / 2) - punto2.CalcularDistanciaDesde(punto3)));
        }

        public static double CalcularPerimetro(double pX1, double pX2, double pX3, double pY1, double pY2, double pY3)
        {
            Punto punto1 = new Punto(pX1, pY1);
            Punto punto2 = new Punto(pX2, pY2);
            Punto punto3 = new Punto(pX3, pY3);

            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);

            return punto1.CalcularDistanciaDesde(punto2) + punto1.CalcularDistanciaDesde(punto3) + punto2.CalcularDistanciaDesde(punto3);
        }

        public static double CalcularPerimetro(double pX, double pY, double pRadio)
        {
            Circulo circulo = new Circulo(pX, pY, pRadio);
            return 2 * Math.PI * circulo.Radio;
        }
    }
}
