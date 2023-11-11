using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class conexion
    {
        private static string connectionString = "Data Source=DESKTOP-4H8HP3J/HP;Initial Catalog=PruebaAgaval;Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Conexión abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }

            return connection;
        }

        public static void CerrarConexion(SqlConnection connection)
        {
            try
            {
                connection.Close();
                Console.WriteLine("Conexión cerrada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}
