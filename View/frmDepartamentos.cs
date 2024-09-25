using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importa desde proyecto la carpeta Controler
using Proyecto.Controler;
using Proyecto.Model;

namespace Proyecto.View
{
    public partial class frmDepartamentos : Form
    {

        departamentoControler odepartamentoControler;


        public frmDepartamentos()
        {
            odepartamentoControler = new departamentoControler();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //instrucciones para recolectar informacion de la GUI
            //obtener info de la interfaz gragica
            recuperarInformacion();
           
            MessageBox.Show("Conectando...");
            odepartamentoControler.agregar();

        }
        private void recuperarInformacion () 
        {
            departamentoControler oDepartamento = new departamentoControler();
            int id = int.Parse(txtId.Text);
            oDepartamento.id = id;
            oDepartamento.departamento = txtNombreDepartamento.Text;
            MessageBox.Show("ID ingresado: " + oDepartamento.id.ToString());
            MessageBox.Show("Departamento Ingresado: " + oDepartamento.departamento);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
