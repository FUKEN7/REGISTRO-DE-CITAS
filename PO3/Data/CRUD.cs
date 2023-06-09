﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Data
{
    public interface CRUD<T>
    {
        string Insertar(T obj);
        string Eliminar(T obj);
        string Actualizar(T obj);
        T BuscarID(string id);
        List<T> Todos(string obj);
    }
}
