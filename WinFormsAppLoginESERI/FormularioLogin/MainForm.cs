using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ClassLibraryBDconect;

namespace WinFormsAppLoginESERI
{/// <summary>
/// Inicializacion del formulario Login
/// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
       
        
        /// <summary>
        /// Creacion de metodo para utilizar los paramatros de usuario y contraseña en la conexion a base de datos creada en nuestra libreria de clases ClassLibraryBDconect.
        /// </summary>
        public void conect()
        {
           //Metodo para enviar parametros de usuario y contraseña a la libreria de clase de conexion a base de datos.
            Class1 conectBD = new Class1();
            string user = textBox1.Text;
            string pass = textBox2.Text;
            conectBD.logins(user, pass);
        }
  
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
        /// <summary>
        /// Metodo que posee un metodo dentro el cual llama a la conexion de base de datos traida por la libreria de clase BDconect.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
            //Llamamos al metodo creado
        {
            conect();
        }
        /// <summary>
        /// Metodo para Indicar que se debe eliminar el placeholder "Usuario" una vez que el usuario empiece a escribir.
        /// </summary>

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "Usuario")//Condicion para preguntar si el textBox1 es igual a la palabra "usuario" la cual se encuentra como placeholder.
            {
                textBox1.Text = ""; // Si la condicion se cumple, el placeholder se quitara y el usuario podra escribir.
                textBox1.ForeColor = Color.LightGray;
            }
        }
        /// <summary>
        /// Metodo para mostrar el placeholder.
        /// </summary>

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")//Condicion para preguntar si el textBox1 esta vacio.
            {
                textBox1.Text = "Usuario";//Si se cumple esta condicion se mostrara la palabra "Usuario" poniendo asi al placeholder.
                textBox1.ForeColor = Color.DimGray;
            }
        }
        /// <summary>
        /// Metodo para Indicar que se debe eliminar el placeholder "Contraseña" una vez que el usuario empiece a escribir.
        /// </summary>

        private void textBox2_Enter(object sender, EventArgs e)
        {
            //Indicamos que se debe eliminar el placeholder "Contraseña" una vez que el usuario empiece a escribir
            if (textBox2.Text == "Contraseña")//Condicion para preguntar si el textBox2 es igual a la palabra "Contraseña" la cual se encuentra como placeholder.
            {
                textBox2.Text = "";// Si la condicion se cumple, el placeholder se quitara y el usuario podra escribir.
                textBox2.ForeColor = Color.LightGray;
                textBox2.UseSystemPasswordChar = true;
            }
        }
        /// <summary>
        /// Metodo para mostrar el placeholder.
        /// </summary>
        private void textBox2_Leave(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "")//Condicion para preguntar si el textBox2 esta vacio.
            {
                textBox2.Text = "Contraseña";//Si se cumple esta condicion se mostrara la palabra "Contraseña" poniendo asi al placeholder.
                textBox2.ForeColor = Color.DimGray;
                textBox2.UseSystemPasswordChar= false;
            }
        }
        /// <summary>
        /// Metodo para hacer que el boton salir salga del programa.
        /// </summary>

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
