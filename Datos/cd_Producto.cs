using System;
using System.Data;
using System.Data.SqlClient;
using static Datos.Conexion;

namespace Datos
{
    public  class cd_Producto
    {
        private CD_Conexion Conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();



        public DataTable MostrarProducto()
        {

            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "MostrarProductosp";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;

        }


        public void Insertarpro(int ProductoID,string NombreProducto,int ProveedorID)
        {

            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "InsertarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ProductoID", ProductoID);
            comando.Parameters.AddWithValue("@NombreProducto", NombreProducto);
            comando.Parameters.AddWithValue("@ProveedorID", ProveedorID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void editarprod(int ProductoID, string NombreProducto)
        {

            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "EditarProductNombre";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ProductoID", ProductoID);
            comando.Parameters.AddWithValue("@NuevoNombreProducto", NombreProducto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EliminarProductoPorID(int ProductoID)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "EliminarProductoPorID";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ProductoID", ProductoID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

    }
}
