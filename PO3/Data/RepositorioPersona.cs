using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Data
{
    public class RepositorioPersona : ConexionBD, Data.CRUD<Persona>
    {
        public string Actualizar(Persona obj)
        {
            try
            {
                string _sql = string.Format("UPDATE [dbo].[Clinita] SET [Nombres] = '{0}' ,[TipoCliente] ='{1}' WHERE [IdCliente] = '{2}'", obj.Nombre, obj.Correo,obj.Celular, obj.IDC);

                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                int filas = cmd.ExecuteNonQuery();
                CerrarConnexion();
                if (filas == 1)
                {
                    return "se Actualizo el registro del Persona cuyo id = :" + obj.IDC;
                }
                return "Imposible actualizar el registro del Persona cuyo id = :" + obj.IDC;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public Persona BuscarID(string id)
        {
            try
            {
                string _sql = string.Format("select * from personas where [IdPersona]='{0}'", id);
                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read(); 
                var persona = new Entidad.Persona(reader.GetInt32(0), reader.GetString(1),reader.GetString(2), reader.GetString(3));
                CerrarConnexion();
                return persona;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public string Eliminar(Persona obj)
        {
            return "";
        }

        public string Insertar(Persona obj)
        {
            string _sql = string.Format("insert into personas (IdPersona,Nombre,Celular,Correo) values ('{0}', '{1}', {2},'{3}')", obj.IDC, obj.Nombre, obj.Celular, obj.Correo);
            var cmd = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            int filas = cmd.ExecuteNonQuery();
            CerrarConnexion();
            if (filas == 1)
            {
                return "se agrego el registro de la persona idetificada :" + obj.IDC;
            }
            return "IdCliente de persona  :" + obj.IDC + "No agregado";
        }

        public List<Persona> Todos(string condicion)
        {
            string _sql = string.Format("select * from personas where IdPersona like '{0}%' or Nombre like '{1}%'", condicion, condicion);
            System.Data.DataTable tabla = new DataTable("personas");
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexion);

            adapter.Fill(tabla);

            List<Persona> lista = new List<Persona>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;
        }
        Persona map(DataRow fila)
        {
            Persona persona = new Persona();
            persona.IDC = (int)fila[0];
            persona.Nombre = (string)fila[1];
            persona.Celular = (string)fila[2];
            persona.Correo = (string)fila[3];
            return persona;
        }
    }
}
