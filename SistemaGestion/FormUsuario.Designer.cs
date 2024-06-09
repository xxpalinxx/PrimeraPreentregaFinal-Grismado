namespace SistemaGestionUI
{
    partial class FormUsuario
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
            txtMail = new TextBox();
            txtContraseña = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            txtId = new TextBox();
            txtNombre = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
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
            label7.Location = new Point(64, 9);
            label7.Name = "label7";
            label7.Size = new Size(144, 40);
            label7.TabIndex = 21;
            label7.Text = "USUARIO";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(190, 214);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 19;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(190, 185);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 18;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(190, 156);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 17;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(190, 127);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Location = new Point(190, 69);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(190, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(11, 212);
            label6.Name = "label6";
            label6.Size = new Size(53, 30);
            label6.TabIndex = 13;
            label6.Text = "Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 182);
            label5.Name = "label5";
            label5.Size = new Size(121, 30);
            label5.TabIndex = 12;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 152);
            label4.Name = "label4";
            label4.Size = new Size(172, 30);
            label4.TabIndex = 11;
            label4.Text = "Nombre Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 122);
            label3.Name = "label3";
            label3.Size = new Size(92, 30);
            label3.TabIndex = 10;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 92);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 62);
            label1.Name = "label1";
            label1.Size = new Size(32, 30);
            label1.TabIndex = 8;
            label1.Text = "Id";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(53, 284);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(134, 284);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(215, 284);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 344);
            Controls.Add(label7);
            Controls.Add(txtMail);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtId);
            Controls.Add(txtNombre);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Name = "FormUsuario";
            Text = "FormUsuario";
            Load += FormUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtMail;
        private TextBox txtContraseña;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private TextBox txtId;
        private TextBox txtNombre;
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