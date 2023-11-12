using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
namespace CapaNegocio
{
    public class CnProductos
    {

        private cd_Producto objectoCD = new cd_Producto();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objectoCD.MostrarProducto();
            return tabla;

        }

        public void Insertarpro(int ProductoID, string NombreProducto, int ProveedorID)
        {
            objectoCD.Insertarpro(Convert.ToInt32(ProductoID), NombreProducto, Convert.ToInt32(ProveedorID));

        }

        public void EditarProduct(int ProductoID, string NombreProducto)
        {
            objectoCD.editarprod(Convert.ToInt32(ProductoID), NombreProducto);

        }

        public void EliminarProduct(string ProductoID)
        {
            objectoCD.EliminarProductoPorID(Convert.ToInt32(ProductoID));
        }

    }
}
