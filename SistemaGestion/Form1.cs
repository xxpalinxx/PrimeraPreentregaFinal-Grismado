using SistemaGestionBussiness;
using SistemaGestionEntities;
using SistemaGestionUI;

namespace SistemaGestion
{
    public partial class Form1 : Form
    {
        public int idProducto;
        public int idProductoVendido;
        public int idUsuario;
        public int idVenta;
        public string datosCargados;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProducto();
        }

        public void CargarProducto()
        {
            comboBox1.SelectedIndex = 0;
            idProducto = 0;
            List<Producto> producto = ProductoBussiness.GetProducto();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = producto;
            datosCargados = "Producto";
        }

        public void CargarProductoVendido()
        {
            comboBox1.SelectedIndex = 1;
            idProductoVendido = 0;
            List<ProductoVendido> productoVendido = ProductoVendidoBussiness.GetProductoVendido();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = productoVendido;
            datosCargados = "Producto Vendido";
        }

        public void CargarUsuario()
        {
            comboBox1.SelectedIndex = 2;
            idUsuario = 0;
            List<Usuario> usuario = UsuarioBussiness.GetUsuario();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = usuario;
            datosCargados = "Usuario";
        }

        public void CargarVenta()
        {
            comboBox1.SelectedIndex = 3;
            idVenta = 0;
            List<Venta> venta = VentaBussiness.GetVenta();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = venta;
            datosCargados = "Venta";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();
            switch (selectValue)
            {
                case "Producto":
                    Form2 form2 = new Form2();
                    form2.limpiar();
                    form2.Show();
                    Program.form1.Hide(); ;
                    break;
                case "Producto Vendido":
                    FormProductoVendido formProductoVendido = new FormProductoVendido();
                    formProductoVendido.limpiar();
                    formProductoVendido.Show();
                    Program.form1.Hide();
                    break;
                case "Usuario":
                    FormUsuario formUsuario = new FormUsuario();
                    formUsuario.limpiar();
                    formUsuario.Show();
                    Program.form1.Hide();
                    break;
                case "Venta":
                    FormVenta formVenta = new FormVenta();
                    formVenta.limpiar();
                    formVenta.Show();
                    Program.form1.Hide();
                    break;
                default:
                    MessageBox.Show("Opción no válida.");
                    break;
            }
            //Form2 form2 = new Form2();
            //form2.limpiar();
            //form2.Show();
            //Program.form1.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();
            switch (selectValue)
            {
                case "Producto":
                    if (e.RowIndex >= 0)
                    {
                        int filaSelecionada = (int)e.RowIndex;
                        idProducto = int.Parse(dataGridView1[0, filaSelecionada].Value.ToString());
                    }
                    Form2 form2 = new Form2();
                    Program.form1.Hide();
                    form2.Show();
                    break;
                case "Producto Vendido":
                    if (e.RowIndex >= 0)
                    {
                        int filaSelecionada = (int)e.RowIndex;
                        idProductoVendido = int.Parse(dataGridView1[0, filaSelecionada].Value.ToString());
                    }
                    FormProductoVendido formProductoVendido = new FormProductoVendido();
                    Program.form1.Hide();
                    formProductoVendido.Show();
                    break;
                case "Usuario":
                    if (e.RowIndex >= 0)
                    {
                        int filaSelecionada = (int)e.RowIndex;
                        idUsuario = int.Parse(dataGridView1[0, filaSelecionada].Value.ToString());
                    }
                    FormUsuario formUsuario = new FormUsuario();
                    Program.form1.Hide();
                    formUsuario.Show();
                    break;
                case "Venta":
                    if (e.RowIndex >= 0)
                    {
                        int filaSelecionada = (int)e.RowIndex;
                        idVenta = int.Parse(dataGridView1[0, filaSelecionada].Value.ToString());
                    }
                    FormVenta formVenta = new FormVenta();
                    Program.form1.Hide();
                    formVenta.Show();
                    break;
                default:
                    MessageBox.Show("Opción no válida.");
                    break;
            }
            //if (e.RowIndex >= 0)
            //{
            //    int filaSelecionada = (int)e.RowIndex;
            //    idProducto = int.Parse(dataGridView1[0, filaSelecionada].Value.ToString());
            //}
            //Form2 form2 = new Form2();
            //Program.form1.Hide();
            //form2.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.AutoGenerateColumns = true;
            string selectValue = comboBox1.SelectedItem.ToString();
            switch (selectValue)
            {
                case "Producto":
                    dataGridView1.DataSource = ProductoBussiness.GetProducto(); ;
                    break;
                case "Producto Vendido":
                    dataGridView1.DataSource = ProductoVendidoBussiness.GetProductoVendido(); ;
                    break;
                case "Usuario":
                    dataGridView1.DataSource = UsuarioBussiness.GetUsuario(); ;
                    break;
                case "Venta":
                    dataGridView1.DataSource = VentaBussiness.GetVenta(); ;
                    break;
                default:
                    MessageBox.Show("Opción no válida.");
                    break;
            }
            //dataGridView1.DataSource = ProductoBussiness.GetProducto();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();
            switch (selectValue)
            {
                case "Producto":
                    CargarProducto();
                    break;
                case "Producto Vendido":
                    CargarProductoVendido();
                    break;
                case "Usuario":
                    CargarUsuario();
                    break;
                case "Venta":
                    CargarVenta();
                    break;
                default:
                    MessageBox.Show("Opción no válida.");
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
