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
        clsValidaciones clsValidaciones = new clsValidaciones();
        clsRazasConexion clsRazasConexion = new clsRazasConexion();

        public Razas()
        {
            InitializeComponent();
        }

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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else if (cboEspecie.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una especie de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEspecie.Focus();
            }
            else
            {
                String vrNombre = txtNombre.Text;
                int vrIdEspecie = Convert.ToInt32(cboEspecie.SelectedValue);

                clsRazasConexion.NuevaRaza(grdRazas, vrNombre, vrIdEspecie);
            }
              
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }
    }
}
