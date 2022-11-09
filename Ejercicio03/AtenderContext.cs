using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class AtenderContext
    {
        private IAtender oAtender;

        public AtenderContext()
        {
            // Esta estrategia se pone por defecto.
            this.oAtender = new EstrategiaFIFO();
        }

        public void EstablecerEstrategiaFIFO() 
        {
            this.oAtender = new EstrategiaFIFO();
        }

        public void EstablecerEstrategiaTriaje()
        {
            this.oAtender = new EstrategiaTriaje();
        }

        public Paciente[] Atender(Paciente[] pPacientes)
        {
            return this.oAtender.AtenderPaciente(pPacientes);
        }
    }
}
