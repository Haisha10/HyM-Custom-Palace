using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nMascota
    {
        dMascota mascotadao;
        public nMascota()
        {
            mascotadao = new dMascota();
        }
        public int RegistrarMascota(string nombre, string tipo, int edad)
        {
            eMascota mascota = new eMascota()
            {
                Nombre = nombre,
                Tipo = tipo,
                Edad = edad
            };
            return mascotadao.Insertar(mascota);
        }
        public void ModificarMascota(int id, string nombre, string tipo, int edad)
        {
            eMascota mascota = new eMascota()
            {
                Id = id,
                Nombre = nombre,
                Tipo = tipo,
                Edad = edad
            };
            mascotadao.Modificar(mascota);
        }
        public void EliminarMascota(int id)
        {
            mascotadao.Eliminar(id);
        }
        public List<eMascota> ListarMascota()
        {
            return mascotadao.ListarTodo();
        }
    }
}
