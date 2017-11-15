using Consultas.ConsultaMedicaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas.Clases
{
    class Usuarios
    {


        private static UsuariosTableAdapter adaptador = new UsuariosTableAdapter();


        public static void InsertUsuario(string Usuario, string Clave, string Nombre, string Apellido, int ID_Perfil)
        {
            adaptador.InsertUsuario(Usuario, Clave, Nombre, Apellido, ID_Perfil);
        }

        public static void UpdateUsuario(string Usuario, string Clave, string Nombre, string Apellido, int ID_Perfil)
        {
            adaptador.UpdateUsuario(Usuario, Clave, Nombre, Apellido, ID_Perfil);
        }

        public static void DeleteUsuario(string Usuario)
        {
            adaptador.DeleteUsuario(Usuario);
        }


    }
}
