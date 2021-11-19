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
    public class nESF
    {
        dESF dESF;

        public nESF()
        {
            dESF = new dESF();
        }

        public void Insertar_ESF(DateTime fechaRegistro, Decimal activoCorriente, Decimal activoNoCorriente, Decimal totalActivo, Decimal pasivoCorriente, Decimal pasivoNoCorriente, Decimal patrimonio, Decimal totalPasivoyPatrimonio)
        {
            eESF eESF = new eESF()
            {
                fechaRegistro = fechaRegistro,
                activoCorriente = activoCorriente,
                activoNoCorriente = activoNoCorriente,
                totalActivo=activoNoCorriente,
                pasivoCorriente = pasivoCorriente,
                pasivoNoCorriente = pasivoNoCorriente,
                patrimonio = patrimonio,
                totalPasivoyPatrimonio = patrimonio,
            };
            dESF.Insertar(eESF);
        }
        public void Modificar_ESF(int codigo, DateTime fechaRegistro, Decimal activoCorriente, Decimal activoNoCorriente, Decimal totalActivo, Decimal pasivoCorriente, Decimal pasivoNoCorriente, Decimal patrimonio, Decimal totalPasivoyPatrimonio)
        {
            eESF eESF = new eESF()
            {
                codigo = codigo,
                fechaRegistro = fechaRegistro,
                activoCorriente = activoCorriente,
                activoNoCorriente = activoNoCorriente,
                totalActivo = activoNoCorriente,
                pasivoCorriente = pasivoCorriente,
                pasivoNoCorriente = pasivoNoCorriente,
                patrimonio = patrimonio,
                totalPasivoyPatrimonio = patrimonio,
            };
            dESF.Modificar(eESF);
        }
        public void Eliminar_ESF(int codigo)
        {
            dESF.Eliminar(codigo);
        }
        public DataTable Listar_ESF()
        {
            return dESF.ListarTodo();
        }
    }
}
