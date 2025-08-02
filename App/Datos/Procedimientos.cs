using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class Procedimientos
    {
        //creamos la instancia
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();
        //Creamos una tabla para almacenar nuestro datos

        public DataTable Mostrar()
        {
            cmd.Connection = conexion.Abrir();
            cmd.CommandText = "SP_MostrarEmpleados";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            conexion.Cerrar();

            return table;

        }

        //Creamos el proceso de Agregar
        public void Agregar(string Nombre, string Contraseña, string Cargo)
        {
            cmd.Connection = conexion.Abrir();
            cmd.CommandText = "SP_AgregarEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        //Creamos el proceso de Modificar

        public void Modificar(int Id, string Nombre, string Contraseña, string Cargo)
        {
            cmd.Connection = conexion.Abrir();
            cmd.CommandText = "SP_ModificarEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        //Creamos el proceso de Eliminar
        public void Eliminar(int Id)
        {
            cmd.Connection = conexion.Abrir();
            cmd.CommandText = "SP_EliminarEmpleados";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        //Creamos el proceso para validar el login
        public string ValidarLogin(string usuario, string contraseña)
        {
            string cargo = null;

            try
            {
                cmd.Connection = conexion.Abrir();
                cmd.CommandText = "SELECT Cargo FROM Empleados WHERE Nombre = @Usuario AND Contraseña = @Contraseña";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cargo = reader["Cargo"].ToString(); // si encuentra el usuario, devuelve el cargo
                }

                reader.Close();
                cmd.Parameters.Clear();
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
            }

            return cargo; // puede ser null si no encontró usuario
        }

    }
}
