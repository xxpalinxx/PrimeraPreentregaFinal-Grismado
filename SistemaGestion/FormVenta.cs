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
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtId.Text = "";
            txtComentario.Text = "";
            txtIdUsuario.Text = "";
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            int idVenta = Program.form1.idVenta;
            if (idVenta > 0)
            {
                //ProductoData productoData = new ProductoData();
                Venta txtVenta = VentaData.GetVentaByID(idVenta);

                txtComentario.Text = txtVenta.Comentarios;
                txtIdUsuario.Text = txtVenta.IdUsuario.ToString();
                txtId.Text = txtVenta.Id.ToString();
            }
            else
            {
                txtId.Text = "";
                txtComentario.Text = "";
                txtIdUsuario.Text = "";
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
            VentaData.DeleteVenta(int.Parse(Id));
            MessageBox.Show("Venta Borrado");
            limpiar();
            Program.form1.idVenta = 0;
            this.Close();
            Program.form1.Refresh();
            Program.form1.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string comentarios = txtComentario.Text;
            int idUsuario = int.Parse(txtIdUsuario.Text);
            int idVenta = Program.form1.idVenta;
            Venta nuevaVenta = new Venta(comentarios,idUsuario);

            if (idVenta > 0)
            {
                VentaData.UpdateVenta(idVenta, nuevaVenta);
                MessageBox.Show("Venta Actualizado");
            }
            else
            {
                VentaData.CreateVenta(nuevaVenta);
                MessageBox.Show("Venta Nueva Creado");
            }
            limpiar();
            this.Close();
            Program.form1.idVenta = 0;
            Program.form1.Show();
        }
    }
}
