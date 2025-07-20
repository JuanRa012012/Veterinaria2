using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria2
{
    public partial class Especies : Form
    {
        public Especies()
        {
            InitializeComponent();
        }

        clsConexion conexion = new clsConexion();
        clsAccionesEs acciones = new clsAccionesEs();
        SqlCommand cmd;
        int i;

        private void bttSalirEspecies_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Especies_Load(object sender, EventArgs e)
        {
            conexion.Abrir();
            acciones.CargarDatosEs(dgvListaEspecies, "Especie");
        }

        private void bttGuardarEspecies_Click(object sender, EventArgs e)
        {


        }

        private void bttModificarEspecies_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
        }
    }
}
