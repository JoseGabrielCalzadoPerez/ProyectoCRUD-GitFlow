using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class Conexion
    {
        //creamos cadena de coneccion
        private SqlConnection conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BD_Register;Integrated Security=true");

        //Creamos dos metodos para cerrar y abrir


        public SqlConnection Abrir()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            return conexion;

        }

        public SqlConnection Cerrar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

            return conexion;

        }
    }
}
