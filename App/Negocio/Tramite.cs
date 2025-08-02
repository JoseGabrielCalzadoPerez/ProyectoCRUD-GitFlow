using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Tramite
    {
        //Creamos una instancia de la clase Procedimientos para asi
        //poder usar sus metodos
        private Procedimientos procedure = new Procedimientos();

        public DataTable mostrarPersonal()
        {
            DataTable table = new DataTable();
            table = procedure.Mostrar();//si no se crea con Procedimientos no se podra usar el metodo Mostrar
            return table;
        }

        //creamos los metodos de insertar, actualizar y eliminar
        public void AgregarData(string Nombre, string Contraseña, string Cargo)
        {
            procedure.Agregar(Nombre, Contraseña, Cargo);
        }

        public void ModificarData(int Id, string Nombre, string Contraseña, string Cargo)
        {
            procedure.Modificar(Id, Nombre, Contraseña, Cargo);
        }

        public void EliminarData(int Id)
        {
            procedure.Eliminar(Id);
        }
        public string ValidarCredenciales(string usuario, string contraseña)
        {
            return procedure.ValidarLogin(usuario, contraseña);
        }

    }
}
