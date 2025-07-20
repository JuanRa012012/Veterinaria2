using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria2
{
    public class clsConexion
    {
        string verbindung = "Data Source = DESKTOP-LM1438C\\MSSQL3; Initial Catalog = Ejercicio; Integrated Security = true";

        public SqlConnection sc = new SqlConnection();

        public clsConexion()
        {
            sc.ConnectionString = verbindung;
        }

        public void Abrir()
        {
            try
            {
                if (sc.State == ConnectionState.Closed)
                {
                    sc.Open();
                    MessageBox.Show("Conexión abierta", "State", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cerrar()
        {
            try
            {
                if (sc.State == ConnectionState.Open)
                {
                    sc.Close();
                    MessageBox.Show("Conexión cerrada", "State", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
