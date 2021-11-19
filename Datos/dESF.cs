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
    public class dESF
    {
        Database db = new Database();
        public void Insertar(eESF o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = "Insertar_ESF";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaRegistro", o.fechaRegistro);
                cmd.Parameters.AddWithValue("@activoCorriente", o.activoCorriente);
                cmd.Parameters.AddWithValue("@activoNoCorriente", o.activoNoCorriente);
                cmd.Parameters.AddWithValue("@totalActivo", o.totalActivo);
                cmd.Parameters.AddWithValue("@pasivoCorriente", o.pasivoCorriente);
                cmd.Parameters.AddWithValue("@pasivoNoCorriente", o.pasivoNoCorriente);
                cmd.Parameters.AddWithValue("@patrimonio", o.patrimonio);
                cmd.Parameters.AddWithValue("@totalPasivoyPatrimonio", o.totalPasivoyPatrimonio);
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
        public void Modificar(eESF o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = "Modificar_ESF";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", o.codigo);
                cmd.Parameters.AddWithValue("@fechaRegistro", o.fechaRegistro);
                cmd.Parameters.AddWithValue("@activoCorriente", o.activoCorriente);
                cmd.Parameters.AddWithValue("@activoNoCorriente", o.activoNoCorriente);
                cmd.Parameters.AddWithValue("@totalActivo", o.totalActivo);
                cmd.Parameters.AddWithValue("@pasivoCorriente", o.pasivoCorriente);
                cmd.Parameters.AddWithValue("@pasivoNoCorriente", o.pasivoNoCorriente);
                cmd.Parameters.AddWithValue("@patrimonio", o.patrimonio);
                cmd.Parameters.AddWithValue("@totalPasivoyPatrimonio", o.totalPasivoyPatrimonio);
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
                string delete = "Eliminar_ESF";
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
                SqlCommand cmd = new SqlCommand("Mostrar_ESF", con);
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
