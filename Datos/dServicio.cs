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
    public class dServicio
    {
        Database db = new Database();
        public string Insertar(eServicio o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = "Insertar_Servicio";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_habitacion", o.Numero_habitacion);
                cmd.Parameters.AddWithValue("@tipo_habitacion", o.Tipo_habitacion);
                cmd.Parameters.AddWithValue("@tematica", o.Tematica);
                cmd.Parameters.AddWithValue("@paquete", o.Paquete);
                cmd.Parameters.AddWithValue("@precio", o.Precio);
                cmd.Parameters.AddWithValue("@fecha_ingreso", o.Fecha_ingreso);
                cmd.Parameters.AddWithValue("@fecha_salida", o.Fecha_salida);
                cmd.Parameters.AddWithValue("@fecha_facturacion", o.Fecha_facturacion);
                cmd.Parameters.AddWithValue("@id_cliente", o.Id_cliente);
                cmd.Parameters.AddWithValue("@id_mascota", o.Id_mascota ?? Convert.DBNull);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return "Insertado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string Modificar(eServicio o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = "Modificar_Servicio";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_habitacion", o.Numero_habitacion);
                cmd.Parameters.AddWithValue("@tipo_habitacion", o.Tipo_habitacion);
                cmd.Parameters.AddWithValue("@tematica", o.Tematica);
                cmd.Parameters.AddWithValue("@paquete", o.Paquete);
                cmd.Parameters.AddWithValue("@precio", o.Precio);
                cmd.Parameters.AddWithValue("@fecha_ingreso", o.Fecha_ingreso);
                cmd.Parameters.AddWithValue("@fecha_salida", o.Fecha_salida);
                cmd.Parameters.AddWithValue("@fecha_facturacion", o.Fecha_facturacion);
                cmd.Parameters.AddWithValue("@id_cliente", o.Id_cliente);
                cmd.Parameters.AddWithValue("@id_mascota", o.Id_mascota);
                cmd.Parameters.AddWithValue("@id", o.Id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return "Modificado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string Eliminar(int id)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string delete = "Eliminar_Servicio";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return "Eliminado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public List<eServicio> ListarTodo()
        {
            try
            {
                List<eServicio> lsServicio = new List<eServicio>();
                eServicio servicio = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("Mostrar_Servicio", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    servicio = new eServicio();
                    servicio.Numero_habitacion = (int)reader["numero_habitacion"];
                    servicio.Tipo_habitacion = (string)reader["tipo_habitacion"];
                    servicio.Tematica = (string)reader["tematica"];
                    servicio.Paquete = (string)reader["paquete"];
                    servicio.Precio = (double)reader["precio"];
                    servicio.Fecha_ingreso = (DateTime)reader["fecha_ingreso"];
                    servicio.Fecha_salida = (DateTime)reader["fecha_salida"];
                    servicio.Fecha_facturacion = (DateTime)reader["fecha_facturacion"];
                    servicio.Id_cliente = (int)reader["id_cliente"];
                    servicio.Id_mascota = (int)reader["id_mascota"];
                    lsServicio.Add(servicio);
                }
                reader.Close();
                return lsServicio;
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
