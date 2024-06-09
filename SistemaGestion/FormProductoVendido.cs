using SistemaGestion;
using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class FormProductoVendido : Form
    {
        public FormProductoVendido()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtId.Text = "";
            txtStock.Text = "";
            txtIdProducto.Text = "";
            txtIdVenta.Text = "";
        }
        private void FormProductoVendido_Load(object sender, EventArgs e)
        {
            int idProductoVendido = Program.form1.idProductoVendido;
            if (idProductoVendido > 0)
            {
                //ProductoData productoData = new ProductoData();
                ProductoVendido txtProductoVendido = ProductoVendidoData.GetProductoVendidoByID(idProductoVendido);

                txtStock.Text = txtProductoVendido.Stock.ToString();
                txtIdProducto.Text = txtProductoVendido.IdProducto.ToString();
                txtIdVenta.Text = txtProductoVendido.IdVenta.ToString();
                txtId.Text = txtProductoVendido.Id.ToString();
            }
            else
            {
                txtStock.Text = "";
                txtIdProducto.Text = "";
                txtIdVenta.Text = "";
                txtId.Text = "";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.form1.idProducto = 0;
            this.Close();
            Program.form1.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            ProductoVendidoData.DeleteProductoVendido(int.Parse(Id));
            MessageBox.Show("Producto Vendido Borrado");
            limpiar();
            Program.form1.idProductoVendido = 0;
            this.Close();
            Program.form1.Refresh();
            Program.form1.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int stock = int.Parse(txtStock.Text);
            int idProducto = int.Parse(txtIdProducto.Text);
            int idVenta = int.Parse(txtIdVenta.Text);
            int idProductoVendido = Program.form1.idProductoVendido;
            ProductoVendido nuevoProductoVendido = new ProductoVendido(stock, idProducto, idVenta);

            if (idProductoVendido > 0)
            {
                ProductoVendidoData.UpdateProductoVendido(idProductoVendido, nuevoProductoVendido);
                MessageBox.Show("Producto Vendido Actualizado");
            }
            else
            {
                ProductoVendidoData.CreateProductoVendido(nuevoProductoVendido);
                MessageBox.Show("Producto Nuevo Creado");
            }
            limpiar();
            this.Close();
            Program.form1.idProductoVendido = 0;
            Program.form1.Show();
        }
    }
}
