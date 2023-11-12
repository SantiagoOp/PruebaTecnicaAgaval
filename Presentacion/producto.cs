using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;



namespace Presentacion
{
    public partial class producto : Form
    {
        CnProductos objectoCN = new CnProductos();
        private string Idproducto = null;
        private bool editar = false;

        public producto()
        {
            InitializeComponent();
        }


        private void producto_Load_1(object sender, EventArgs e)
        {
            mostrarproducto();
        }


        private void mostrarproducto()
        {
            CnProductos objecto = new CnProductos();
            dataGridView1.DataSource = objecto.MostrarProd();
        }

        private void btnguardarpro_Click(object sender, EventArgs e)
        {
            if (editar == false)
              
                if (int.TryParse(txtproducto.Text, out int productoID) &&
                int.TryParse(textprovedor.Text, out int proveedorID))
            {
                
                objectoCN.Insertarpro(productoID, textnombrepro.Text, proveedorID);
                MessageBox.Show("Se insertó correctamente");
                mostrarproducto();
            }
            else
            {
                
                MessageBox.Show("El valor del producto o del proveedor no es un número entero válido");
            }
        if (editar == true)
            {
                // Intenta convertir el valor de txtproducto.Text a un entero
                if (int.TryParse(txtproducto.Text, out int productoID))
                {
                
                    objectoCN.EditarProduct(productoID, textnombrepro.Text);
                    MessageBox.Show("Se edito correctamente");
                    mostrarproducto();
                    editar = false;
                }
                else
                {
                    MessageBox.Show("El valor del producto o del proveedor no es un número entero válido");

                }
            }

        }       

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                textnombrepro.Text=dataGridView1.CurrentRow.Cells["Nombre Producto"].Value.ToString();
                textprovedor.Text = dataGridView1.CurrentRow.Cells["Proveedor ID"].Value.ToString();
                Idproducto = dataGridView1.CurrentRow.Cells["Producto ID"].Value.ToString();


            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Idproducto = dataGridView1.CurrentRow.Cells["Producto ID"].Value.ToString();
                objectoCN.EliminarProduct(Idproducto);
                MessageBox.Show("eliminado correctamente");
                mostrarproducto();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
