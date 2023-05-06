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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text == "" || txtContra.Text == "")
            {
                MessageBox.Show("Aun hay campos Vacios, Por favor digitar informacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                new Menu().ShowDialog();   
                cerrar();
            }
        }

        public void cerrar()
        {
            this.Dispose();
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64)|| (e.KeyChar >= 91 && e.KeyChar <= 96)|| (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor digitar solo Letras ", "MENSAJE IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
