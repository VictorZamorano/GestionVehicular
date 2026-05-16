namespace GestionVehicular.Forms
{
    partial class FrmModificarContribuyente
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
            btnGuardarCambios = new Button();
            txtComuna = new TextBox();
            txtDireccion = new TextBox();
            txtNacionalidad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtRut = new TextBox();
            lblComuna = new Label();
            lblDireccion = new Label();
            lblNacionalidad = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblRut = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(358, 366);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(157, 32);
            btnGuardarCambios.TabIndex = 25;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // txtComuna
            // 
            txtComuna.Location = new Point(348, 307);
            txtComuna.Name = "txtComuna";
            txtComuna.Size = new Size(182, 27);
            txtComuna.TabIndex = 24;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(348, 271);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(182, 27);
            txtDireccion.TabIndex = 23;
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(348, 229);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(182, 27);
            txtNacionalidad.TabIndex = 22;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(348, 191);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(182, 27);
            txtApellido.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(348, 150);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 27);
            txtNombre.TabIndex = 20;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(348, 111);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(182, 27);
            txtRut.TabIndex = 19;
            // 
            // lblComuna
            // 
            lblComuna.AutoSize = true;
            lblComuna.Location = new Point(194, 310);
            lblComuna.Name = "lblComuna";
            lblComuna.Size = new Size(64, 20);
            lblComuna.TabIndex = 18;
            lblComuna.Text = "Comuna";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(194, 271);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 17;
            lblDireccion.Text = "Dirección";
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(194, 236);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(98, 20);
            lblNacionalidad.TabIndex = 16;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(194, 194);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(72, 20);
            lblApellido.TabIndex = 15;
            lblApellido.Text = "Apellidos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(194, 150);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 20);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombres";
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(194, 111);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(31, 20);
            lblRut.TabIndex = 13;
            lblRut.Text = "Rut";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(581, 108);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 30);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmModificarContribuyente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 509);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(txtComuna);
            Controls.Add(txtDireccion);
            Controls.Add(txtNacionalidad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtRut);
            Controls.Add(lblComuna);
            Controls.Add(lblDireccion);
            Controls.Add(lblNacionalidad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblRut);
            Name = "FrmModificarContribuyente";
            Text = "FrmModificarContribuyente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarCambios;
        private TextBox txtComuna;
        private TextBox txtDireccion;
        private TextBox txtNacionalidad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtRut;
        private Label lblComuna;
        private Label lblDireccion;
        private Label lblNacionalidad;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblRut;
        private Button btnBuscar;
    }
}