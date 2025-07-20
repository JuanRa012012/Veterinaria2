using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
 
namespace Veterinaria2
{
    internal class clsRazasConexion
    {
        clsConexion clsConexion = new clsConexion();

        SqlDataAdapter da; 

        DataTable dt;

        public void CargarDatos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRERAZA FROM RAZA WHERE ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarEspecies(ComboBox cbo)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE FROM ESPECIE WHERE ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.DisplayMember = "NOMBRE";
                cbo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BuscarRaza(DataGridView dgv, String vrBuscar)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRERAZA FROM RAZA WHERE NOMBRERAZA LIKE '%" + vrBuscar + "%' AND ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
