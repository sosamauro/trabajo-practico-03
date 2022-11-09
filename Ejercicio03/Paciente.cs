using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    public class Paciente
    {
        private string iNombre, iDNI;
        private int iTiempoEspera, iNivel;

        public Paciente(string pNombre, string pDNI, int pTiempoEspera, int pNivel)
        {
            iNombre = pNombre;
            iDNI = pDNI;
            iTiempoEspera = pTiempoEspera;
            iNivel = pNivel;
        }

        public string Nombre
        {
            get { return iNombre; }
            set { iNombre = value; }
        }

        public string DNI
        {
            get { return iDNI; }
            set { iDNI = value; }
        }

        public int TiempoEspera
        {
            get { return iTiempoEspera; }
            set { iTiempoEspera = value; }
        }

        public int Nivel
        {
            get { return iNivel; }
            set { iNivel = value; }
        }
    }
}

