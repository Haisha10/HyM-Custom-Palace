using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Database
    {
        private SqlConnection conn;

        public SqlConnection ConectaDb()
        {
            try
            {
                string cadenadeconexion = @"Server=DESKTOP-TJDFLGB; Initial Catalog=dbHotel; Integrated Security=True";
                conn = new SqlConnection(cadenadeconexion);

                conn.Open();
                return conn;
            }
            catch (SqlException e)
            {
                return conn;
            }
        }
        public void DesconectaDb()
        {
            conn.Close();
        }
    }
}