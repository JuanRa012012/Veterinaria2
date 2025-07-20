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
                da = new SqlDataAdapter("SELECT ID, DESCRIPCION FROM RAZAS WHERE ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);


            }
        }

    }
}
