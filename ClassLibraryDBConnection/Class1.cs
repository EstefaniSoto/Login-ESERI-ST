using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryDBConnection
{
    public class Class1
    {

        public void logins(string usuario, string contraseña)
        {

            try//Manejador de errores en el cual se encontrara los apartados de usuario y contraseña del login para enlazarlos con la Base de Datos
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))

                {
                    conexion.Open();// Esta linea es para abrir la base de datos y se pueda acceder a la misma
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, pass FROM Login_BD WHERE usuario='" + usuario + "' AND pass= '" + contraseña + "'", conexion))//
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login exitoso");
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
