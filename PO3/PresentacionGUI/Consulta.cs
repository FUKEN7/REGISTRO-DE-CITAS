using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;
namespace PresentacionGUI
{
    public partial class Consulta : Form
    {
        
        
        public Consulta()
        {
            InitializeComponent();
            ListaPaciente();
        }
        void ListaPaciente()
        {
            var lista = new ServicioPaciente().Todos("");
            dataPacientes.DataSource = lista;
        }

       
       
        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    BuscarPaciente(txtBuscar.Text);

        //}
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
       
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
