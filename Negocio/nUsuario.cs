using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nUsuario
    {
        dUsuario usuariodao;
        public nUsuario()
        {
            usuariodao = new dUsuario();
        }
        public string RegistrarUsuario(string usuario, string contrasena, string estado, string nombre, string apellido, long dni, string correo, long telefono)
        {
            eUsuario cuenta = new eUsuario()
            {
                Usuario = usuario,
                Contrasena = contrasena,
                Estado = estado,
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                Correo = correo,
                Telefono = telefono
            };
            return usuariodao.Insertar(cuenta);
        }
        public string ModificarUsuario(int id, string usuario, string contrasena, string estado, string nombre, string apellido, long dni, string correo, long telefono)
        {
            eUsuario cuenta = new eUsuario()
            {
                Id = id,
                Usuario = usuario,
                Contrasena = contrasena,
                Estado = estado,
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                Correo = correo,
                Telefono = telefono
            };
            return usuariodao.Modificar(cuenta);
        }
        public string EliminarUsuario(int id)
        {
            return usuariodao.Eliminar(id);
        }
        public List<eUsuario> ListarUsuario()
        {
            return usuariodao.ListarTodo();
        }
        public eUsuario VerificarUsuario(string usuario, string contrasena)
        {
            return usuariodao.BuscarPorUsuarioContrasena(usuario, contrasena);
        }
        public string ReestablecerUsuario(string usuario, string contrasena, long dni, string correo, long telefono)
        {
            return usuariodao.ReestablecerContrasena(usuario, contrasena, dni, correo, telefono);
        }
    }
}
