using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace ClassLibraryBDconect
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
                    //Acceso a la base de datos para revisiar los datos de "usuario" y "contraseña" escrito por usuario.
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, pass FROM Login_BD WHERE usuario='" + usuario + "' AND pass= '" + contraseña + "'", conexion))//
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())//Condicion en caso de que los datos ingresados cohincidan muestre un messageBox indicando que el logi fue exitoso.
                        {
                            MessageBox.Show("Login exitoso");
                        }
                        else// En caso de que los datos ingresados sean incorrectos, mostrara un MessageBox con ese mensaje.
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
