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
    public class dCliente
    {
        Database db = new Database();
        public void Insertar(eCliente o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = "Insertar_Cliente";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", o.Nombre);
                cmd.Parameters.AddWithValue("@apellido", o.Apellido);
                cmd.Parameters.AddWithValue("@dni", o.Dni);
                cmd.Parameters.AddWithValue("@correo", o.Correo);
                cmd.Parameters.AddWithValue("@telefono", o.Telefono);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public void Modificar(eCliente o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = "Modificar_Cliente";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", o.Nombre);
                cmd.Parameters.AddWithValue("@apellido", o.Apellido);
                cmd.Parameters.AddWithValue("@dni", o.Dni);
                cmd.Parameters.AddWithValue("@correo", o.Correo);
                cmd.Parameters.AddWithValue("@telefono", o.Telefono);
                cmd.Parameters.AddWithValue("@id", o.Id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public void Eliminar(int id)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string delete = "Eliminar_Cliente";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public List<eCliente> ListarTodo()
        {
            try
            {
                List<eCliente> lsCliente = new List<eCliente>();
                eCliente cliente = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("Mostrar_Cliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cliente = new eCliente();
                    cliente.Id = (int)reader["id"];
                    cliente.Nombre = (string)reader["nombre"];
                    cliente.Apellido = (string)reader["apellido"];
                    cliente.Dni = (long)reader["dni"];
                    cliente.Correo = (string)reader["correo"];
                    cliente.Telefono = (long)reader["telefono"];
                    lsCliente.Add(cliente);
                }
                reader.Close();
                return lsCliente;
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
