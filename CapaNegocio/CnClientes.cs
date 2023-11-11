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
    public class CnClientes
    {
        private cd_Clientes objectoCD = new cd_Clientes();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objectoCD.Mostrar();
            return tabla;

        }
        public void insertcliente(string Nombre, string Apellido, string CorreoElectronico, string Categoria)
        {
            objectoCD.Insertar(Nombre, Apellido, CorreoElectronico, Categoria); 

        }
        public void EditarCliente(string Nombre, string Apellido, string CorreoElectronico, string Categoria,int ClienteID) {
            objectoCD.editar(Nombre,Apellido,CorreoElectronico,Categoria,Convert.ToInt32(ClienteID));
        }

        public  void EliminarCliente(string ClienteID)
        {
            objectoCD.Eliminar(Convert.ToInt32(ClienteID));
        }

    }


}

   
