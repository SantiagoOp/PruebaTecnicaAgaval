using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    internal class Conexion
    {
        public class CD_Conexion
        {
            private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-4H8HP3J\\LOCAL;DataBase= PruebaAgaval;Integrated Security=true");

            public SqlConnection AbrirConexion()
            {
                if (Conexion.State == ConnectionState.Closed)
                    Conexion.Open();
                return Conexion;
            }

            public SqlConnection CerrarConexion()
            {
                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
                return Conexion;
            }
        }
    }
}