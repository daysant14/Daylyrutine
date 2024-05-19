using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace daylyrutine
{
    public partial class menuvertical : Form
    {
       

        public menuvertical()
        { 
        InitializeComponent();
            
        //this.tarealist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.tarealist_ItemCheck);
    }

        private void botoncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonmaximizar_Click(object sender, EventArgs e)
        {   //comando para maximixzar la pagina
            this.WindowState = FormWindowState.Maximized; 
            botonmaximizar.Visible = false; 
            botonrestaurar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {   //comando para minimizar la pagina
            this.WindowState = FormWindowState.Normal; 
            botonmaximizar.Visible = false;
            botonrestaurar.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   //ocultar pagina
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Barratitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonrestaurar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form dy = new habito();
            dy.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            

            



                SqlConnection conexion = new SqlConnection("server=DESKTOP-L9P4EIJ;database=esparta; integrated security= true");
                conexion.Open();

                tarealist.Items.Add(textBox1.Text);

                string descri = textBox1.Text;

                string cadena = "insert into tarea (tarea) values ('" + descri + "')";


                SqlCommand comando = new SqlCommand(cadena, conexion);
                
                comando.ExecuteNonQuery();
                MessageBox.Show("se guardaron tus tareas");
                textBox1.Text= "";


                MessageBox.Show("se conecto");
                conexion.Close();


            }

        private void button2_Click(object sender, EventArgs e)
   
        {
            // Mostrar un cuadro de diálogo para preguntar al usuario si desea borrar el CheckedListBox
            DialogResult result = MessageBox.Show("¿Desea borrar las tareas marcadas como realizadas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {

                for (int i = tarealist.CheckedItems.Count - 1; i >= 0; i--)
                {
                    tarealist.Items.RemoveAt(tarealist.CheckedIndices[i]);
                }
            }
            else if (result == DialogResult.No)
            {

            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para preguntar al usuario si desea borrar el CheckedListBox
            DialogResult result = MessageBox.Show("¿Desea borrar todas las tareas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Borrar el contenido del CheckedListBox
                tarealist.Items.Clear();
            }
            else if (result == DialogResult.No)
            {

            }









        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
                // Crear una instancia de ColorDialog
                ColorDialog colorDialog = new ColorDialog();

                // Mostrar el diálogo de selección de color y verificar si el usuario hizo clic en "OK"
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener el color seleccionado por el usuario
                    Color colorSeleccionado = colorDialog.Color;

                    // Asignar el color seleccionado al fondo del panel
                    panel1.BackColor = colorSeleccionado;
                }
            

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // Crear una instancia de ColorDialog
            ColorDialog colorDialog = new ColorDialog();

            // Mostrar el diálogo de selección de color y verificar si el usuario hizo clic en "OK"
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener el color seleccionado por el usuario
                Color colorSeleccionado = colorDialog.Color;

                // Asignar el color seleccionado al fondo del panel
               Barratitulo.BackColor = colorSeleccionado;
            }
        }
       
        private void tarealist_ItemCheck(object sender, ItemCheckEventArgs e )
        {

            
              
            



        }

        private void tarealist_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
            

        }
       

    }
}
