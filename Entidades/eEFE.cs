using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eEFE
    {
        public int codigo { get; set; }
        public DateTime fechaRegistro { get; set; }
        public Decimal actividadOperacion { get; set; }
        public Decimal actividadFinanciacion { get; set; }
        public Decimal actividadInversion { get; set; }
        public Decimal efectivoEquivalente { get; set; }

    }
}
