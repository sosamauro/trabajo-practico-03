using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    interface IAtender
    {
        Paciente[] AtenderPaciente(Paciente[] pPacientes);
    }
}