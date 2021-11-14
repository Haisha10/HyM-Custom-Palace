using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class dVenta
    {
        Database db = new Database();
        public List<eVenta> ListarTodo()
        {
            try
            {
                List<eVenta> lsVenta = new List<eVenta>();
                eVenta venta = null;
                SqlConnection con = db.ConectaDb();
                //SELECT ... FROM Servicio INNER JOIN Cliente ON (Servicio.id_cliente = Cliente.id) LEFT JOIN Mascota ON (Servicio.id_mascota = Mascota.id)
                SqlCommand cmd = new SqlCommand("Mostrar_Venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    venta = new eVenta();
                    venta.Id_servicio = (int)reader["id_servicio"];
                    venta.Numero_habitacion_servicio = (int)reader["numero_habitacion_servicio"];
                    venta.Tipo_habitacion_servicio = (string)reader["tipo_habitacion_servicio"];
                    venta.Tematica_servicio = (string)reader["tematica_servicio"];
                    venta.Paquete_servicio = (string)reader["paquete_servicio"];
                    venta.Precio_servicio = (double)reader["precio_servicio"];
                    venta.Fecha_ingreso_servicio = (DateTime)reader["fecha_ingreso_servicio"];
                    venta.Fecha_salida_servicio = (DateTime)reader["fecha_salida_servicio"];
                    venta.Fecha_facturacion_servicio = (DateTime)reader["fecha_facturacion_servicio"];
                    venta.Id_cliente = (int)reader["id_cliente"];
                    venta.Nombre_cliente = (string)reader["nombre_cliente"];
                    venta.Apellido_cliente = (string)reader["apellido_cliente"];
                    venta.Dni_cliente = (long)reader["dni_cliente"];
                    venta.Telefono_cliente = (long)reader["telefono_cliente"];
                    venta.Correo_cliente = (string)reader["correo_cliente"];
                    if(reader["id_mascota"] != DBNull.Value)
                    {
                        venta.Id_mascota = (int)reader["id_mascota"];
                        venta.Nombre_mascota = (string)reader["nombre_mascota"];
                        venta.Tipo_mascota = (string)reader["tipo_mascota"];
                        venta.Edad_mascota = (int)reader["edad_mascota"];
                    }
                    else
                    {
                        venta.Id_mascota = null;
                        venta.Nombre_mascota = null;
                        venta.Tipo_mascota = null;
                        venta.Edad_mascota = null;
                    }
                    lsVenta.Add(venta);
                }
                reader.Close();
                return lsVenta;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}
