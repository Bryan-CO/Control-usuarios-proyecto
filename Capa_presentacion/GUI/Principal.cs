using Capa_datos.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Presentacion.GUI
{
    public partial class Principal : Form
    {
        public String usuario = "";
        Login login = new Login();
        Usuarios_DAO dao = new Usuarios_DAO();
        Datos datos = new Datos();
        String ruta = "Imagenes\\";
        public Principal()
        {
            InitializeComponent();
            mostrar_datos();
        }
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void mostrar_formularios(Form x)
        {
                this.tsc_principal.Controls.Clear();
                x.MdiParent = this;

                this.tsc_principal.Controls.Add(x);
                x.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(29, 39, 44);
            button1.BackColor = Color.FromArgb(40, 60, 76);
            button2.BackColor = Color.FromArgb(40, 60, 76);
            
            Mantenimiento mantenimiento = new Mantenimiento();
            mostrar_formularios(mantenimiento);
            lbl_ventana.Text = "Mantenimiento";
            pb_ventana.Image = Image.FromFile(ruta+"Mantenimiento.png");
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(29, 39, 44);
            button3.BackColor = Color.FromArgb(40, 60, 76);
            button2.BackColor = Color.FromArgb(40, 60, 76);
            
            Autores autores = new Autores();
            mostrar_formularios(autores);
            lbl_ventana.Text = "Autores";
            pb_ventana.Image = Image.FromFile(ruta + "Autores.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }
        public void mostrar_datos()
        {
            mostrar_formularios(datos);
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mostrar_formularios(datos);
            lbl_ventana.Text = "Principal";
            pb_ventana.Image = Image.FromFile(ruta + "Home.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(29, 39, 44);
            button1.BackColor = Color.FromArgb(40, 60, 76);
            button3.BackColor = Color.FromArgb(40, 60, 76);
            
            Buscar buscar = new Buscar();
            mostrar_formularios(buscar);
            lbl_ventana.Text = "Buscar";
            pb_ventana.Image = Image.FromFile(ruta + "Buscar.png");
        }
    }
}
