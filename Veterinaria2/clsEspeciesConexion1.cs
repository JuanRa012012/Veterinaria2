﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria2
{
    internal class clsEspeciesConexion
    {
        clsConexion clsConexion = new clsConexion();

        SqlDataAdapter da;

        DataTable dt;

        public void CargarDatos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, DESCRIPCION FROM ESPECIES WHERE ESTADO = 1", clsConexion.sc);
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
