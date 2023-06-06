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
    public partial class FormRegistrarPacientes : Form
    {
        public FormRegistrarPacientes()
        {
            InitializeComponent();
            ListaPersona();
        }
        void ListaPersona()
        {
            var lista = new ServicioPersona().Todos("");
            dataGridView1.DataSource = lista;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            var paciente = new Entidad.Paciente(int.Parse(txtIdPaciente.Text), txtNombre.Text, txtcelular.Text, texCorreo.Text,txtEnfermedad.Text, texFecha.Text ,textRecomendacion.Text);
            Save(paciente);

        }
        public void Save(Paciente paciente)
        {
            ServicioPaciente servicioPaciente = new ServicioPaciente();
            if (txtIdPaciente.Text.Trim() == "" && txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Campos vacios ingrese datos");
            }
            else
            if (servicioPaciente.BuscarID(txtIdPaciente.Text) != null)
            {
                MessageBox.Show("Paciente ya exite ");
            }
            else
            {
                var servicio = new ServicioPaciente();
                MessageBox.Show(servicio.Insertar(paciente));
                ListaPersona();
            }

        }
       
        void Nuevo()
        {
            txtIdPaciente.Text = "";
            txtNombre.Text = "";
            texFecha.Text = "";
            texCorreo.Text = "";
            txtcelular.Text = "";
            txtEnfermedad.Text = "";
            textRecomendacion.Text = "";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {

        }

        private void bntSearch_Click(object sender, EventArgs e)

        {

            Buscar(txtIdPaciente.Text);
        }
        void Buscar(string id)
        {

            try
            {
                var persona = new ServicioPersona().BuscarID(id);
                ver(persona);
            }
            catch (Exception)
            {

            }


        }
        void ver(Persona persona)
        {
            txtIdPaciente.Text = persona.IDC.ToString();
            txtNombre.Text = persona.Nombre;
            txtcelular.Text = Convert.ToString(persona.Celular);
            texCorreo.Text = persona.Correo;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                txtIdPaciente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtcelular.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                texCorreo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

  
        private void txtEnfermedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void texCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void texFecha_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
