using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
    public class nVenta
    {
        dVenta ventadao = new dVenta();
        public List<eVenta> MostrarVentas()
        {
            return ventadao.ListarTodo();
        }
    }
}
