using Capa_datos.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.GUI
{
    public partial class Modificar : Form
    {
        String fileName;
        int num_fila;
        Mantenimiento mantenimiento = new Mantenimiento();
        Usuarios_DAO dao = new Usuarios_DAO();
        
        public Modificar(int x)
        {
            InitializeComponent();
            num_fila = x;

            fileName = dao.mostrar_datos_modificar(num_fila).foto;


            txt_codigo.Text = dao.mostrar_datos_modificar(num_fila).codigo;
            txt_user.Text = dao.mostrar_datos_modificar(num_fila).usuario;
            txt_pass.Text = dao.mostrar_datos_modificar(num_fila).contraseña;
            txt_nombre.Text = dao.mostrar_datos_modificar(num_fila).nombres;
            txt_apellido.Text = dao.mostrar_datos_modificar(num_fila).apellidos;
            pictureBox1.Image = Image.FromFile(dao.mostrar_datos_modificar(num_fila).foto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String codigo, usuario, contraseña, nombre, apellido, foto;
            codigo = txt_codigo.Text;
            usuario = txt_user.Text;
            contraseña = txt_pass.Text;
            nombre = txt_nombre.Text;
            apellido = txt_apellido.Text;
            foto = fileName;

            dao.modificar(num_fila, codigo, usuario, contraseña, nombre, apellido, foto);

            MessageBox.Show("Modificación exitosa!");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagenes (*.BP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Esto es para cuando coloco ok o aceptar al seleccionar una imagen
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener el nombre del archivo seleccionado
                fileName = openFileDialog1.FileName;
                // Cargar la imagen seleccionada en el PictureBox
                pictureBox1.Image = new Bitmap(fileName);
            }
        }
    }
}
