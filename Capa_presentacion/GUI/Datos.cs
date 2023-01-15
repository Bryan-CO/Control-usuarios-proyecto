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
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            String fecha_minscula = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            String fecha = fecha_minscula.Substring(0, 1).ToUpper() + fecha_minscula.Substring(1);
            lbl_fecha.Text = fecha;
        }
    }
}
