using CapaNegocio;



namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CnClientes objectoCN = new CnClientes();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            mostrarclientes();
        }

        private void mostrarclientes()
        {
            dataGridView1.DataSource = objectoCN.MostrarProd();

        }

       
    }
}