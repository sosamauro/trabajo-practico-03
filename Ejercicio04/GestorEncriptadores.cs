using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public static class GestorEncriptadores
    {  
        public static string EncriptarCadena(string pCadena, string pEncriptador)
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.Instancia();
            IEncriptador encriptador = instancia.GetEncriptador(pEncriptador);
            string cadenaEncriptada = encriptador.Encriptar(pCadena);
            return cadenaEncriptada;
        }

        public static string DesencriptarCadena(string pCadena, string pEncriptador)
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.Instancia();
            IEncriptador encriptador = instancia.GetEncriptador(pEncriptador);
            string cadenaDesencriptada = encriptador.Desencriptar(pCadena);
            return cadenaDesencriptada;
        }
    }
}
