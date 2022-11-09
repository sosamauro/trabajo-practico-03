using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class EstrategiaFIFO : IAtender
    {
        public Paciente[] AtenderPaciente(Paciente[] pPacientes)
        {
            return pPacientes.OrderByDescending(x => x.TiempoEspera).ToArray(); 
        }
    }
}