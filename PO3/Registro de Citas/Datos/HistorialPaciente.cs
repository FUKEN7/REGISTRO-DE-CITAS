using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.IO;
namespace Datos
{
    public class HistorialPaciente:Archivos
    {
        public List<Paciente> Listapacientes()
        {
             
            try
            {
                List<Paciente> Pacientelistas = new List<Paciente>();
                FileStream archivo = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader lector = new StreamReader(ruta);

                while (!lector.EndOfStream)
                {
                    Pacientelistas.Add(Mappear(lector.ReadLine()));
                }
                lector.Close();
               return Pacientelistas;

            }
            catch (Exception e)
            {

                throw;
            }
        }


        public Paciente Mappear(string dato)
        {
            try
            {
                var Datos = new Paciente();
                Datos.id = int.Parse(dato.Split(';')[0]);
                Datos.nombre = dato.Split(';')[1];
                Datos.celular = int.Parse(dato.Split(';')[2]);
                Datos.correo = dato.Split(';')[3];
                Datos.problema = dato.Split(';')[4];
                Datos.citaDia = DateTime.Parse(dato.Split(';')[5]);
                return Datos;
            }
            catch (Exception e)
            {

                return null;
            }


        }

    }
}
