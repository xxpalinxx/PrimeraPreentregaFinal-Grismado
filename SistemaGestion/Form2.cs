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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtIdUsuario.Text = "";
            txtId.Text = "";
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.form1.idProducto = 0;
            this.Close();
            Program.form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int idProducto = Program.form1.idProducto;
            if (idProducto > 0)
            {
                //ProductoData productoData = new ProductoData();
                Producto txtProducto = ProductoData.GetProductByID(idProducto);

                txtDescripcion.Text = txtProducto.Descripciones;
                txtCosto.Text = txtProducto.Costo.ToString();
                txtPrecioVenta.Text = txtProducto.PrecioVenta.ToString();
                txtStock.Text = txtProducto.Stock.ToString();
                txtIdUsuario.Text = txtProducto.IdUsuario.ToString();
                txtId.Text = txtProducto.Id.ToString();
            }
            else
            {
                txtDescripcion.Text = "";
                txtCosto.Text = "";
                txtPrecioVenta.Text = "";
                txtStock.Text = "";
                txtIdUsuario.Text = "";
                txtId.Text = "";
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            ProductoData.DeleteProduct(int.Parse(Id));
            MessageBox.Show("Producto Borrado");
            limpiar();
            Program.form1.idProducto = 0;
            this.Close();
            Program.form1.Refresh();
            Program.form1.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            double costo = double.Parse(txtCosto.Text);
            double precioVenta = double.Parse(txtPrecioVenta.Text);
            int stock = int.Parse(txtStock.Text);
            int idUsuario = int.Parse(txtIdUsuario.Text);
            int idProducto = Program.form1.idProducto;
            Producto nuevoProducto = new Producto(descripcion,costo,precioVenta,stock,idUsuario);

            if (idProducto > 0)
            {
                ProductoData.UpdateProduct(idProducto, nuevoProducto);
                MessageBox.Show("Producto Actualizado");
            }
            else
            {
                ProductoData.CreateProduct(nuevoProducto);
                MessageBox.Show("Producto Nuevo Creado");
            }
            limpiar();
            this.Close();
            Program.form1.idProducto = 0;
            Program.form1.Show();
        }
    }
}
