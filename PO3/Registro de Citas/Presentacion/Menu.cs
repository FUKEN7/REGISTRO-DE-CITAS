using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Esta seguro de salir de la aplicacion? ", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (respuesta == DialogResult.Yes)
            {
                this.Dispose();
            }

        }

        private void registrarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Registropaciente = new Registrar_Pacientes();
            Registropaciente.MdiParent = this;
            Registropaciente.Show();
        }

        private void historialGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.MdiParent = this;
            historial.Show();
        }
    }
}
