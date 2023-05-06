using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {
        private int Id;
        private string Nombre;    
        private int Celular;
        private string Correo;
        public int id { get => Id; set => this.Id = value; }
        public string nombre { get=> Nombre; set => this.Nombre = value; }

        public int celular { get => Celular; set => this.Celular = value; }

        public string correo { get => Correo; set => this.Correo = value; }

    }
}
