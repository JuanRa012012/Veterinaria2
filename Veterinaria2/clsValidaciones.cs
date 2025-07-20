using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria2
{
    public class clsValidaciones
    {
        string conexion = "Data Source = CHRISTINA-PC\\SQLEXPRESS; Initial Catalog = BDVeterinaria; Integrated Security = true";

        /// <summary>
        /// Valida las credenciales del usuario.
        /// </summary>
        /// <param name="usuario">Nombre de usuario</param>
        /// <param name="contraseña">Contraseña</param>
        /// <param name="rol">Rol obtenido si las credenciales son válidas</param>
        /// <returns>True si las credenciales son válidas y el estado es Activo</returns>
        /// 

        public bool ValidarUsuario(string usuario, string contraseña, out string rol)
        {
            rol = "";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT Rol FROM UsuarioSistema WHERE NombreUsuario = @Nombre AND Contraseña = @Contraseña AND Estado = 'Activo'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    var resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        rol = resultado.ToString();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public void SoloEnteros(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            else
                e.Handled = false;
        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
                e.Handled = true;
            else
                e.Handled = false;
        }

        public void SoloReales(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
            else
                e.Handled = false;
        }

    }
}
