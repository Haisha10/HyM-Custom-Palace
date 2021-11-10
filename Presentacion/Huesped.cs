using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Huesped : Form
    {
        public Huesped()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\bck_huesped.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            gbMascota.Enabled = false;

        }

        private void btnReestablecerContrasena_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void rbnClienteMascotaSi_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnClienteMascotaSi.Checked == true)
            {
                gbMascota.Enabled = true;
            }
            else
            {
                gbMascota.Enabled = false;
            }
        }

        private void rbnServicioTipoClasico_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnServicioTipoClasico.Checked == true)
            {
                tbxServicioTematica.Text = "Clasico";
                tbxServicioTematica.Enabled = false;
            }
            else
            {
                tbxServicioTematica.Text = "";
                tbxServicioTematica.Enabled = true;
            }
        }
    }
}
