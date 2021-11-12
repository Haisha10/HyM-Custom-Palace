using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class nServicio
    {
        dServicio serviciodao;
        public nServicio()
        {
            serviciodao = new dServicio();
        }
        public void RegistrarServicio(int numero_habitacion, string tipo_habitacion, string tematica, string paquete, double precio, DateTime fecha_ingreso, DateTime fecha_salida, DateTime fecha_facturacion, int id_cliente, int? id_mascota)
        {
            eServicio servicio = new eServicio()
            {
                Numero_habitacion = numero_habitacion,
                Tipo_habitacion = tipo_habitacion,
                Tematica = tematica,
                Paquete = paquete,
                Precio = precio,
                Fecha_ingreso = fecha_ingreso,
                Fecha_salida = fecha_salida,
                Fecha_facturacion = fecha_facturacion,
                Id_cliente = id_cliente,
                Id_mascota = id_mascota
            };
            serviciodao.Insertar(servicio);
        }
        public void ModificarServicio(int id, int numero_habitacion, string tipo_habitacion, string tematica, string paquete, double precio, DateTime fecha_ingreso, DateTime fecha_salida, DateTime fecha_facturacion, int id_cliente, int id_mascota)
        {
            eServicio servicio = new eServicio()
            {
                Id = id,
                Numero_habitacion = numero_habitacion,
                Tipo_habitacion = tipo_habitacion,
                Tematica = tematica,
                Paquete = paquete,
                Precio = precio,
                Fecha_ingreso = fecha_ingreso,
                Fecha_salida = fecha_salida,
                Fecha_facturacion = fecha_facturacion,
                Id_cliente = id_cliente,
                Id_mascota = id_mascota
            };
            serviciodao.Modificar(servicio);
        }
        public void EliminarServicio(int id)
        {
            serviciodao.Eliminar(id);
        }
        public List<eServicio> ListarServicio()
        {
            return serviciodao.ListarTodo();
        }
    }
}
