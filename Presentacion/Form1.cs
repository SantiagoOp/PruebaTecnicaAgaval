using CapaNegocio;
using System.Drawing;
namespace Presentacion
{
    public partial class Form1 : Form
    {
        CnClientes objectoCN = new CnClientes();
        private string Idcliente = null;
        private bool editar = false;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarclientes();
        }

        private void mostrarclientes()
        {
            CnClientes objecto = new CnClientes();
            dataGridView1.DataSource = objecto.MostrarProd();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtnombre.Text)) {
                        MessageBox.Show("Es requerido un nombre");
                        return;
                    }
                    if (string.IsNullOrEmpty(txtapellido.Text))
                    {
                        MessageBox.Show("Es requerido un Apellido");
                        return;
                    }
                    if (string.IsNullOrEmpty(txtcorreo.Text))
                    {
                        MessageBox.Show("Es requerido un Correo");
                        return;
                    }
                    if (string.IsNullOrEmpty(boxcategoria.Text))
                    {
                        MessageBox.Show("Es requerido una categoria");
                        return;
                    }
                    objectoCN.insertcliente(txtnombre.Text, txtapellido.Text, txtcorreo.Text, boxcategoria.Text);
                    MessageBox.Show("se inserto correctamente");
                    mostrarclientes();
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("ha ocurrido un error inesperado ");
                }
            }
            if (editar == true)
            {

                try
                {
                    if (string.IsNullOrEmpty(txtnombre.Text))
                    {
                        MessageBox.Show("Es requerido un nombre");
                        return;
                    }
                    if (string.IsNullOrEmpty(txtapellido.Text))
                    {
                        MessageBox.Show("Es requerido un Apellido");
                        return;
                    }
                    if (string.IsNullOrEmpty(txtcorreo.Text))
                    {
                        MessageBox.Show("Es requerido un Correo");
                        return;
                    }
                    if (string.IsNullOrEmpty(boxcategoria.Text))
                    {
                        MessageBox.Show("Es requerido una categoria");
                        return;
                    }
                    objectoCN.EditarCliente(txtnombre.Text, txtapellido.Text, txtcorreo.Text, boxcategoria.Text, Convert.ToInt32(Idcliente));
                    MessageBox.Show("se editado correctamente");
                    mostrarclientes();
                    Limpiar();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pueden editar los datos por: " + ex);
                }
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                txtnombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtapellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtcorreo.Text = dataGridView1.CurrentRow.Cells["Correo Electronico"].Value.ToString();
                boxcategoria.SelectedValue = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
                Idcliente = dataGridView1.CurrentRow.Cells["Cliente ID"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void Limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcorreo.Clear();
            boxcategoria.SelectedValue="";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Idcliente = dataGridView1.CurrentRow.Cells["Cliente ID"].Value.ToString();
                objectoCN.EliminarCliente(Idcliente);
                MessageBox.Show("eliminado correctamente");
                mostrarclientes();
            }
            else
                MessageBox.Show("seleccione una fila por favor");


        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Categoria"].Index)
            {
                string categoriaValue = e.Value?.ToString();

                if (categoriaValue != null)
                {
                    if (categoriaValue.Equals("Persona Jurídica", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.BackColor = Color.Green; // Set color for persona jurídica
                    }
                    else if (categoriaValue.Equals("Persona Natural", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.BackColor = Color.Yellow; // Set color for persona natural
                    }
                }
            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto ventana = new  producto();
            ventana.Show();

            this.Hide();
        }

        private void boxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}