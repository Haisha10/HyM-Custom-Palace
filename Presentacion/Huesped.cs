using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class Huesped : Form
    {
        nCliente gCliente = new nCliente();
        nMascota gMascota = new nMascota();
        nServicio gServicio = new nServicio();
        public Huesped()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\bck_huesped.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            gbMascota.Enabled = false;
            rbnClienteMascotaNo.Checked = true;
            rbnServicioTipoClasico.Checked = true;

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
                tbxMascotaNombre.Clear();
                tbxMascotaTipo.Clear();
                tbxMascotaEdad.Clear();
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

        private void btnHuespedRegistrar_Click(object sender, EventArgs e)
        {
            int? id_mascota;
            string tipo;
            if(tbxClienteNombre.Text != "" && tbxClienteApellido.Text != "" && tbxClienteDni.Text != "" && tbxClienteTelefono.Text != "" && tbxClienteCorreo.Text != "" &&
                (gbMascota.Enabled == false || (tbxMascotaNombre.Text != "" && tbxMascotaTipo.Text != "" && tbxMascotaEdad.Text != "")) &&
                tbxServicioNumero.Text != "" && tbxServicioTematica.Text != "" && cbxServicioPaquete.SelectedIndex != -1 && tbxServicioIngreso.Text != "" && tbxServicioSalida.Text != "")
            {
                int id_cliente = gCliente.RegistrarCliente(tbxClienteNombre.Text.Trim(), tbxClienteApellido.Text.Trim(), Convert.ToInt64(tbxClienteDni.Text.Trim()), tbxClienteCorreo.Text.Trim(), Convert.ToInt64(tbxClienteTelefono.Text.Trim()));
                if (gbMascota.Enabled)
                {
                    id_mascota = gMascota.RegistrarMascota(tbxMascotaNombre.Text.Trim(), tbxMascotaTipo.Text.Trim(), Convert.ToInt32(tbxMascotaEdad.Text.Trim()));
                }
                else
                {
                    id_mascota = null;
                }
                if (rbnServicioTipoClasico.Checked)
                {
                    tipo = "Clasico";
                }
                else
                {
                    tipo = "Personalizado";
                }
                gServicio.RegistrarServicio(Convert.ToInt32(tbxServicioNumero.Text.Trim()), tipo, tbxServicioTematica.Text.Trim(), cbxServicioPaquete.SelectedItem.ToString(), Convert.ToDouble(lblServicioPrecio.Text), DateTime.Parse(tbxServicioIngreso.Text.Trim()), DateTime.Parse(tbxServicioSalida.Text.Trim()), DateTime.Now, id_cliente, id_mascota);
                MessageBox.Show("Registrado");
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }
    }
}
