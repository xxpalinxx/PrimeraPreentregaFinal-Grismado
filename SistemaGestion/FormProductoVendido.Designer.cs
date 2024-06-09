namespace SistemaGestionUI
{
    partial class FormProductoVendido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label7 = new Label();
            txtIdProducto = new TextBox();
            txtId = new TextBox();
            txtStock = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            txtIdVenta = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(-2, 9);
            label7.Name = "label7";
            label7.Size = new Size(312, 40);
            label7.TabIndex = 32;
            label7.Text = "PRODUCTO VENDIDO";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(186, 127);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 30;
            // 
            // txtId
            // 
            txtId.Location = new Point(186, 69);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 29;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(186, 98);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 122);
            label3.Name = "label3";
            label3.Size = new Size(127, 30);
            label3.TabIndex = 27;
            label3.Text = "Id Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 92);
            label2.Name = "label2";
            label2.Size = new Size(65, 30);
            label2.TabIndex = 26;
            label2.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 62);
            label1.Name = "label1";
            label1.Size = new Size(32, 30);
            label1.TabIndex = 25;
            label1.Text = "Id";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(49, 202);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(130, 202);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(211, 202);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 22;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(186, 156);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(100, 23);
            txtIdVenta.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 156);
            label4.Name = "label4";
            label4.Size = new Size(92, 30);
            label4.TabIndex = 27;
            label4.Text = "Id Venta";
            // 
            // FormProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 237);
            Controls.Add(label7);
            Controls.Add(txtIdVenta);
            Controls.Add(txtIdProducto);
            Controls.Add(txtId);
            Controls.Add(txtStock);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Name = "FormProductoVendido";
            Text = "FormProductoVendido";
            Load += FormProductoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtIdProducto;
        private TextBox txtId;
        private TextBox txtStock;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnVolver;
        private TextBox txtIdVenta;
        private Label label4;
    }
}