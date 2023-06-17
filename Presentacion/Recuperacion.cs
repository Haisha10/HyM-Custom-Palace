using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Recuperacion : Form
    {
        nUsuario gUsuario = new nUsuario();
        public Recuperacion()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\bck_restablecer_contrasena.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnReestablecerContrasena_Click(object sender, EventArgs e)
        {
            if (!(Regex.IsMatch(tbxTelefono.Text, "^9[0-9]{8}$") &&
                int.TryParse(tbxTelefono.Text, out int telefono) &&
                telefono >= 900000000 && telefono <= 999999999))
            {
                MessageBox.Show("Telefono de Cliente invalido. Ingrese un número de 9 dígitos, que empiece con nueve.");
                return;
            }
            if (!(Regex.IsMatch(tbxDni.Text, "^[0-9]{8}$") &&
                int.TryParse(tbxDni.Text, out int dni) &&
                dni >= 1 && dni <= 99999999))
            {
                MessageBox.Show("DNI de Cliente invalido. Ingrese un número de 8 dígitos, que empiece con 'ceros' de ser necesario.");
                return;
            }
            //Textboxs rellenados
            if (tbxUsuario.Text != "" && tbxContrasena.Text != "" && tbxContraseñaConfirmar.Text != "" && tbxDni.Text != "" && tbxCorreo.Text != "" && tbxTelefono.Text != "")
            {
                if(tbxContrasena.Text == tbxContraseñaConfirmar.Text) //Contraseñas iguales
                {
                    MessageBox.Show(gUsuario.ReestablecerUsuario(tbxUsuario.Text.Trim(), tbxContrasena.Text.Trim(), Convert.ToInt64(tbxDni.Text.Trim()), tbxCorreo.Text.Trim(), Convert.ToInt64(tbxTelefono.Text.Trim())));
                    Close();
                }
                else //Contraseñas diferentes
                {
                    MessageBox.Show("Las contraseñas ingresadas son diferentes.");
                }
            }
            else //Texboxs vacios
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
