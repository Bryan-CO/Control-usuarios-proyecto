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
    public partial class Mantenimiento : Form
    {
        Usuarios_DAO dao = new Usuarios_DAO();
        public Mantenimiento()
        {
            InitializeComponent();
            mostrar();
            mostrar_datos(0);

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            agregar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagenes (*.BP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Mostrar el cuadro de diálogo y obtener el resultado
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener el nombre del archivo seleccionado
                string fileName = openFileDialog1.FileName;
                // Cargar la imagen seleccionada en un PictureBox
                pictureBox1.Image = new Bitmap(fileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (fila <=-1)
            {
                return;
            }
            else
            {
                mostrar_datos(fila);
            }

            
        }
        public void mostrar_datos(int x)
        {
            txt_codigo.Text = dao.mostrar()[x].codigo.ToString();
            txt_user.Text = dao.mostrar()[x].usuario.ToString();
            txt_nombre.Text = dao.mostrar()[x].nombres.ToString();
            txt_apellido.Text = dao.mostrar()[x].apellidos.ToString();
            pictureBox1.Image = Image.FromFile(dao.mostrar()[x].foto.ToString());
        }

       public void mostrar()
        {
            dgv_usuarios.DataSource = dao.mostrar().ToArray();
            dgv_usuarios.Columns[0].HeaderText = "Código";
            dgv_usuarios.Columns[1].HeaderText = "Usuario";
            dgv_usuarios.Columns[2].HeaderText = "Password";
            dgv_usuarios.Columns[3].Visible = false;
            dgv_usuarios.Columns[4].Visible = false;
            dgv_usuarios.Columns[5].Visible = false;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Usuarios_DAO dao = new Usuarios_DAO();
            int fila = dgv_usuarios.CurrentRow.Index;
            dao.eliminar(fila);
            mostrar();
            mostrar_datos(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            mostrar();
            mostrar_datos(0);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int fila = dgv_usuarios.CurrentRow.Index;
            Modificar modificar = new Modificar(fila);
            modificar.ShowDialog();
        }
    }
}
