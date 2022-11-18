using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class EncriptadorAES : Encriptador
    {
        public EncriptadorAES() : base("AES") { }

        public override string Encriptar(string pCadena)
        {
            return "messi";
        }

        public override string Desencriptar(string pCadena)
        {
            return "messi";
        }
    }
}
