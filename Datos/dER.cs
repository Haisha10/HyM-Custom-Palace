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
    public class dER
    {
        Database db = new Database();
        public void Insertar(eER o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = "Insertar_ER";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaRegistro", o.fechaRegistro);
                cmd.Parameters.AddWithValue("@ventasNetas", o.ventasNetas);
                cmd.Parameters.AddWithValue("@costoVentas", o.costoVentas);
                cmd.Parameters.AddWithValue("@utilidadBruta", o.utilidadBruta);
                cmd.Parameters.AddWithValue("@otrosGastosIngresos", o.otrosGastosIngresos);
                cmd.Parameters.AddWithValue("@utilidadOperativa", o.utilidadOperativa);
                cmd.Parameters.AddWithValue("@impuestoRenta", o.impuestoRenta);
                cmd.Parameters.AddWithValue("@utilidadNeta", o.utilidadNeta);
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
        public void Modificar(eER o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = "Modificar_ER";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", o.codigo);
                cmd.Parameters.AddWithValue("@fechaRegistro", o.fechaRegistro);
                cmd.Parameters.AddWithValue("@ventasNetas", o.ventasNetas);
                cmd.Parameters.AddWithValue("@costoVentas", o.costoVentas);
                cmd.Parameters.AddWithValue("@utilidadBruta", o.utilidadBruta);
                cmd.Parameters.AddWithValue("@otrosGastosIngresos", o.otrosGastosIngresos);
                cmd.Parameters.AddWithValue("@utilidadOperativa", o.utilidadOperativa);
                cmd.Parameters.AddWithValue("@impuestoRenta", o.impuestoRenta);
                cmd.Parameters.AddWithValue("@utilidadNeta", o.utilidadNeta);
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
                string delete = "Eliminar_ER";
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
                SqlCommand cmd = new SqlCommand("Mostrar_ER", con);
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

        public DataTable Mostrar_xFecha(DateTime fecha1, DateTime fecha2)
        {
            DataTable table = new DataTable();
            try
            {
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("MostrarxFechaER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha1", fecha1);
                cmd.Parameters.AddWithValue("@fecha2", fecha2);
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
