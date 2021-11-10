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
    public partial class Login : Form
    {
        nUsuario gUsuario = new nUsuario();
        public Login()
        {
            InitializeComponent();

            //Imagen de fondo
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\bck_login.png");
            BackgroundImage = img;
            BackgroundImageLayout = ImageLayout.Stretch;

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Textboxs rellenados
            if(tbxUsuario.Text != "" && tbxContrasena.Text != "")
            {
                eUsuario ingreso = gUsuario.VerificarUsuario(tbxUsuario.Text.Trim(), tbxContrasena.Text.Trim());
                if (ingreso == null) //No existe usuario con dichas credenciales
                {
                    MessageBox.Show("Credenciales de acceso incorrectas.");
                }
                else if (ingreso.Estado == "Recepcionista") //Tiene privilegios de Recepcionista
                {
                    Hide();
                    using (Huesped frmHuesped = new Huesped())
                        frmHuesped.ShowDialog();
                    Show();
                }
                else if (ingreso.Estado == "Administrador") //Tiene privilegios de Administrador
                {
                    Hide();
                    using (Administrador frmAdministrador = new Administrador())
                        frmAdministrador.ShowDialog();
                    Show();
                }
                else //Cualquier otro privilegio no tiene acceso al sistema
                {
                    MessageBox.Show("Usted no tiene acceso al sistema.");
                }
                tbxUsuario.Clear();
                tbxContrasena.Clear();
            }
            else //Textboxs vacios
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }
        private void btnReestablecerContrasena_Click(object sender, EventArgs e)
        {
            using (Recuperacion frmRecuperacion = new Recuperacion())
                frmRecuperacion.ShowDialog();
        }
    }
}
