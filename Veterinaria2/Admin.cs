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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuarios usuarios = new FormUsuarios();
            usuarios.ShowDialog();
        }

        private void btnVeterinarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Veterinarios veterinarios = new Veterinarios();
            veterinarios.ShowDialog();
        }

        private void btnEspecies_Click(object sender, EventArgs e)
        {
            this.Hide();
            Especies especies = new Especies();
            especies.ShowDialog();
        }

        private void btnRazas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Razas razas = new Razas();
            razas.ShowDialog();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Servicios serv = new Servicios();
            serv.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.ShowDialog();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            Mascotas mascotas = new Mascotas();
            mascotas.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
