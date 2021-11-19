using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eER
    {
        public int codigo { get; set; }
        public DateTime fechaRegistro { get; set; }
        public Decimal ventasNetas { get; set; }
        public Decimal costoVentas { get; set; }
        public Decimal utilidadBruta { get; set; }
        public Decimal otrosGastosIngresos { get; set; }
        public Decimal utilidadOperativa { get; set; }
        public Decimal impuestoRenta { get; set; }
        public Decimal utilidadNeta { get; set; }

    }
}
