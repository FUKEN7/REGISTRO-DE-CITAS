using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface Iservicios<T>
    {
        string Registrar(T paciente);
        string EditarPaciente(T Actualpaciente, T NewPaciente);

        bool Existe(T paciente);
        T ValidarRegistro(int ID);
    }
}
