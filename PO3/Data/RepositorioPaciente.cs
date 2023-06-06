using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidad;
namespace Data
{
    public class RepositorioPaciente : ConexionBD, Data.CRUD<Paciente>
    {

    
        
        public string Actualizar(Paciente obj)
        {
            string _sql = string.Format("UPDATE [dbo].[Pacientes] SET [Nombre] = '{0}' ,[Celular] = '{1}', [Correo] = '{2}', [Descripcion] = '{3}', [Fecha] = '{4}', [Recomedacion] = '{5}' WHERE [IdPersona] = {6}", obj.Nombre, obj.Celular, obj.Correo, obj.Descricion, obj.Fecha, obj.Recomedacion,obj.IDC);
            var cmd = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            int filas = cmd.ExecuteNonQuery();
            CerrarConnexion();
            if (filas == 1)
            {
                return "se actualizo el registro del paciente:" + obj.IDC;
            }
            return "id no actualizo :" + obj.IDC + "No actualizo";
        }

        public Paciente BuscarID(string id)
        {
            try
            {
                string _sql = string.Format("select * from Pacientes where [IdPersona]={0}", id);
                var cmd = new SqlCommand(_sql, conexion);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var Paciente = new Entidad.Paciente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                CerrarConnexion();
                return Paciente;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public string Eliminar(Paciente obj)
        {
            throw new NotImplementedException();
        }

        public string Insertar(Paciente obj)
        {
            string _sql = string.Format("insert into Pacientes (IdPersona,Nombre,Celular,Correo,Descripcion,Fecha,Recomedacion) values ('{0}', '{1}', {2},'{3}','{4}','{5}','{6}')", obj.IDC, obj.Nombre, obj.Celular, obj.Correo, obj.Descricion, obj.Fecha, obj.Recomedacion);
            var cmd = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            int filas = cmd.ExecuteNonQuery();
            CerrarConnexion();
            if (filas == 1)
            {
                return "se agrego el registro del paciente:" + obj.IDC;
            }
            return "id no agregado :" + obj.IDC + "No agregado";
        }
        
        public List<Paciente> Todos(string obj)
        {
            string _sql = string.Format("select * from Pacientes");
            var cmd = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            var listaPacientes = new List<Entidad.Paciente>();

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {    
               
                var Paciente = new Entidad.Paciente(reader.GetInt32(0), reader.GetString(1),reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                listaPacientes.Add(Paciente);
            }
            CerrarConnexion();
            return listaPacientes;

        }
        Paciente Map(DataRow fila)
        {
            Paciente paciente = new Paciente();
            paciente.IDC = (int)fila[0];
            paciente.Nombre = (string)fila[1];
            paciente.Celular = (string)fila[2];
            paciente.Correo = (string)fila[3];
            paciente.Descricion = (string)fila[4];
            paciente.Fecha = (string)fila[5];
            paciente.Recomedacion = (string)fila[6];
            return paciente;
        }

    }
}
