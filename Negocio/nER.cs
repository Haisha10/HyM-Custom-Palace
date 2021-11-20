using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Negocio
{
    public class nER
    {
        dER dER;

        public nER()
        {
            dER = new dER();
        }

        public void Insertar_ER(DateTime fechaRegistro, Decimal ventasNetas, Decimal costoVentas, Decimal utilidadBruta, Decimal otrosGastosIngresos, Decimal utilidadOperativa, Decimal impuestoRenta, Decimal utilidadNeta)
        {
            eER eER = new eER()
            {
                fechaRegistro = fechaRegistro,
                ventasNetas = ventasNetas,
                costoVentas = costoVentas,
                utilidadBruta = utilidadBruta,
                utilidadNeta = utilidadNeta,
                utilidadOperativa = utilidadOperativa,
                otrosGastosIngresos = otrosGastosIngresos,
                impuestoRenta = impuestoRenta
            };
            dER.Insertar(eER);
        }
        public void Modificar_ER(int codigo, DateTime fechaRegistro, Decimal ventasNetas, Decimal costoVentas, Decimal utilidadBruta, Decimal otrosGastosIngresos, Decimal utilidadOperativa, Decimal impuestoRenta, Decimal utilidadNeta)
        {
            eER eER = new eER()
            {
                codigo = codigo,
                fechaRegistro = fechaRegistro,
                ventasNetas = ventasNetas,
                costoVentas = costoVentas,
                utilidadBruta = utilidadBruta,
                utilidadNeta = utilidadNeta,
                utilidadOperativa = utilidadOperativa,
                otrosGastosIngresos = otrosGastosIngresos,
                impuestoRenta = impuestoRenta
            };
            dER.Modificar(eER);
        }
        public void Eliminar_ER(int codigo)
        {
            dER.Eliminar(codigo);
        }
        public DataTable Listar_ER()
        {
            return dER.ListarTodo();
        }

        public DataTable MostrarxFechaER(DateTime fecha1, DateTime fecha2)
        {
            return dER.Mostrar_xFecha(fecha1, fecha2);
        }
    }
}
