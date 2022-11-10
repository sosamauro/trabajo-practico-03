using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public abstract class Encriptador
    {
        private String iNombre;

        public Encriptador(String pNombre)
        {
            this.iNombre = pNombre;
        }

        public String Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public String EncriptarCadena
    }
}
