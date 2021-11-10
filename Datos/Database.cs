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
                string cadenadeconexion = @"Data Source=DESKTOP-VSJS462\SQLEXPRESS; Initial Catalog = dbHotel; Integrated Security = True";
                conn = new SqlConnection(cadenadeconexion);

                conn.Open();
                return conn;
            }
            catch (SqlException e)
            //hacemos entidades? como se llamaria eHotel no? creo q eCliente eMascota  uhmmm uno para cd uno , q dicen los demás? :V
            {
                return null;
            }
        }
        public void DesconectaDb()
        {
            conn.Close();
        }
    }
}