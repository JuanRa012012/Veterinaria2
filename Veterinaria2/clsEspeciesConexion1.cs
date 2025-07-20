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
        SqlCommand cmd;

        public void CargarDatos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBREESPECIE FROM ESPECIE WHERE ESTADO = 1", clsConexion.sc);
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
                da = new SqlDataAdapter("SELECT ID, NOMBREESPECIE FROM ESPECIE WHERE NOMBRERAZA LIKE '%" + vrBuscar + "%' AND ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NuevaRaza(DataGridView dgv, String vrNombre, int vrIdEspecie)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("INSERT INTO ESPECIE VALUES ('" + vrNombre + "'," + vrIdEspecie + ", 1, 1);", clsConexion.sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El nuevo ítem ha sido agregado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                clsConexion.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
