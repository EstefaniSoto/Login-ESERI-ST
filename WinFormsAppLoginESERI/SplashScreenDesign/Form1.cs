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
        int i = 1;//Variable inicializada en 1 para crear un contador.
        /// <summary>
        /// Metodo para inicializar proyecto y mostrar el SplashScreen
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //Iniciar el timer para que muestre el SplashScreen con intervalos de 7000.
            SplashTimer.Enabled= true;
            SplashTimer.Interval = 7000;
        }
       /// <summary>
       /// Metodo para detener o dejar de mostrar el SplashScreen
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void SplashTimer_Tick_1(object sender, EventArgs e)
        {
            //Linea para detener el timer una vez que este llegue al tiempo indicado.
            SplashTimer.Stop();
            this.DialogResult = DialogResult.OK;
            //Cerrar Splash.
            this.Close();

        }
        
       
    }
}
