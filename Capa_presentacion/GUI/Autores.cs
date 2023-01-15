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
    public partial class Autores : Form
    {
        Autor_DAO dao= new Autor_DAO();
        String ruta = "Imagenes\\";
        public Autores()
        {
            InitializeComponent();
            mostrar(0);
            pb_autor.Image = Image.FromFile(ruta + "autor.jpg");
        }

        void mostrar(int x)
        {

            txt_codigo.Text = dao.mostrar()[x].Codigo;
            txt_nombre.Text = dao.mostrar()[x].Nombre;
            txt_apellido.Text = dao.mostrar()[x].Apellido;
            txt_ciclo.Text = dao.mostrar()[x].Ciclo;
            txt_curso.Text = dao.mostrar()[0].Curso;
            txt_carrera.Text = dao.mostrar()[x].Carrera;
        }

        private void pb_autor_Click(object sender, EventArgs e)
        {

        }

        private void Autores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mostrar(0);
            pb_autor.Image = Image.FromFile(ruta + "autor.jpg");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mostrar(1);
            pb_autor.Image = Image.FromFile(ruta + "autor.jpg");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            mostrar(2);
            pb_autor.Image = Image.FromFile(ruta + "autor.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mostrar(3);
            pb_autor.Image = Image.FromFile(ruta + "autor.jpg");
        }
    }
}
