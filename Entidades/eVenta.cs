using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eVenta
    {
        public int Id_servicio { get; set; }
        public int Numero_habitacion_servicio { get; set; }
        public string Tipo_habitacion_servicio { get; set; }
        public string Tematica_servicio { get; set; }
        public string Paquete_servicio { get; set; }
        public double Precio_servicio { get; set; }
        public DateTime Fecha_ingreso_servicio { get; set; }
        public DateTime Fecha_salida_servicio { get; set; }
        public DateTime Fecha_facturacion_servicio { get; set; }
        public int Id_cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public string Apellido_cliente { get; set; }
        public long Dni_cliente { get; set; }
        public long Telefono_cliente { get; set; }
        public string Correo_cliente { get; set; }
        public int? Id_mascota { get; set; }
        public string Nombre_mascota { get; set; }
        public string Tipo_mascota { get; set; }
        public int? Edad_mascota { get; set; }
    }
}
