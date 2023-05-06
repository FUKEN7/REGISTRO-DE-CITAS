using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Paciente : Persona
    {
        private string Problema;
        private DateTime CitaDia;
        

        public string problema { get => Problema; set => this.Problema = value; }
        public DateTime citaDia { get => CitaDia; set => this.CitaDia = value; }
      

    }
}
