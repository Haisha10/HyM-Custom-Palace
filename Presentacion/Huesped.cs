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
        int idCliente;

        nMascota gMascota = new nMascota();
        int? idMascota;

        nServicio gServicio = new nServicio();
        int idServicio;

        nVenta gVenta = new nVenta();
        eVenta ventaseleccionado = null;

        string nombreRecepcionista;
        public Huesped(string nombre)
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\bck_huesped.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            tbxClienteDni.MaxLength = 8;
            tbxClienteTelefono.MaxLength = 9;
            gbMascota.Enabled = false;
            nombreRecepcionista = nombre;
            LimpiarControles(); ;
            MostrarVentas();
        }
        private void MostrarVentas()
        {
            dgVenta.DataSource = gVenta.MostrarVentas();
        }
        private void LimpiarControles()
        {
            tbxClienteNombre.Clear();
            tbxClienteApellido.Clear();
            tbxClienteDni.Clear();
            tbxClienteTelefono.Clear();
            tbxClienteCorreo.Clear();
            rbnClienteMascotaNo.Checked = true;
            tbxServicioNumero.Clear();
            rbnServicioTipoClasico.Checked = true;
            tbxServicioTematica.Clear();
            cbxServicioPaquete.SelectedIndex = -1;
            tbxServicioIngreso.Clear();
            tbxServicioSalida.Clear();
            btnHuespedModificar.Enabled = false;
            btnHuespedEliminar.Enabled = false;
            btnHuespedImprimir.Enabled = false;
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

            int precio = 0;
            if (rbnServicioTipoClasico.Checked)
            {
                precio += 150;
            }
            else
            {
                precio += 250;
            }
            if (cbxServicioPaquete.SelectedIndex == 0)
            {
                precio += 100;
            }
            else if (cbxServicioPaquete.SelectedIndex == 1)
            {
                precio += 150;
            }
            else
            {
                precio += 200;
            }
            lblServicioPrecio.Text = string.Format("{0:0.00}", precio);
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
                int id_servicio = gServicio.RegistrarServicio(Convert.ToInt32(tbxServicioNumero.Text.Trim()), tipo, tbxServicioTematica.Text.Trim(), cbxServicioPaquete.SelectedItem.ToString(), Convert.ToDouble(lblServicioPrecio.Text), DateTime.Parse(tbxServicioIngreso.Text.Trim()), DateTime.Parse(tbxServicioSalida.Text.Trim()), DateTime.Now, id_cliente, id_mascota);
                using (Facturacion frmFacturacion = new Facturacion(id_servicio, nombreRecepcionista, DateTime.Now, tbxClienteNombre.Text + " " + tbxClienteApellido.Text, Convert.ToInt64(tbxClienteDni.Text), cbxServicioPaquete.SelectedItem.ToString(), tipo, tbxServicioTematica.Text, DateTime.Parse(tbxServicioIngreso.Text.Trim()), DateTime.Parse(tbxServicioSalida.Text.Trim()), Convert.ToDouble(lblServicioPrecio.Text)))
                    frmFacturacion.ShowDialog();
                LimpiarControles();
                MostrarVentas();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
        }

        private void btnHuespedLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void cbxServicioPaquete_SelectedIndexChanged(object sender, EventArgs e)
        {
            int precio = 0;
            if (rbnServicioTipoClasico.Checked)
            {
                precio += 150;
            }
            else
            {
                precio += 250;
            }
            if(cbxServicioPaquete.SelectedIndex == 0)
            {
                precio += 100;
            }else if(cbxServicioPaquete.SelectedIndex == 1)
            {
                precio += 150;
            }
            else
            {
                precio += 200;
            }
            lblServicioPrecio.Text = string.Format("{0:0.00}", precio);
        }

        private void tbxServicioTematica_Leave(object sender, EventArgs e)
        {
            int precio = 0;
            if (rbnServicioTipoClasico.Checked)
            {
                precio += 150;
            }
            else
            {
                precio += 250;
            }
            if (cbxServicioPaquete.SelectedIndex == 0)
            {
                precio += 100;
            }
            else if (cbxServicioPaquete.SelectedIndex == 1)
            {
                precio += 150;
            }
            else
            {
                precio += 200;
            }
            lblServicioPrecio.Text = string.Format("{0:0.00}", precio);
        }

        private void dgVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                ventaseleccionado = dgVenta.CurrentRow.DataBoundItem as eVenta;
                if(ventaseleccionado != null)
                {
                    idCliente = ventaseleccionado.Id_cliente;
                    tbxClienteNombre.Text = ventaseleccionado.Nombre_cliente;
                    tbxClienteApellido.Text = ventaseleccionado.Apellido_cliente;
                    tbxClienteDni.Text = ventaseleccionado.Dni_cliente.ToString();
                    tbxClienteTelefono.Text = ventaseleccionado.Telefono_cliente.ToString();
                    tbxClienteCorreo.Text = ventaseleccionado.Correo_cliente;

                    idMascota = ventaseleccionado.Id_mascota;
                    if (idMascota != null)
                    {
                        rbnClienteMascotaSi.Checked = true;
                        tbxMascotaNombre.Text = ventaseleccionado.Nombre_mascota;
                        tbxMascotaTipo.Text = ventaseleccionado.Tipo_mascota;
                        tbxMascotaEdad.Text = ventaseleccionado.Edad_mascota.ToString();
                    }
                    else
                    {
                        rbnClienteMascotaNo.Checked = true;
                    }

                    idServicio = ventaseleccionado.Id_servicio;
                    tbxServicioNumero.Text = ventaseleccionado.Numero_habitacion_servicio.ToString();
                    if(ventaseleccionado.Tipo_habitacion_servicio == "Personalizado")
                    {
                        rbnServicioTipoPersonalizado.Checked = true;
                        tbxServicioTematica.Text = ventaseleccionado.Tematica_servicio;
                    }
                    else
                    {
                        rbnServicioTipoClasico.Checked = true;
                    }
                    cbxServicioPaquete.SelectedIndex = cbxServicioPaquete.Items.IndexOf(ventaseleccionado.Paquete_servicio);
                    lblServicioPrecio.Text = ventaseleccionado.Precio_servicio.ToString();
                    tbxServicioIngreso.Text = ventaseleccionado.Fecha_ingreso_servicio.ToString();
                    tbxServicioSalida.Text = ventaseleccionado.Fecha_salida_servicio.ToString();

                    btnHuespedModificar.Enabled = true;
                    btnHuespedEliminar.Enabled = true;
                    btnHuespedImprimir.Enabled = true;
                }
            }
        }

        private void btnHuespedImprimir_Click(object sender, EventArgs e)
        {
            using (Facturacion frmFacturacion = new Facturacion(ventaseleccionado.Id_servicio, 
                nombreRecepcionista,
                ventaseleccionado.Fecha_facturacion_servicio, 
                ventaseleccionado.Nombre_cliente + " " + ventaseleccionado.Apellido_cliente, 
                ventaseleccionado.Dni_cliente, 
                ventaseleccionado.Paquete_servicio, 
                ventaseleccionado.Tipo_habitacion_servicio, 
                ventaseleccionado.Tematica_servicio, 
                ventaseleccionado.Fecha_ingreso_servicio, 
                ventaseleccionado.Fecha_salida_servicio, 
                ventaseleccionado.Precio_servicio))
                frmFacturacion.ShowDialog();
        }

        private void btnHuespedCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuespedModificar_Click(object sender, EventArgs e)
        {
            string tipo;
            if (rbnServicioTipoClasico.Checked)
            {
                tipo = "Clasico";
            }
            else
            {
                tipo = "Personalizado";
            }
            idCliente = gCliente.RegistrarCliente(tbxClienteNombre.Text.Trim(), tbxClienteApellido.Text.Trim(), Convert.ToInt64(tbxClienteDni.Text.Trim()), tbxClienteCorreo.Text.Trim(), Convert.ToInt64(tbxClienteTelefono.Text.Trim()));
            if (gbMascota.Enabled)
            {
                idMascota = gMascota.RegistrarMascota(tbxMascotaNombre.Text.Trim(), tbxMascotaTipo.Text.Trim(), Convert.ToInt32(tbxMascotaEdad.Text.Trim()));
            }
            else
            {
                idMascota = null;
            }
            gServicio.ModificarServicio(idServicio, Convert.ToInt32(tbxServicioNumero.Text), tipo, tbxServicioTematica.Text, cbxServicioPaquete.SelectedItem.ToString(), Convert.ToDouble(lblServicioPrecio.Text), DateTime.Parse(tbxServicioIngreso.Text), DateTime.Parse(tbxServicioSalida.Text), DateTime.Now, idCliente, idMascota);
            MostrarVentas();
            LimpiarControles();
        }

        private void btnHuespedEliminar_Click(object sender, EventArgs e)
        {
            gServicio.EliminarServicio(idServicio);
            MostrarVentas();
            LimpiarControles();
        }

        private void tbxClienteDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxClienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxMascotaEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxServicioNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
