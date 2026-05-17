namespace GestionVehicular.Forms
{
    partial class FrmModifContribuyente
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
            btnGuardar = new Button();
            btnBuscar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtRut = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNacionalidad = new TextBox();
            txtDireccion = new TextBox();
            txtComuna = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(328, 267);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 26);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(513, 84);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 91);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 15;
            label1.Text = "RUT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 120);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 16;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 149);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 17;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 178);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 18;
            label4.Text = "Nacionalidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 207);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 19;
            label5.Text = "Direccion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 236);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 20;
            label6.Text = "Comuna:";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(297, 83);
            txtRut.Name = "txtRut";
            txtRut.PlaceholderText = "11.222.333-4";
            txtRut.Size = new Size(210, 23);
            txtRut.TabIndex = 21;
            txtRut.TextChanged += txtRut_TextChanged;
            txtRut.Enter += txtRut_Enter;
            txtRut.KeyPress += txtRut_KeyPress;
            txtRut.Leave += txtRut_Leave;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(297, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 22;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(297, 141);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(210, 23);
            txtApellido.TabIndex = 23;
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(297, 170);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(210, 23);
            txtNacionalidad.TabIndex = 24;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(297, 199);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(210, 23);
            txtDireccion.TabIndex = 25;
            // 
            // txtComuna
            // 
            txtComuna.Location = new Point(297, 228);
            txtComuna.Name = "txtComuna";
            txtComuna.Size = new Size(210, 23);
            txtComuna.TabIndex = 26;
            // 
            // FrmModifContribuyente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtComuna);
            Controls.Add(txtDireccion);
            Controls.Add(txtNacionalidad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtRut);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Name = "FrmModifContribuyente";
            Text = "FrmModifContribuyente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnBuscar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtRut;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNacionalidad;
        private TextBox txtDireccion;
        private TextBox txtComuna;
    }
}