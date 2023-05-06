using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    public class ServicioPaciente : Iservicios<Paciente>
    {
        List<Paciente> pacientes;
        HistorialPaciente Hpaciente = new HistorialPaciente();

        public ServicioPaciente()
        {
           pacientes = Hpaciente.Listapacientes();
        }
        public string Registrar(Paciente paciente)
        {
            string R;

            //if (ValidarRegistro(paciente.id) != null)
            //{
            //    return "El contacto que se quiere registrar ya existe....";
            //}
                bool respuesta = Hpaciente.GuardarInfo(paciente);
            if(respuesta == true)
            {
                R = "El paciente fue Guardado de manera correcta...";
            }
            else
            {
                R = "El paciente No puedo Ser registrado....";
            }


            return R;
        }

        public Paciente ValidarRegistro(int ID)
        {
            foreach (var item in pacientes)
            {
                if(item.id == ID)
                {
                    return item;
                }
          
            }
            return null;

        }

        public string EditarPaciente(Paciente Actualpaciente, Paciente NewPaciente)
        {
            return "";
        }

        public bool Existe(Paciente paciente)
        {
            foreach (var item in pacientes)
            {
                if (item.id == paciente.id)
                {
                    return true;
                }

            }
            return false;
        }
        public List<Paciente> Consultar()
        {

            return pacientes;
        }

    }


  
}
