using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace daylyrutine
{
    public partial class habito : Form
    {
        public habito()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void botoncerrar_Click(object sender, EventArgs e)
        {
            Form dy = new menuvertical();
            dy.ShowDialog();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection conexion = new SqlConnection("server=DESKTOP-L9P4EIJ;database=esparta; integrated security= true");
            conexion.Open();

            Habitolist.Items.Add(textboxhabito.Text);

            string descri = textboxhabito.Text;

            string cadena = "insert into Habito (habito) values ('" + descri + "')";


            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("se guardaron tus habitos");
            textboxhabito.Text = "";


            MessageBox.Show("se conecto");
            conexion.Close();



        }

        private void borrarhabito_Click(object sender, EventArgs e)
        {

            
            
         // Mostrar un cuadro de diálogo para preguntar al usuario si desea borrar el CheckedListBox
         DialogResult result = MessageBox.Show("¿Desea borrar los habitos seleccionados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {    
                for (int i = Habitolist.CheckedItems.Count - 1; i >= 0; i--)
                {
                    Habitolist.Items.RemoveAt(Habitolist.CheckedIndices[i]);
                }
            }
            else if (result == DialogResult.No)
            {

               
            }


            }

        private void habito_Load(object sender, EventArgs e)
        {

        }
    }
}
