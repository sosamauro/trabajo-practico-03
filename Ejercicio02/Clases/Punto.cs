using Ejercicio02.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class Punto
    {
        // Atributos
        private double iX, iY;

        // Constructor
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        // Propiedades
        public double X 
        {  
            get { return this.iX; }
            set { this.iX = value; }
        }
        public double Y 
        {  
            get { return this.iY; }
            set { this.iY = value; }
        }

        //Método
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow((this.iX - pPunto.X), 2) + Math.Pow((this.iY - pPunto.Y), 2));
        }

    }
}
