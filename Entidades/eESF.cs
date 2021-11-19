using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eESF
    {
        public int codigo { get; set; }
        public DateTime fechaRegistro { get; set; }
        public Decimal activoCorriente { get; set; }
        public Decimal activoNoCorriente { get; set; }
        public Decimal totalActivo { get; set; }
        public Decimal pasivoCorriente { get; set; }
        public Decimal pasivoNoCorriente { get; set; }
        public Decimal patrimonio { get; set; } 
        public Decimal totalPasivoyPatrimonio { get; set; }
    }
}
