namespace SistemaGestionUI
{
    partial class FormVenta
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
            txtIdUsuario = new TextBox();
            txtId = new TextBox();
            txtComentario = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(96, 9);
            label7.Name = "label7";
            label7.Size = new Size(109, 40);
            label7.TabIndex = 21;
            label7.Text = "VENTA";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(186, 127);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Location = new Point(186, 69);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 15;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(186, 98);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(100, 23);
            txtComentario.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 122);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 10;
            label3.Text = "Id Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 92);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 9;
            label2.Text = "Comentario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 62);
            label1.Name = "label1";
            label1.Size = new Size(32, 30);
            label1.TabIndex = 8;
            label1.Text = "Id";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(49, 173);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(130, 173);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(211, 173);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 209);
            Controls.Add(label7);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtId);
            Controls.Add(txtComentario);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Name = "FormVenta";
            Text = "FormVenta";
            Load += FormVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtIdUsuario;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtCosto;
        private TextBox txtId;
        private TextBox txtComentario;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnVolver;
    }
}