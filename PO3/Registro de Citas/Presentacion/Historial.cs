using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Presentacion
{
    public partial class Historial : Form
    {
        public Historial()
        {
            ListaPacientes();
            InitializeComponent();
            
        }

        private void HISTORIALdg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaPacientes();
        }
        void ListaPacientes()
        {
            Entidad.Paciente paciente = new Entidad.Paciente();
            Logica.ServicioPaciente servico = new Logica.ServicioPaciente();
            foreach (var item in servico.Consultar())
            {
                HISTORIALdg.Rows.Add(item.id, item.nombre, item.celular, item.correo, item.citaDia, item.problema);
            }

        }
    }
}
