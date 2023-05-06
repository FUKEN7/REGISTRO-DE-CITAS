using System;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class Registrar_Pacientes : Form
    {
        Logica.ServicioPaciente servicio = new Logica.ServicioPaciente();
        public Registrar_Pacientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidad.Paciente paciente = new Entidad.Paciente();
            try
            {
                if ((txtNombre.Text == "") || (txtID.Text == "") || (txtEmail.Text == "") || (txtEnfermedad.Text == "") || (txtPhone.Text == ""))
                {
                    MessageBox.Show("No es posible realizar el Registro, Aun hay campos Vacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    paciente.id = int64.Parse(txtID.Text);
                    paciente.nombre = txtNombre.Text;
                    paciente.correo = int64.parse(txtEmail.Text)
                    paciente.celular = int64.Parse(txtPhone.Text);
                    paciente.problema = txtEnfermedad.Text;
                    paciente.citaDia = dateTimeCita.Value;

                    var R = MessageBox.Show("Estas seguro de Registrar estos datos?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        var respuesta = servicio.Registrar(paciente);
                        MessageBox.Show(respuesta);
                        this.Dispose();
                    }


                }
            }
            catch (Exception ex)
            {
                throw;

            }

        }

        private void Registrar_Pacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var respuesta = MessageBox.Show("Desea salir?", "INFO REGISTRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (respuesta != DialogResult.Yes)
            {
                e.Cancel = true;
            }

        }
    }
}
