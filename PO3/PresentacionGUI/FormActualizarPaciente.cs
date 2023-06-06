using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FormActualizarPaciente : Form
    {
        public FormActualizarPaciente()
        {
            InitializeComponent();
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            var paciente = new Entidad.Paciente(int.Parse(txtIdPaciente.Text), txtNombre.Text, txtcelular.Text, texCorreo.Text, txtEnfermedad.Text, texFecha.Text, textRecomendacion.Text);
            ACTILIZAR(paciente);
        }
        public void ACTILIZAR(Paciente paciente)
        {
            ServicioPaciente servicioPaciente = new ServicioPaciente();
            if (txtIdPaciente.Text.Trim() == "" && txtNombre.Text.Trim() == "" && texFecha.Text.Trim() == "" && texCorreo.Text.Trim() == "" && txtcelular.Text.Trim() == "" && txtEnfermedad.Text.Trim() == "" && textRecomendacion.Text.Trim() == "")
            {
                MessageBox.Show("Campos vacios ingrese datos");
            }
            else
            if (servicioPaciente.BuscarID(txtIdPaciente.Text) == null)
            {
                MessageBox.Show("Paciente no exite ");
            }
            else
            {
                var servicio = new ServicioPaciente();
                MessageBox.Show(servicio.Actualizar(paciente));
       
            }

        }

        void BuscarPaciente(string id)
        {

            try
            {
                var paciente = new ServicioPaciente().BuscarID(id);
                verPaciente(paciente);
            }
            catch (Exception)
            {

            }



        }
        void verPaciente(Paciente paciente)
        {
            txtIdPaciente.Text = paciente.IDC.ToString();
            txtNombre.Text = paciente.Nombre;
            txtcelular.Text = paciente.Celular;
            texCorreo.Text = paciente.Correo;
            txtEnfermedad.Text = paciente.Descricion;
            texFecha.Text = paciente.Fecha;
            textRecomendacion.Text = paciente.Recomedacion;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPaciente(txtIdPaciente.Text);
        }

        private void FormActualizarPaciente_Load(object sender, EventArgs e)
        {

        }


    }
}
