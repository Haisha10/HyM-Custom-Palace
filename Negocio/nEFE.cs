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
    public class nEFE
    {
        dEFE dEFE;

        public nEFE()
        {
            dEFE = new dEFE();
        }

        public void Insertar_EFE(DateTime fechaRegistro, Decimal actividadOperacion, Decimal actividadFinanciacion, Decimal actividadInversion, Decimal efectivoEquivalente)
        {
            eEFE eEFE = new eEFE()
            {
                fechaRegistro = fechaRegistro,
                actividadFinanciacion = actividadFinanciacion,
                actividadInversion = actividadInversion,
                actividadOperacion = actividadOperacion,
                efectivoEquivalente = efectivoEquivalente,
            };
            dEFE.Insertar(eEFE);
        }
        public void Modificar_EFE(int codigo,DateTime fechaRegistro, Decimal actividadOperacion, Decimal actividadFinanciacion, Decimal actividadInversion, Decimal efectivoEquivalente)
        {
            eEFE eEFE = new eEFE()
            {
                codigo = codigo,
                fechaRegistro = fechaRegistro,
                actividadFinanciacion = actividadFinanciacion,
                actividadInversion = actividadInversion,
                actividadOperacion = actividadOperacion,
                efectivoEquivalente = efectivoEquivalente,
            };
            dEFE.Modificar(eEFE);
        }
        public void Eliminar_EFE(int codigo)
        {
            dEFE.Eliminar(codigo);
        }
        public DataTable Listar_EFE()
        {
            return dEFE.ListarTodo();
        }

        public DataTable MostrarxFechaEFE(DateTime fecha1, DateTime fecha2)
        {
            return dEFE.Mostrar_xFecha(fecha1, fecha2);
        }
    }
}
