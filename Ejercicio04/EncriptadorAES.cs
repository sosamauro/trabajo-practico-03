﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Ejercicio04
{
    public class EncriptadorAES : Encriptador
    {
        public EncriptadorAES() : base("AES") { }

        // Documentación: https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-6.0

        public override string Encriptar(string pCadena)
        {
            byte[] encriptado;

            // Se crea un objecto Aes
            // con una Key y un IV específico
            using (Aes aes = Aes.Create())
            {
                aes.Padding = PaddingMode.None;
                // Crea un encriptador
                ICryptoTransform encriptador = aes.CreateEncryptor(aes.Key, aes.IV);

                // Crea un MemoryStream
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // Crea un flujo criptográfico utilizando la clase CryptoStream. 
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

            using (Aes aes = Aes.Create())
            {
                aes.Padding = PaddingMode.None;

                ICryptoTransform desencriptador = aes.CreateDecryptor(aes.Key, aes.IV);

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
