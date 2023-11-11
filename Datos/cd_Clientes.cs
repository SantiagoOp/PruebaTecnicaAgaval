using System;
using System.Data;
using System.Data.SqlClient;
using static Datos.Conexion;

namespace Datos
{
    public class cd_Clientes
    {
        private CD_Conexion Conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();



        public DataTable Mostrar()
        {

            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "MostrarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string Nombre,string Apellido,string CorreoElectronico,string Categoria)
        {

            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "InsertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre",Nombre);
            comando.Parameters.AddWithValue("@Apellido",Apellido);
            comando.Parameters.AddWithValue("@CorreoElectronico",CorreoElectronico);
            comando.Parameters.AddWithValue("@Categoria",Categoria);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void editar(string Nombre, string Apellido, string CorreoElectronico, string Categoria,int ClienteID)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "editarcliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
            comando.Parameters.AddWithValue("@Categoria", Categoria);
            comando.Parameters.AddWithValue("@ClienteID", ClienteID);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Eliminar (int ClienteID)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "eliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ClienteID", @ClienteID);

            comando.ExecuteNonQuery ();

            comando.Parameters.Clear ();
        }

    }
}
