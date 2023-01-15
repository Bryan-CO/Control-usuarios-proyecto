using Capa_datos.DAO;
using Capa_Presentacion.Clases;
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
    public partial class Buscar : Form
    {
        Usuarios_DAO dao = new Usuarios_DAO();
        public Buscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codigo = txt_busqueda.Text;
            Usuario user = dao.buscar(codigo);


            if ( user != null )
            {
                MessageBox.Show("Usuario encontrado");
                panel_buscar.Visible = true;
                txt_codigo.Text = user.codigo;
                txt_user.Text = user.usuario;
                txt_pass.Text = user.contraseña;
                txt_nombre.Text = user.nombres;
                txt_apellido.Text = user.apellidos;
                pb_autor.Image = Image.FromFile(user.foto);
                txt_usuario_foto.Text = user.usuario;
            }
            else
            {
                MessageBox.Show("Usuario no existente");
            }
        }

        private void txt_busqueda_MouseClick(object sender, MouseEventArgs e)
        {
            txt_busqueda.Clear();
            txt_busqueda.ForeColor = Color.White;
            txt_busqueda.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular);
        }
    }
}
