using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class EncriptadorCesar : Encriptador
    {
        private int iDesplazamiento;

        public EncriptadorCesar(int pDesplazamiento) : base("Cesar") 
        {
            this.iDesplazamiento = pDesplazamiento;
        }

        public override string Encriptar(string pCadena)
        {
            if (pCadena.Length == 0) return String.Empty;

            char chr = pCadena[0].ToString().ToLower()[0];

            var code = IsBasicLetter(chr) ? (char)(((chr - 'a' + iDesplazamiento) % 26) + 'a') : chr;
            return code + Encriptar(pCadena.Substring(1));
        }

        public override string Desencriptar(string pCadena)
        {
            if (pCadena.Length == 0) return String.Empty;

            char chr = pCadena[0].ToString().ToLower()[0];

            var code = IsBasicLetter(chr) ? (char)('z' - (('z' - chr + iDesplazamiento) % 26)) : chr;
            return code + Desencriptar(pCadena.Substring(1));
        }

        private static bool IsBasicLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }
    }
}
