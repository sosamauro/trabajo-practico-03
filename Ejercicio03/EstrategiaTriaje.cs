using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class EstrategiaTriaje : IAtender
    {
        public Paciente[] AtenderPaciente(Paciente[] pPacientes)
        {
            Paciente[] pacientesPorTiempoEspera = new Paciente[pPacientes.Length];  

            pacientesPorTiempoEspera = pPacientes.OrderByDescending(x => x.TiempoEspera).ToArray();

            return pacientesPorTiempoEspera.OrderBy(x => x.Nivel).ToArray(); ;
        }
    }
}