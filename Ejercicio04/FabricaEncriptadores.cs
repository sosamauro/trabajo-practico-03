using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class FabricaEncriptadores
    {
        private static FabricaEncriptadores cInstancia;

        private static Dictionary<string, Encriptador> iEncriptadores = new Dictionary<string, Encriptador>();

        private FabricaEncriptadores()
        {
            iEncriptadores.Add("Cesar", new EncriptadorCesar(4));
            iEncriptadores.Add("AES", new EncriptadorAES());
            iEncriptadores.Add("Null", new EncriptadorNulo());
            iEncriptadores.Add("TDES", new EncriptadorTDES());
        }

        public static FabricaEncriptadores Instancia()
        {
            if (cInstancia == null)
            {
                cInstancia = new FabricaEncriptadores();
            }
            return cInstancia;
        }

        public IEncriptador GetEncriptador(string pNombre)
        {
            if (!iEncriptadores.ContainsKey(pNombre)) return iEncriptadores.GetValueOrDefault("Null");
            else return iEncriptadores.GetValueOrDefault(pNombre);
        }
    }
}
