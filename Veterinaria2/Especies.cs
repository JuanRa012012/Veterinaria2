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
        clsEspeciesConexion conexion = new clsEspeciesConexion();
        int especieIDSeleccionada = 0; // Para modificar/anular

        public Especies()
        {
            InitializeComponent();
        }

        private void bttSalirEspecies_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Especies_Load(object sender, EventArgs e)
        {
            conexion.CargarDatos(dgvListaEspecies);
            dgvListaEspecies.ClearSelection();
        }

        private void Limpiar()
        {
            txtNombreEspecies.Text = "";
            especieIDSeleccionada = 0;
            dgvListaEspecies.ClearSelection();
        }

        private void bttGuardarEspecies_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEspecies.Text))
            {
                MessageBox.Show("Ingrese un nombre valido para la especie.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conexion.InsertEspecie(dgvListaEspecies, txtNombreEspecies.Text.Trim());
            Limpiar();

        }

        private void bttModificarEspecies_Click(object sender, EventArgs e)
        {
            if (especieIDSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una especie para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conexion.UpdateEspecie(dgvListaEspecies, txtNombreEspecies.Text.Trim(), especieIDSeleccionada);
            Limpiar();
        }

        private void dgvListaEspecies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvListaEspecies.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                especieIDSeleccionada = Convert.ToInt32(dgvListaEspecies.Rows[e.RowIndex].Cells["ID"].Value);
                txtNombreEspecies.Text = dgvListaEspecies.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
            }
        }

        private void bttAnularEspecies_Click(object sender, EventArgs e)
        {
            if (especieIDSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una especie para anular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Esta seguro que desea anular esta especie?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                conexion.DeleteEspecie(dgvListaEspecies, especieIDSeleccionada);
                Limpiar();
            }
        }
    }
}
