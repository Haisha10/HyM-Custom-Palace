using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eServicio
    {
        public int Id { get; set; }
        public int Numero_habitacion { get; set; }
        public string Tipo_habitacion { get; set; }
        public string Tematica { get; set; }
        public string Paquete { get; set; }
        public double Precio { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_salida { get; set; }
        public DateTime Fecha_facturacion { get; set; }
        public int Id_cliente { get; set; }
        public int Id_mascota { get; set; }
    }
}
