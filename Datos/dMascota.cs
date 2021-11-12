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
    public class dMascota
    {
        Database db = new Database();
        public int Insertar(eMascota o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = "Insertar_Mascota";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", o.Nombre);
                cmd.Parameters.AddWithValue("@tipo", o.Tipo);
                cmd.Parameters.AddWithValue("@edad", o.Edad);
                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Parameters.Clear();
                return resultado;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public void Modificar(eMascota o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = "Modificar_Mascota";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", o.Nombre);
                cmd.Parameters.AddWithValue("@tipo", o.Tipo);
                cmd.Parameters.AddWithValue("@edad", o.Edad);
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
                string delete = "Eliminar_Mascota";
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
        public List<eMascota> ListarTodo()
        {
            try
            {
                List<eMascota> lsMascota = new List<eMascota>();
                eMascota mascota = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("Mostrar_Mascota", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    mascota = new eMascota();
                    mascota.Id = (int)reader["id"];
                    mascota.Nombre = (string)reader["nombre"];
                    mascota.Tipo = (string)reader["tipo"];
                    mascota.Edad = (int)reader["edad"];
                    lsMascota.Add(mascota);
                }
                reader.Close();
                return lsMascota;
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
