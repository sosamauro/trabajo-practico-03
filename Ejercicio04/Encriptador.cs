using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public abstract class Encriptador : IEncriptador
    {
        private String iNombre;

        public Encriptador(string pNombre)
        {
            this.iNombre = pNombre;
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public abstract string Encriptar(string pCadena);

        public abstract string Desencriptar(string pCadena);
    }
}
