using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidad;
namespace Datos
{
    public class Archivos
    {
        protected string ruta;

        public Archivos(string informacion)
        {
            ruta = informacion;
        }

        public Archivos()
        {
            ruta = "HistorialPacientes.txt";
        }

        public bool GuardarInfo(Paciente datospaciente)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta,true);
                escritor.WriteLine(datospaciente.id.ToString() + ";" + datospaciente.nombre + ";" + datospaciente.celular.ToString() + ";" + datospaciente.correo + ";" + datospaciente.problema + ";" + datospaciente.citaDia);
                escritor.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
