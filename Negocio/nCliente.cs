using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;
using Datos;

namespace Negocio
{
    public class nCliente
    {
        dCliente clientedao;
        public nCliente()
        {
            clientedao = new dCliente();
        }
        public void RegistrarCliente(string nombre, string apellido, long dni, string correo, long telefono)
        {
            eCliente cliente = new eCliente()
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                Correo = correo,
                Telefono = telefono
            };
            clientedao.Insertar(cliente);
        }
        public void ModificarCliente(int id, string nombre, string apellido, long dni, string correo, long telefono)
        {
            eCliente cliente = new eCliente()
            {
                Id = id,
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                Correo = correo,
                Telefono = telefono
            };
            clientedao.Modificar(cliente);
        }
        public void EliminarCliente(int id)
        {
            clientedao.Eliminar(id);
        }
        public List<eCliente> ListarCliente()
        {
            return clientedao.ListarTodo();
        }
    }
}
