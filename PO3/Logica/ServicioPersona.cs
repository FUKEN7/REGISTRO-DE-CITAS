using Data;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
namespace Logica
{
    public class ServicioPersona 
    {
        Data.RepositorioPersona repositorio = new Data.RepositorioPersona();
        public string Actualizar(Persona cliente)
        {
             return repositorio.Actualizar(cliente);
        }

        public Persona BuscarID(string id)
        {
            return repositorio.BuscarID(id);
        }

        public string Eliminar(Persona cliente)
        {
            return repositorio.Eliminar(cliente);
        }

        public string Insertar(Persona cliente)
        {
            return repositorio.Insertar(cliente);
        }

        public List<Persona> Todos(string condicion)
        {
          return repositorio.Todos(condicion);
        }
    }
}
