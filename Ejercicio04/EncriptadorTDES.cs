using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class EncriptadorTDES : Encriptador
    {
        public EncriptadorTDES() : base("TDES") { }

        public override string Encriptar(string pCadena)
        {
            byte[] encriptado;
            using (TripleDES tdes = TripleDES.Create())
            {
                ICryptoTransform encriptador = tdes.CreateEncryptor(tdes.Key, tdes.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encriptador, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(pCadena);
                        }
                        encriptado = msEncrypt.ToArray();
                    }
                }
            }
            return Encoding.UTF8.GetString(encriptado);
        }

        public override string Desencriptar(string pCadena)
        {
            string desencriptado = null;
            byte[] cadenaEncriptada = Encoding.UTF8.GetBytes(pCadena);
            using (TripleDES tdes = TripleDES.Create())
            {
                ICryptoTransform desencriptador = tdes.CreateDecryptor(tdes.Key, tdes.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cadenaEncriptada))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, desencriptador, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            desencriptado = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return desencriptado;
        }
    }
}
