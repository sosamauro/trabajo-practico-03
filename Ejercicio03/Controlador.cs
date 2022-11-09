using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    public static class Controlador
    {
        public static Paciente[] InicializarTurnos()
        {
            Paciente[] pacientes =
            {
                new Paciente("Test 1", "12345678", 10, 2),
                new Paciente("Test 2", "12345678", 20, 5),
                new Paciente("Test 3", "12345678", 30, 1),
                new Paciente("Test 4", "12345678", 40, 4),
                new Paciente("Test 5", "12345678", 50, 5),
                new Paciente("Test 6", "12345678", 60, 3),
                new Paciente("Test 7", "12345678", 70, 3),
                new Paciente("Test 8", "12345678", 80, 2),
                new Paciente("Test 9", "12345678", 90, 1),
                new Paciente("Test 10", "12345678", 100, 1)
            };

            return pacientes;
        }
    }
}
