using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daylyrutine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form dy = new menuvertical();
            dy.ShowDialog();
        }

        private void botoncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            botonmaximizarinicio.Visible = false;
            botonminimizarinicio.Visible = true;
        }

        private void botonocultarinicio_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void botonminimizarinicio_Click(object sender, EventArgs e)
        {
            //comando para minimizar la pagina
            this.WindowState = FormWindowState.Normal;
            botonmaximizarinicio.Visible = false;
            botonminimizarinicio.Visible = true;
        }
    }
}
