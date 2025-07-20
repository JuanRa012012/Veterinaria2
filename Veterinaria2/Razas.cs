using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria2
{
    public partial class Razas : Form
    {
        public Razas()
        {
            InitializeComponent();
        }

        clsRazasConexion clsRazasConexion = new clsRazasConexion();

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Razas_Load(object sender, EventArgs e)
        {
            clsRazasConexion.CargarDatos(grdRazas);
            clsRazasConexion.CargarEspecies(cboEspecie);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String vrTexto = txtNombre.Text;

            clsRazasConexion.BuscarRaza(grdRazas, vrTexto);
        }
    }
}
