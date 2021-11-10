using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void btnReestablecerContrasena_Click(object sender, EventArgs e)
        {
            //Textboxs rellenados
            if(tbxUsuario.Text != "" && tbxContrasena.Text != "" && tbxContraseñaConfirmar.Text != "" && tbxDni.Text != "" && tbxCorreo.Text != "" && tbxTelefono.Text != "")
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
