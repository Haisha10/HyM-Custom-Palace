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
    public partial class Facturacion : Form
    {
        public Facturacion(int serie, string nombreRecepcionista, DateTime fechaFacturacion, string nombreCliente, long dniCliente, string paquete, string tipo, string tematica, DateTime ingreso, DateTime salida, double precio)
        {
            InitializeComponent();
            lblNumeroBoleta.Text = string.Format("{0:00000}", serie);
            lblCajero.Text = nombreRecepcionista;
            lblHora.Text = fechaFacturacion.ToShortTimeString();
            lblFecha.Text = fechaFacturacion.ToShortDateString();
            lblCliente.Text = nombreCliente;
            lblDni.Text = dniCliente.ToString();
            lblPaquete.Text = paquete;
            lblTipo.Text = tipo;
            lblTematica.Text = tematica;
            lblInicio.Text = ingreso.ToShortDateString();
            lblFin.Text = salida.ToShortDateString();
            lblPrecio.Text = string.Format("{0:0.00}", precio);
            double subtotal = precio - precio * 0.18;
            lblSubPrecio.Text = string.Format("{0:0.00}", subtotal);
            lblOpPrecio.Text = string.Format("{0:0.00}", subtotal);
            double igv = precio * 0.18;
            lblIgvPrecio.Text = string.Format("{0:0.00}", igv);
            lblTotalPrecio.Text = string.Format("{0:0.00}", precio);
        }
    }
}
