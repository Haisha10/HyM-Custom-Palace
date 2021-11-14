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
using Entidades;
namespace Presentacion
{
    public partial class Administrador : Form
    {
        nUsuario gUsuario = new nUsuario();
        eUsuario usuarioseleccionado = null;
        int idUsuario;

        nCliente gCliente = new nCliente();
        eCliente clienteseleccionado = null;
        int idCliente;

        nMascota gMascota = new nMascota();
        eMascota mascotaseleccionado = null;
        int idMascota;

        public Administrador()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\bck_administrador.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            OcultarGroupBoxs();
        }
        private void OcultarGroupBoxs()
        {
            gbUsuarios.Enabled = false;
            gbUsuarios.Visible = false;
            gbClientes.Enabled = false;
            gbClientes.Visible = false;
            gbMascotas.Enabled = false;
            gbMascotas.Visible = false;
        }
        private void MostrarUsuarios()
        {
            dgUsuarios.DataSource = gUsuario.ListarUsuario();
        }
        private void LimpiarControlesUsuarios()
        {
            tbxUsuariosUsuario.Clear();
            tbxUsuariosContrasena.Clear();
            cbxUsuariosEstado.SelectedIndex = -1;
            tbxUsuariosNombre.Clear();
            tbxUsuariosApellido.Clear();
            tbxUsuariosDni.Clear();
            tbxUsuariosCorreo.Clear();
            tbxUsuariosTelefono.Clear();
            btnUsuariosModificar.Enabled = false;
            btnUsuariosEliminar.Enabled = false;
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                usuarioseleccionado = dgUsuarios.CurrentRow.DataBoundItem as eUsuario;
                if (usuarioseleccionado != null)
                {
                    idUsuario = usuarioseleccionado.Id;
                    tbxUsuariosUsuario.Text = usuarioseleccionado.Usuario;
                    tbxUsuariosContrasena.Text = usuarioseleccionado.Contrasena;
                    cbxUsuariosEstado.SelectedIndex = cbxUsuariosEstado.Items.IndexOf(usuarioseleccionado.Estado);
                    tbxUsuariosNombre.Text = usuarioseleccionado.Nombre;
                    tbxUsuariosApellido.Text = usuarioseleccionado.Apellido;
                    tbxUsuariosDni.Text = usuarioseleccionado.Dni.ToString();
                    tbxUsuariosCorreo.Text = usuarioseleccionado.Correo;
                    tbxUsuariosTelefono.Text = usuarioseleccionado.Telefono.ToString();
                    btnUsuariosModificar.Enabled = true;
                    btnUsuariosEliminar.Enabled = true;
                }
            }
        }
        private void btnUsuariosAgregar_Click(object sender, EventArgs e)
        {
            if(tbxUsuariosUsuario.Text != "" && tbxUsuariosContrasena.Text != "" && cbxUsuariosEstado.SelectedIndex != -1 && tbxUsuariosNombre.Text != "" && tbxUsuariosApellido.Text != "" && tbxUsuariosDni.Text != "" && tbxUsuariosCorreo.Text != "" && tbxUsuariosTelefono.Text != "")
            {
                gUsuario.RegistrarUsuario(tbxUsuariosUsuario.Text, tbxUsuariosContrasena.Text, cbxUsuariosEstado.SelectedItem.ToString(), tbxUsuariosNombre.Text, tbxUsuariosApellido.Text, Convert.ToInt64(tbxUsuariosDni.Text), tbxUsuariosCorreo.Text, Convert.ToInt64(tbxUsuariosTelefono.Text));
                MostrarUsuarios();
                LimpiarControlesUsuarios();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnUsuariosModificar_Click(object sender, EventArgs e)
        {
            if (tbxUsuariosUsuario.Text != "" && tbxUsuariosContrasena.Text != "" && cbxUsuariosEstado.SelectedIndex != -1 && tbxUsuariosNombre.Text != "" && tbxUsuariosApellido.Text != "" && tbxUsuariosDni.Text != "" && tbxUsuariosCorreo.Text != "" && tbxUsuariosTelefono.Text != "")
            {
                gUsuario.ModificarUsuario(idUsuario, tbxUsuariosUsuario.Text, tbxUsuariosContrasena.Text, cbxUsuariosEstado.SelectedItem.ToString(), tbxUsuariosNombre.Text, tbxUsuariosApellido.Text, Convert.ToInt64(tbxUsuariosDni.Text), tbxUsuariosCorreo.Text, Convert.ToInt64(tbxUsuariosTelefono.Text));
                MostrarUsuarios();
                LimpiarControlesUsuarios();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnUsuariosEliminar_Click(object sender, EventArgs e)
        {
            gUsuario.EliminarUsuario(idUsuario);
            MostrarUsuarios();
            LimpiarControlesUsuarios();
        }

        private void btnUsuariosLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControlesUsuarios();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OcultarGroupBoxs();
            gbUsuarios.Enabled = true;
            gbUsuarios.Visible = true;
            MostrarUsuarios();
            LimpiarControlesUsuarios();
            dgUsuarios.ForeColor = SystemColors.WindowText;
        }
        private void MostrarClientes()
        {
            dgClientes.DataSource = gCliente.ListarCliente();
        }
        private void LimpiarControlesClientes()
        {
            tbxClienteNombre.Clear();
            tbxClienteApellido.Clear();
            tbxClienteDni.Clear();
            tbxClienteCorreo.Clear();
            tbxClienteTelefono.Clear();
            btnClienteModificar.Enabled = false;
            btnClienteEliminar.Enabled = false;
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                clienteseleccionado = dgClientes.CurrentRow.DataBoundItem as eCliente;
                if (clienteseleccionado != null)
                {
                    idCliente = clienteseleccionado.Id;
                    tbxClienteNombre.Text = clienteseleccionado.Nombre;
                    tbxClienteApellido.Text = clienteseleccionado.Apellido;
                    tbxClienteDni.Text = clienteseleccionado.Dni.ToString();
                    tbxClienteCorreo.Text = clienteseleccionado.Correo;
                    tbxClienteTelefono.Text = clienteseleccionado.Telefono.ToString();
                    btnClienteModificar.Enabled = true;
                    btnClienteEliminar.Enabled = true;
                }
            }
        }

        private void btnClientesAgregar_Click(object sender, EventArgs e)
        {
            if(tbxClienteNombre.Text != "" && tbxClienteApellido.Text != "" && tbxClienteDni.Text != "" && tbxClienteCorreo.Text != "" && tbxClienteTelefono.Text != "")
            {
                gCliente.RegistrarCliente(tbxClienteNombre.Text, tbxClienteApellido.Text, Convert.ToInt64(tbxClienteDni.Text), tbxClienteCorreo.Text, Convert.ToInt64(tbxClienteTelefono.Text));
                MostrarClientes();
                LimpiarControlesClientes();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnClientesModificar_Click(object sender, EventArgs e)
        {
            if (tbxClienteNombre.Text != "" && tbxClienteApellido.Text != "" && tbxClienteDni.Text != "" && tbxClienteCorreo.Text != "" && tbxClienteTelefono.Text != "")
            {
                gCliente.ModificarCliente(idCliente, tbxClienteNombre.Text, tbxClienteApellido.Text, Convert.ToInt64(tbxClienteDni.Text), tbxClienteCorreo.Text, Convert.ToInt64(tbxClienteTelefono.Text));
                MostrarClientes();
                LimpiarControlesClientes();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnClientesEliminar_Click(object sender, EventArgs e)
        {
            gCliente.EliminarCliente(idCliente);
            MostrarClientes();
            LimpiarControlesClientes();
        }

        private void btnClientesLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControlesClientes();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OcultarGroupBoxs();
            gbClientes.Enabled = true;
            gbClientes.Visible = true;
            MostrarClientes();
            LimpiarControlesClientes();
            dgClientes.ForeColor = SystemColors.WindowText;
        }
        private void MostrarMascotas()
        {
            dgMascotas.DataSource = gMascota.ListarMascota();
        }
        private void LimpiarControlesMascotas()
        {
            tbxMascotaNombre.Clear();
            tbxMascotaTipo.Clear();
            tbxMascotaEdad.Clear();
            btnMascotaModificar.Enabled = false;
            btnMascotaEliminar.Enabled = false;
        }

        private void dgMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                mascotaseleccionado = dgMascotas.CurrentRow.DataBoundItem as eMascota;
                if (mascotaseleccionado != null)
                {
                    idMascota = mascotaseleccionado.Id;
                    tbxMascotaNombre.Text = mascotaseleccionado.Nombre;
                    tbxMascotaTipo.Text = mascotaseleccionado.Tipo;
                    tbxMascotaEdad.Text = mascotaseleccionado.Edad.ToString();
                    btnMascotaModificar.Enabled = true;
                    btnMascotaEliminar.Enabled = true;
                }
            }
        }

        private void btnMascotaAgregar_Click(object sender, EventArgs e)
        {
            if(tbxMascotaNombre.Text != "" && tbxMascotaTipo.Text != "" && tbxMascotaEdad.Text != "")
            {
                gMascota.RegistrarMascota(tbxMascotaNombre.Text, tbxMascotaTipo.Text, Convert.ToInt32(tbxMascotaEdad.Text));
                MostrarMascotas();
                LimpiarControlesMascotas();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnMascotaModificar_Click(object sender, EventArgs e)
        {
            if (tbxMascotaNombre.Text != "" && tbxMascotaTipo.Text != "" && tbxMascotaEdad.Text != "")
            {
                gMascota.ModificarMascota(idMascota, tbxMascotaNombre.Text, tbxMascotaTipo.Text, Convert.ToInt32(tbxMascotaEdad.Text));
                MostrarMascotas();
                LimpiarControlesMascotas();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnMascotaEliminar_Click(object sender, EventArgs e)
        {
            gMascota.EliminarMascota(idMascota);
            MostrarMascotas();
            LimpiarControlesMascotas();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            OcultarGroupBoxs();
            gbMascotas.Enabled = true;
            gbMascotas.Visible = true;
            MostrarMascotas();
            LimpiarControlesMascotas();
            dgMascotas.ForeColor = SystemColors.WindowText;
        }
    }
}
