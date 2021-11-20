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

        nEFE nEFE = new nEFE();
        nER nER = new nER();
        nESF nESF = new nESF();
        nServicio gServicio = new nServicio();

        private BindingSource bindingSource = new BindingSource();
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();

        public Administrador()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\bck_administrador.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            OcultarGroupBoxs();
            OcultarReportes();

            gbReporteMascota.ForeColor = SystemColors.ControlLightLight;
            gbTematica.ForeColor = SystemColors.ControlLightLight;
            gbIntervalofecha.ForeColor = SystemColors.ControlLightLight;
            gbtipohabitacion.ForeColor = SystemColors.ControlLightLight;
            gbClientesMascota.ForeColor = SystemColors.ControlLightLight;
            gbFechaFacturacion.ForeColor = SystemColors.ControlLightLight;
            gbReportesFinancieros.ForeColor = SystemColors.ControlLightLight;
        }
        private void OcultarGroupBoxs()
        {
            gbUsuarios.Enabled = false;
            gbUsuarios.Visible = false;
            gbClientes.Enabled = false;
            gbClientes.Visible = false;
            gbMascotas.Enabled = false;
            gbMascotas.Visible = false;
            gbEFE.Enabled = false;
            gbEFE.Visible = false;
            gbER.Enabled = false;
            gbER.Visible = false;
            gbESF.Enabled = false;
            gbESF.Visible = false;
            gbReporte.Enabled = false;
            gbReporte.Visible = false;
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

        private void Mostrar_EFE()
        {
            dgvEFE.DataSource = nEFE.Listar_EFE();
        }
        private void btnEFE_Click(object sender, EventArgs e)
        {
            OcultarGroupBoxs();
            gbEFE.Enabled = true;
            gbEFE.Visible = true;
            Mostrar_EFE();
            LimpiarControlesEFE();
            dgvEFE.ForeColor = SystemColors.WindowText;
        }

        private void btnAgregarEFE_Click(object sender, EventArgs e)
        {
            if (txtAFinanciacion.Text != "" && txtAInversion.Text != "" && txtAOperacion.Text != "" && txtEfectEquiv.Text != "" && txtFechaEFE.Text != "")
            {
                nEFE.Insertar_EFE(Convert.ToDateTime(txtFechaEFE.Text.Trim()),Convert.ToDecimal(txtAOperacion.Text.Trim()), Convert.ToDecimal(txtAFinanciacion.Text.Trim()), Convert.ToDecimal(txtAInversion.Text.Trim()), Convert.ToDecimal(txtEfectEquiv.Text.Trim()));
                Mostrar_EFE();
                LimpiarControlesEFE();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnModificarEFE_Click(object sender, EventArgs e)
        {
            int cant = dgvEFE.SelectedRows.Count;
            if (txtAFinanciacion.Text != "" && txtAInversion.Text != "" && txtAOperacion.Text != "" && txtEfectEquiv.Text != "" && txtFechaEFE.Text != "")
            {
                if(cant==1)
                {
                    if(!dgvEFE.SelectedRows[0].IsNewRow)
                    {
                        int codigo = Convert.ToInt32(dgvEFE.SelectedRows[0].Cells[0].Value);
                        nEFE.Modificar_EFE(codigo, Convert.ToDateTime(txtFechaEFE.Text.Trim()), Convert.ToDecimal(txtAOperacion.Text.Trim()), Convert.ToDecimal(txtAFinanciacion.Text.Trim()), Convert.ToDecimal(txtAInversion.Text.Trim()), Convert.ToDecimal(txtEfectEquiv.Text.Trim()));
                        Mostrar_EFE();
                        LimpiarControlesEFE();
                    }
                }
                else
                {
                    MessageBox.Show("Error al modificar.");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnEliminarEFE_Click(object sender, EventArgs e)
        {
            int cant = dgvEFE.SelectedRows.Count;
            if(cant==1)
            {
                if(!dgvEFE.SelectedRows[0].IsNewRow)
                {
                    int codigo = Convert.ToInt32(dgvEFE.SelectedRows[0].Cells[0].Value);
                    nEFE.Eliminar_EFE(codigo);
                    Mostrar_EFE();
                    LimpiarControlesEFE();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar.");
            }
            
        }

        private void btnLimpiarEFE_Click(object sender, EventArgs e)
        {
            LimpiarControlesEFE();
        }
        private void LimpiarControlesEFE()
        {
            txtEfectEquiv.Clear();
            txtFechaEFE.Clear();
            txtAOperacion.Clear();
            txtAInversion.Clear();
            txtAFinanciacion.Clear();
        }

        private void Mostrar_ER()
        {
            dgvER.DataSource = nER.Listar_ER();
        }
        private void btnER_Click(object sender, EventArgs e)
        {
            OcultarGroupBoxs();
            gbER.Enabled = true;
            gbER.Visible = true;
            Mostrar_ER();
            LimpiarControlesER();
            dgvER.ForeColor = SystemColors.WindowText;
        }

        private void btnAgregarER_Click(object sender, EventArgs e)
        {
            if (txtFechaRegistroER.Text != "" && txtIRER.Text != "" && txtOtrosGaeInER.Text != "" && txtCostoVentasER.Text != "" && txtUtiNetaER.Text != "" && txtVentasER.Text != "" && txtUtiBrutaER.Text != "" && txtUtiOperativaER.Text != "")
            {
                nER.Insertar_ER(Convert.ToDateTime(txtFechaRegistroER.Text.Trim()), Convert.ToDecimal(txtVentasER.Text.Trim()), Convert.ToDecimal(txtCostoVentasER.Text.Trim()), Convert.ToDecimal(txtUtiBrutaER.Text.Trim()), Convert.ToDecimal(txtOtrosGaeInER.Text.Trim()), Convert.ToDecimal(txtUtiOperativaER.Text.Trim()), Convert.ToDecimal(txtIRER.Text), Convert.ToDecimal(txtUtiNetaER.Text.Trim()));
                Mostrar_ER();
                LimpiarControlesER();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnModificarER_Click(object sender, EventArgs e)
        {
            int cant = dgvER.SelectedRows.Count;
            if (txtFechaRegistroER.Text != "" && txtIRER.Text != "" && txtOtrosGaeInER.Text != "" && txtCostoVentasER.Text != "" && txtUtiNetaER.Text != "" && txtVentasER.Text != "" && txtUtiBrutaER.Text != "" && txtUtiOperativaER.Text != "")
            {
                if (cant == 1)
                {
                    if (!dgvER.SelectedRows[0].IsNewRow)
                    {
                        int codigo = Convert.ToInt32(dgvER.SelectedRows[0].Cells[0].Value);
                        nER.Modificar_ER(codigo, Convert.ToDateTime(txtFechaRegistroER.Text.Trim()), Convert.ToDecimal(txtVentasER.Text.Trim()), Convert.ToDecimal(txtCostoVentasER.Text.Trim()), Convert.ToDecimal(txtUtiBrutaER.Text.Trim()), Convert.ToDecimal(txtOtrosGaeInER.Text.Trim()), Convert.ToDecimal(txtUtiOperativaER.Text.Trim()), Convert.ToDecimal(txtIRER.Text), Convert.ToDecimal(txtUtiNetaER.Text.Trim()));
                        Mostrar_ER();
                        LimpiarControlesER();
                    }
                }
                else
                {
                    MessageBox.Show("Error al modificar.");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnEliminarER_Click(object sender, EventArgs e)
        {
            int cant = dgvER.SelectedRows.Count;
            if (cant == 1)
            {
                if (!dgvER.SelectedRows[0].IsNewRow)
                {
                    int codigo = Convert.ToInt32(dgvER.SelectedRows[0].Cells[0].Value);
                    nER.Eliminar_ER(codigo);
                    Mostrar_ER();
                    LimpiarControlesER();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar.");
            }
        }

        private void btnLimpiarER_Click(object sender, EventArgs e)
        {
            LimpiarControlesER();
        }
        private void LimpiarControlesER()
        {
            txtFechaRegistroER.Clear();
            txtIRER.Clear();
            txtCostoVentasER.Clear();
            txtUtiBrutaER.Clear();
            txtUtiOperativaER.Clear();
            txtUtiNetaER.Clear();
            txtUtiOperativaER.Clear();
            txtVentasER.Clear();
            txtOtrosGaeInER.Clear();
        }

        private void btnESF_Click(object sender, EventArgs e)
        {
            OcultarGroupBoxs();
            gbESF.Enabled = true;
            gbESF.Visible = true;
            Mostrar_ESF();
            LimpiarControlesESF();
            dgvESF.ForeColor = SystemColors.WindowText;
        }
        private void Mostrar_ESF()
        {
            dgvESF.DataSource = nESF.Listar_ESF();
        }

        private void btnAgregarESF_Click(object sender, EventArgs e)
        {
            if (txtFechaRegistroESF.Text != "" && txtActivoCorrienteESF.Text != "" && txtActivoNoCorrienteESF.Text != "" && txtPasivoCorrienteESF.Text != "" && txtPasivoNoCorrienteESF.Text != "" && txtPatrimonioESF.Text != "" && txtTotalActivoESF.Text != "" && txtTotalPasyPatrESF.Text != "")
            {
                nESF.Insertar_ESF(Convert.ToDateTime(txtFechaRegistroESF.Text), Convert.ToDecimal(txtActivoCorrienteESF.Text), Convert.ToDecimal(txtActivoNoCorrienteESF.Text), Convert.ToDecimal(txtTotalActivoESF.Text), Convert.ToDecimal(txtPasivoCorrienteESF.Text), Convert.ToDecimal(txtPasivoNoCorrienteESF.Text), Convert.ToDecimal(txtPatrimonioESF.Text), Convert.ToDecimal(txtTotalPasyPatrESF.Text));
                Mostrar_ESF();
                LimpiarControlesESF();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnModificarESF_Click(object sender, EventArgs e)
        {
            int cant = dgvESF.SelectedRows.Count;
            if (txtFechaRegistroESF.Text != "" && txtActivoCorrienteESF.Text != "" && txtActivoNoCorrienteESF.Text != "" && txtPasivoCorrienteESF.Text != "" && txtPasivoNoCorrienteESF.Text != "" && txtPatrimonioESF.Text != "" && txtTotalActivoESF.Text != "" && txtTotalPasyPatrESF.Text != "")
            {
                if (cant == 1)
                {
                    if (!dgvESF.SelectedRows[0].IsNewRow)
                    {
                        int codigo = Convert.ToInt32(dgvESF.SelectedRows[0].Cells[0].Value);
                        nESF.Modificar_ESF(codigo, Convert.ToDateTime(txtFechaRegistroESF.Text.Trim()), Convert.ToDecimal(txtActivoCorrienteESF.Text.Trim()), Convert.ToDecimal(txtActivoNoCorrienteESF.Text.Trim()), Convert.ToDecimal(txtTotalActivoESF.Text.Trim()), Convert.ToDecimal(txtPasivoCorrienteESF.Text.Trim()), Convert.ToDecimal(txtPasivoNoCorrienteESF.Text.Trim()), Convert.ToDecimal(txtPatrimonioESF.Text.Trim()), Convert.ToDecimal(txtTotalPasyPatrESF.Text.Trim()));
                        Mostrar_ESF();
                        LimpiarControlesESF();
                    }
                }
                else
                {
                    MessageBox.Show("Error al modificar.");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnELiminarESF_Click(object sender, EventArgs e)
        {
            int cant = dgvESF.SelectedRows.Count;
            if (cant == 1)
            {
                if (!dgvESF.SelectedRows[0].IsNewRow)
                {
                    int codigo = Convert.ToInt32(dgvESF.SelectedRows[0].Cells[0].Value);
                    nESF.Eliminar_ESF(codigo);
                    Mostrar_ESF();
                    LimpiarControlesESF();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar.");
            }
        }

        private void btnLimpiarESF_Click(object sender, EventArgs e)
        {
            LimpiarControlesESF();
        }
        private void LimpiarControlesESF()
        {
            txtActivoCorrienteESF.Clear();
            txtActivoNoCorrienteESF.Clear();
            txtTotalActivoESF.Clear();
            txtFechaRegistroESF.Clear();
            txtPasivoCorrienteESF.Clear();
            txtPasivoNoCorrienteESF.Clear();
            txtPatrimonioESF.Clear();
            txtTotalPasyPatrESF.Clear();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void gbER_Enter(object sender, EventArgs e)
        {
            
        }


        private void txtUtiBrutaER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtUtiOperativaER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtUtiNetaER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtOtrosGaeInER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90)||(e.KeyChar >= 97 && e.KeyChar <= 122)) 
            {
                e.Handled = true;
                return;
            }
        }

        private void txtIRER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtUtiBrutaER_TextChanged(object sender, EventArgs e)
        {
            if (txtVentasER.Text != "" && txtCostoVentasER.Text != "")
            {
                txtUtiBrutaER.Text = (Convert.ToInt32(txtVentasER.Text) - Convert.ToInt32(txtCostoVentasER.Text)).ToString();
            }
        }

        private void txtVentasER_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtCostoVentasER.Text!=""&&txtVentasER.Text!="")
                txtUtiBrutaER.Text = (Convert.ToInt32(txtVentasER.Text) - Convert.ToInt32(txtCostoVentasER.Text)).ToString();
        }


        private void btnReporte_Click(object sender, EventArgs e)
        {
            OcultarGroupBoxs();
            gbReporte.Enabled = true;
            gbReporte.Visible = true;
            OcultarReportes();
            dgvReportes.ForeColor = SystemColors.WindowText;
        }

        private void OcultarReportes()
        {
            gbReporteMascota.Enabled = false;
            gbReporteMascota.Visible = false;
            gbTematica.Enabled = false;
            gbTematica.Visible = false;
            gbIntervalofecha.Enabled = false;
            gbIntervalofecha.Visible = false;
            gbtipohabitacion.Enabled = false;
            gbtipohabitacion.Visible = false;
            gbClientesMascota.Enabled = false;
            gbClientesMascota.Visible = false;
            gbFechaFacturacion.Enabled = false;
            gbFechaFacturacion.Visible = false;
            gbReportesFinancieros.Enabled = false;
            gbReportesFinancieros.Visible = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbtiporeporte.SelectedItem != null) 
            {
                if (cmbtiporeporte.SelectedItem.ToString() == "Mascota")
                {
                    OcultarReportes();
                    gbReporteMascota.Enabled = true;
                    gbReporteMascota.Visible = true;

                    if (txtTipoMascota.Text != "")
                    {
                        dgvReportes.AutoGenerateColumns = true;
                        bindingSource.DataSource = gMascota.ConsultarTipoMascota(txtTipoMascota.Text.Trim());
                        dgvReportes.DataSource = bindingSource;
                        if (dgvReportes.Rows.Count == 0)
                        {
                            MessageBox.Show("No hay datos");
                        }
                        lbltipomascota.Text = txtTipoMascota.Text.Trim();
                        lblcantidad.Text = gMascota.ConsultarTipoMascota(txtTipoMascota.Text.Trim()).Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Inserte tipo de mascota");
                    }
                }
                else if (cmbtiporeporte.SelectedItem.ToString() == "Servicio-tematica")
                {
                    OcultarReportes();
                    gbTematica.Enabled = true;
                    gbTematica.Visible = true;

                    if (txttipotematica.Text != "")
                    {
                        dgvReportes.AutoGenerateColumns = true;
                        bindingSource1.DataSource = gServicio.TipoTematica(txttipotematica.Text.Trim());
                        dgvReportes.DataSource = bindingSource1;
                        if (dgvReportes.Rows.Count == 0)
                        {
                            MessageBox.Show("No hay datos");
                        }
                        else
                        {
                            lblcantidadtematica.Text = gServicio.TipoTematica(txttipotematica.Text.Trim()).Rows.Count.ToString();
                            lbltipohabitacion.Text = txttipotematica.Text.Trim();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un tipo de temática");
                    }
                }
                else if (cmbtiporeporte.SelectedItem.ToString() == "Fechas-Ingreso")
                {
                    OcultarReportes();
                    gbIntervalofecha.Enabled = true;
                    gbIntervalofecha.Visible = true;

                    if(txtfecha1.Text!=""&&txtfecha2.Text!="")
                    {
                        dgvReportes.AutoGenerateColumns = true;
                        bindingSource2.DataSource = gServicio.IntervaloFecha(Convert.ToDateTime(txtfecha1.Text.Trim()), Convert.ToDateTime(txtfecha2.Text.Trim()));
                        dgvReportes.DataSource = bindingSource2;
                        if (dgvReportes.Rows.Count == 0)
                        {
                            MessageBox.Show("No hay datos");
                        }
                        else
                        {
                            lblPersonasReportadas.Text = gServicio.IntervaloFecha(Convert.ToDateTime(txtfecha1.Text.Trim()), Convert.ToDateTime(txtfecha2.Text.Trim())).Rows.Count.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡Ingrese intervalo de fechas!");
                    }
                }
                else if (cmbtiporeporte.SelectedItem.ToString() == "Servicio-tipo-habitacion")
                {
                    OcultarReportes();
                    gbtipohabitacion.Enabled = true;
                    gbtipohabitacion.Visible = true;

                    if (cmbTipoHabitacion.SelectedIndex != -1)
                    {
                        dgvReportes.AutoGenerateColumns = true;
                        bindingSource2.DataSource = gServicio.tipoHabitacion(cmbTipoHabitacion.SelectedItem.ToString());
                        dgvReportes.DataSource = bindingSource2;
                        if (dgvReportes.Rows.Count == 0)
                        {
                            MessageBox.Show("No hay datos");
                        }
                        else
                        {
                            lblcantidadtipohabitacion.Text = gServicio.tipoHabitacion(cmbTipoHabitacion.SelectedItem.ToString()).Rows.Count.ToString();
                            lbltipo.Text = cmbTipoHabitacion.SelectedItem.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un tipo de habitación");
                    }
                }
                else if (cmbtiporeporte.SelectedItem.ToString() == "Clientes-Mascota")
                {
                    OcultarReportes();
                    gbClientesMascota.Enabled = true;
                    gbClientesMascota.Visible = true;

                    int clientConM = gMascota.ListarMascota().Count();
                    int clientSinM = gCliente.ListarCliente().Count() - gMascota.ListarMascota().Count();
                    lblClientSinM.Text = Convert.ToString(clientSinM);
                    lblClientConM.Text = Convert.ToString(clientConM);
                    dgvReportes.DataSource = gCliente.ListarCliente();
                }
                else if (cmbtiporeporte.SelectedItem.ToString() == "Fecha de facturacion")
                {
                    OcultarReportes();
                    gbFechaFacturacion.Enabled = true;
                    gbFechaFacturacion.Visible = true;

                    if (txtMesFin.Text != "" && txtMesInicio.Text != "")
                    {
                        dgvReportes.DataSource = gServicio.Buscar_Servicios_en_Rango_Mes(DateTime.Parse(txtMesInicio.Text), DateTime.Parse(txtMesFin.Text));
                        if (dgvReportes.Rows.Count == 0)
                        {
                            MessageBox.Show("No hay datos");

                        }
                        else
                        {
                            lblCantFacturacion.Text = gServicio.Buscar_Servicios_en_Rango_Mes(DateTime.Parse(txtMesInicio.Text), DateTime.Parse(txtMesFin.Text)).Rows.Count.ToString();
                        }
                    }
                    else
                        MessageBox.Show("¡Rellene las fechas!");
                }
                else if (cmbtiporeporte.SelectedItem.ToString() == "E.E.F.F.")
                {
                    OcultarReportes();
                    gbReportesFinancieros.Enabled = true;
                    gbReportesFinancieros.Visible = true;

                    if (cmbEEFF.SelectedItem != null)
                    {
                        if (txtFecha1EEFF.Text != "" && txtFecha2EEFF.Text != "")
                        {
                            DateTime fecha1 = Convert.ToDateTime(txtFecha1EEFF.Text);
                            DateTime fecha2 = Convert.ToDateTime(txtFecha2EEFF.Text);
                            if (cmbEEFF.SelectedItem.ToString() == "E.F.E.")
                            {
                                dgvReportes.DataSource = nEFE.MostrarxFechaEFE(fecha1, fecha2);
                            }
                            else if (cmbEEFF.SelectedItem.ToString() == "E.R.")
                            {
                                dgvReportes.DataSource = nER.MostrarxFechaER(fecha1, fecha2);
                            }
                            else if (cmbEEFF.SelectedItem.ToString() == "E.S.F.")
                            {
                                dgvReportes.DataSource = nESF.MostrarxFechaESF(fecha1, fecha2);
                            }
                            cmbEEFF.SelectedIndex = -1;
                            txtFecha1EEFF.Clear();
                            txtFecha2EEFF.Clear();
                        }
                        else
                        {
                            MessageBox.Show("¡Digite las fechas!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡Seleccione un reporte!");
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Seleccione una opción!");
            }
            

        }

        private void cmbtiporeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtiporeporte.SelectedItem.ToString() == "Mascota")
            {
                OcultarReportes();
                gbReporteMascota.Enabled = true;
                gbReporteMascota.Visible = true;
                dgvReportes.DataSource = "";
            }
            else if (cmbtiporeporte.SelectedItem.ToString() == "Servicio-tematica")
            {
                OcultarReportes();
                gbTematica.Enabled = true;
                gbTematica.Visible = true;
                dgvReportes.DataSource = "";
            }
            else if (cmbtiporeporte.SelectedItem.ToString() == "Fechas-Ingreso")
            {
                OcultarReportes();
                gbIntervalofecha.Enabled = true;
                gbIntervalofecha.Visible = true;
                dgvReportes.DataSource = "";
            }
            else if (cmbtiporeporte.SelectedItem.ToString() == "Servicio-tipo-habitacion")
            {
                OcultarReportes();
                gbtipohabitacion.Enabled = true;
                gbtipohabitacion.Visible = true;
                dgvReportes.DataSource = "";
            }
            else if (cmbtiporeporte.SelectedItem.ToString() == "Clientes-Mascota")
            {
                OcultarReportes();
                gbClientesMascota.Enabled = true;
                gbClientesMascota.Visible = true;
                dgvReportes.DataSource = "";
            }
            else if (cmbtiporeporte.SelectedItem.ToString() == "Fecha de facturacion")
            {
                OcultarReportes();
                gbFechaFacturacion.Enabled = true;
                gbFechaFacturacion.Visible = true;
                dgvReportes.DataSource = "";
            }
            else if (cmbtiporeporte.SelectedItem.ToString() == "E.E.F.F.")
            {
                OcultarReportes();
                gbReportesFinancieros.Enabled = true;
                gbReportesFinancieros.Visible = true;
                dgvReportes.DataSource = "";
            }
        }

        private void txtUtiOperativaER_TextChanged(object sender, EventArgs e)
        {
            if (txtUtiBrutaER.Text != "" && txtOtrosGaeInER.Text != "")
            {
                txtUtiOperativaER.Text = (Convert.ToInt32(txtUtiBrutaER.Text) - Convert.ToInt32(txtOtrosGaeInER.Text)).ToString();
            }
        }

        private void txtOtrosGaeInER_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtUtiBrutaER.Text != "" && txtOtrosGaeInER.Text != "")
            {

                  txtUtiOperativaER.Text = (Convert.ToDecimal(txtUtiBrutaER.Text) - Convert.ToDecimal(txtOtrosGaeInER.Text)).ToString();
  
            }
            if (txtUtiOperativaER.Text != "")
            {
                txtIRER.Text = (Convert.ToInt32(txtUtiOperativaER.Text) * 0.295).ToString();
            }
            if (txtIRER.Text != "")
            {
                txtUtiNetaER.Text = (Convert.ToDecimal(txtUtiOperativaER.Text) -Convert.ToDecimal(Math.Round(Convert.ToDouble(txtIRER.Text),MidpointRounding.AwayFromZero))).ToString();
            }
        }

        private void txtOtrosGaeInER_KeyPress(object sender, EventArgs e)
        {

        }

        private void txtCostoVentasER_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtCostoVentasER.Text!=""&&txtVentasER.Text!="")
            {
                txtUtiBrutaER.Text = (Convert.ToDecimal(txtVentasER.Text) - Convert.ToDecimal(txtCostoVentasER.Text)).ToString();
            }
        }

        private void txtActivoNoCorrienteESF_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtActivoCorrienteESF.Text!=""&&txtActivoNoCorrienteESF.Text!="")
            {
                txtTotalActivoESF.Text = (Convert.ToDecimal(txtActivoCorrienteESF.Text) + Convert.ToDecimal(txtActivoNoCorrienteESF.Text)).ToString();
            }

        }

        private void txtPasivoCorrienteESF_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPasivoNoCorrienteESF.Text != "" && txtPasivoCorrienteESF.Text != "" && txtPatrimonioESF.Text!="")
            {
                txtTotalPasyPatrESF.Text = (Convert.ToDecimal(txtPasivoCorrienteESF.Text) + Convert.ToDecimal(txtPasivoNoCorrienteESF.Text) + Convert.ToDecimal(txtPatrimonioESF.Text)).ToString();
            }
        }

        private void txtAOperacion_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtAInversion.Text != "" && txtAFinanciacion.Text != "" && txtAOperacion.Text !="")
            {
                txtEfectEquiv.Text = (Convert.ToDecimal(txtAFinanciacion.Text)- Convert.ToDecimal(txtAInversion.Text) + Convert.ToDecimal(txtAOperacion.Text)).ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvESF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cant = dgvESF.SelectedRows.Count;
            if (cant == 1) 
            {
                if(!dgvESF.SelectedRows[0].IsNewRow)
                {
                    txtActivoCorrienteESF.Text = dgvESF.SelectedRows[0].Cells[1].Value.ToString();
                    txtActivoNoCorrienteESF.Text = dgvESF.SelectedRows[0].Cells[2].Value.ToString();
                    txtTotalActivoESF.Text = dgvESF.SelectedRows[0].Cells[3].Value.ToString();
                    txtPasivoCorrienteESF.Text = dgvESF.SelectedRows[0].Cells[4].Value.ToString();
                    txtPasivoNoCorrienteESF.Text = dgvESF.SelectedRows[0].Cells[5].Value.ToString();
                    txtPatrimonioESF.Text = dgvESF.SelectedRows[0].Cells[6].Value.ToString();
                    txtTotalPasyPatrESF.Text = dgvESF.SelectedRows[0].Cells[7].Value.ToString();
                    txtFechaRegistroESF.Text = dgvESF.SelectedRows[0].Cells[8].Value.ToString();
                }
            }
        }

        private void dgvER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cant = dgvER.SelectedRows.Count;
            if (cant == 1)
            {
                if (!dgvER.SelectedRows[0].IsNewRow)
                {
                    txtFechaRegistroER.Text = dgvER.SelectedRows[0].Cells[1].Value.ToString();
                    txtVentasER.Text = dgvER.SelectedRows[0].Cells[2].Value.ToString();
                    txtCostoVentasER.Text = dgvER.SelectedRows[0].Cells[3].Value.ToString();
                    txtUtiBrutaER.Text = dgvER.SelectedRows[0].Cells[4].Value.ToString();
                    txtOtrosGaeInER.Text = dgvER.SelectedRows[0].Cells[5].Value.ToString();
                    txtUtiOperativaER.Text = dgvER.SelectedRows[0].Cells[6].Value.ToString();
                    txtIRER.Text = dgvER.SelectedRows[0].Cells[7].Value.ToString();
                    txtUtiNetaER.Text = dgvER.SelectedRows[0].Cells[8].Value.ToString();
                }
            }
        }

        private void dgvEFE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cant = dgvEFE.SelectedRows.Count;
            if (cant == 1)
            {
                if (!dgvEFE.SelectedRows[0].IsNewRow)
                {
                    txtFechaEFE.Text = dgvEFE.SelectedRows[0].Cells[1].Value.ToString();
                    txtAOperacion.Text = dgvEFE.SelectedRows[0].Cells[2].Value.ToString();
                    txtAFinanciacion.Text = dgvEFE.SelectedRows[0].Cells[3].Value.ToString();
                    txtAInversion.Text = dgvEFE.SelectedRows[0].Cells[4].Value.ToString();
                    txtEfectEquiv.Text = dgvEFE.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
        }
    }
}
