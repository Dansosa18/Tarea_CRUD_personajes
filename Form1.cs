using DB_1.data.data_acces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_1
{
    public partial class Form1 : Form
    {
        private PersonajeDB personaje;
        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajeDB();
        }

        private void Prueba_Click(object sender, EventArgs e)
        {
            if (personaje.ProbarConexion())
            { MessageBox.Show("Si se pudo 👌❤️😍😍😘"); }
            else
            {
                MessageBox.Show("Nel Pastel 😢😒🥲😓😔");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        
            private void buttoninsertar_Click(object sender, EventArgs e)
            {
                string nombre = textBoxNombre.Text;
                string historia= richTextBoxHistoria.Text;
            DateTime fechaCreacion = dateTimePickerFecha_Creacion.Value;

            string raza = textBoxRaza.Text;
                int nivelPoder = (int)numericUpDownNivelPoder.Value;
                int respuesta = personaje.CrearPersonaje(nombre, raza, nivelPoder, historia, fechaCreacion);
       


            if (respuesta > 0)
                {
                LimpiarTextBox();
                    MessageBox.Show("Se creo correctamente");
                    dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();

                }
                else
                {
                    MessageBox.Show("Hubo un error al crear personaje");
                }
            }
        private void LimpiarTextBox()
        {
            textBoxNombre.Text = "";
            textBoxRaza.Text = "";
            numericUpDownNivelPoder.Value = 0;
            dateTimePickerFecha_Creacion.Value = DateTime.Now;
            richTextBoxHistoria.Text = "";

        }

        private void richTextBoxHistoria_TextChanged(object sender, EventArgs e)
        {

        }
    }


        
}
