using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class  dEFE
    {
        Database db = new Database();
        public void Insertar(eEFE o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = "Insertar_EFE";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaRegistro", o.fechaRegistro);
                cmd.Parameters.AddWithValue("@actividadOperacion", o.actividadOperacion);
                cmd.Parameters.AddWithValue("@actividadFinanciacion", o.actividadFinanciacion);
                cmd.Parameters.AddWithValue("@actividadInversion", o.actividadInversion);
                cmd.Parameters.AddWithValue("@efectivoEquivalente", o.efectivoEquivalente);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public void Modificar(eEFE o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = "Modificar_EFE";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", o.codigo);
                cmd.Parameters.AddWithValue("@fechaRegistro", o.fechaRegistro);
                cmd.Parameters.AddWithValue("@actividadOperacion", o.actividadOperacion);
                cmd.Parameters.AddWithValue("@actividadFinanciacion", o.actividadFinanciacion);
                cmd.Parameters.AddWithValue("@actividadInversion", o.actividadInversion);
                cmd.Parameters.AddWithValue("@efectivoEquivalente", o.efectivoEquivalente);
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
        public void Eliminar(int codigo)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string delete = "Eliminar_EFE";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", codigo);
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
        public DataTable ListarTodo()
        {
            DataTable table = new DataTable();
            try
            {
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("Mostrar_EFE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
            return table;
        }
    }
}
