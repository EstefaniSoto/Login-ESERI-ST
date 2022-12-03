using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLoginESERI
{
    public partial class Form1 : Form
    {
        int i = 1;//Variable inicializada en 1 para crear un contador
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;//Habilitamos el iniciar el contador para que muestre el SplashScreen
        }
       

        private void SplashTimer_Tick_1(object sender, EventArgs e)
        {
            i += 1;// Incremento de variable de 1 en 1
            if (i == 12)//Esta sentencia se ejecutara cuando se evalue como verdadera, es decir, cuando el contador llegue a 12 se ejecutara.
            {
                SplashTimer.Enabled = false; //Deshabilitamos el timer
                this.Hide();//Escondemos el Splash
                MainForm mainForm = new MainForm();
                mainForm.Show();//Mostramos el formulario de Login una vez que el SplashScreen termina de ejecutarse
            }
        }

       
    }
}
