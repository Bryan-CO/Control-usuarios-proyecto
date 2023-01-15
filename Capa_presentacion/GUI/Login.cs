using Capa_datos.DAO;
using Capa_Presentacion.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        Usuarios_DAO login_dao = new Usuarios_DAO();
        
        public Login()
        {
            InitializeComponent();
            
            
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void btn_ingresar_Click(object sender, EventArgs e)
        {
            
            String usuario, contraseña;
            usuario = txt_usuario.Text;
            contraseña = txt_contraseña.Text;
            String[] ingresar = login_dao.ingresar(usuario, contraseña);

            
            if (ingresar != null)
            {
                Principal principal = new Principal();
                principal.lbl_usuario.Text = ingresar[0];
                principal.lbl_nombre.Text = ingresar[1];
                principal.lbl_apellido.Text = ingresar[2];
                MessageBox.Show("Bienvenido!");
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrecto :(");
                
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int cant = login_dao.cant();
            MessageBox.Show(cant.ToString());
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}