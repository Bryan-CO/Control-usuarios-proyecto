using Capa_datos.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.GUI
{
    public partial class Agregar : Form
    {
        String fileName = "foto_defecto.jpg";
        Usuarios_DAO dao = new Usuarios_DAO();
        Mantenimiento mant = new Mantenimiento();
        public Agregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Agregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            mant.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String codigo, user, pass, nombre, apellido, foto;
            codigo = txt_codigo.Text;
            user = txt_user.Text;
            pass = txt_pass.Text;
            nombre = txt_nombre.Text;
            apellido = txt_apellido.Text;
            foto = fileName;
            
            dao.agregar(codigo, user, pass, nombre, apellido, foto);

            MessageBox.Show("Usuario agregado!");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagenes (*.BP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Mostrar el cuadro de diálogo y obtener el resultado
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener el nombre del archivo seleccionado
                fileName = openFileDialog1.FileName;
                // Cargar la imagen seleccionada en un PictureBox
                pictureBox1.Image = new Bitmap(fileName);
            }
        }
    }
}
