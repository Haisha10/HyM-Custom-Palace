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
    public class dUsuario
    {
        Database db = new Database();
        public string Insertar(eUsuario o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = "Insertar_Usuario";
                //INSERT INTO Usuario(usuario, contrasena, estado, nombre, apellido, dni, correo, telefono) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", o.Usuario);
                cmd.Parameters.AddWithValue("@contrasena", o.Contrasena);
                cmd.Parameters.AddWithValue("@estado", o.Estado);
                cmd.Parameters.AddWithValue("@nombre", o.Nombre);
                cmd.Parameters.AddWithValue("@apellido", o.Apellido);
                cmd.Parameters.AddWithValue("@dni", o.Dni);
                cmd.Parameters.AddWithValue("@correo", o.Correo);
                cmd.Parameters.AddWithValue("@telefono", o.Telefono);
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
        public string Modificar(eUsuario o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = "Modificar_Usuario";
                //UPDATE Usuario SET usuario='{0}', contrasena='{1}', estado='{2}', nombre='{3}', apellido='{4}', dni='{5}', correo='{6}', telefono='{7}' where id={8}
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", o.Usuario);
                cmd.Parameters.AddWithValue("@contrasena", o.Contrasena);
                cmd.Parameters.AddWithValue("@estado", o.Estado);
                cmd.Parameters.AddWithValue("@nombre", o.Nombre);
                cmd.Parameters.AddWithValue("@apellido", o.Apellido);
                cmd.Parameters.AddWithValue("@dni", o.Dni);
                cmd.Parameters.AddWithValue("@correo", o.Correo);
                cmd.Parameters.AddWithValue("@telefono", o.Telefono);
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
                string delete = "Eliminar_Usuario";
                //DELETE from Usuario WHERE id={0}
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
        public List<eUsuario> ListarTodo()
        {
            try
            {
                List<eUsuario> lsUsuario = new List<eUsuario>();
                eUsuario usuario = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("Mostrar_Usuario", con);
                //SELECT * from Usuario
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usuario = new eUsuario();
                    usuario.Id = (int)reader["id"];
                    usuario.Usuario = (string)reader["usuario"];
                    usuario.Contrasena = (string)reader["contrasena"];
                    usuario.Estado = (string)reader["estado"];
                    usuario.Nombre = (string)reader["nombre"];
                    usuario.Apellido = (string)reader["apellido"];
                    usuario.Dni = (long)reader["dni"];
                    usuario.Correo = (string)reader["correo"];
                    usuario.Telefono = (long)reader["telefono"];
                    lsUsuario.Add(usuario);
                }
                reader.Close();
                return lsUsuario;
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
        public eUsuario BuscarPorUsuarioContrasena(string usuario, string contrasena)
        {
            try
            {
                eUsuario buscar = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("BuscarPorUsuarioContrasena_Usuario", con);
                //SELECT * from Usuario WHERE usuario like '{0}' and contrasena = '{1}' 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    buscar = new eUsuario();
                    buscar.Id = (int)reader["id"];
                    buscar.Usuario = (string)reader["usuario"];
                    buscar.Contrasena = (string)reader["contrasena"];
                    buscar.Estado = (string)reader["estado"];
                    buscar.Nombre = (string)reader["nombre"];
                    buscar.Apellido = (string)reader["apellido"];
                    buscar.Dni = (long)reader["dni"];
                    buscar.Correo = (string)reader["correo"];
                    buscar.Telefono = (long)reader["telefono"];
                }
                reader.Close();
                cmd.Parameters.Clear();
                return buscar;
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
        public string ReestablecerContrasena(string usuario, string contrasena, long dni, string correo, long telefono)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("ReestablecerContrasena_Usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                string resultado = cmd.ExecuteScalar().ToString();
                cmd.Parameters.Clear();
                return resultado;
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
    }
}
