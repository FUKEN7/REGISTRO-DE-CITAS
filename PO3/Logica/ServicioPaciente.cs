using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entidad;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;

namespace Logica
{
    public class ServicioPaciente
    {
        Data.RepositorioPaciente repositorio = new Data.RepositorioPaciente();

      
        public string Actualizar(Paciente paciente)
        {
            return repositorio.Actualizar(paciente);
        }

        public Paciente BuscarID(string id)
        {
            return repositorio.BuscarID(id);
        }

        public string Eliminar(Paciente vehiculo)
        {
            return repositorio.Eliminar(vehiculo);
        }

        public string Insertar(Paciente vehiculo)
        {
            return repositorio.Insertar(vehiculo);
        }

        public List<Paciente> Todos(string condicion)
        {
          return repositorio.Todos(condicion);
        }
    }
}
