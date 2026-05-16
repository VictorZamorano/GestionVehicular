namespace GestionVehicular.Forms
{
    partial class FrmConsultarContribuyente
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
            btnBuscar = new Button();
            txtDireccion = new TextBox();
            txtNacionalidad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtRut = new TextBox();
            lblDireccion = new Label();
            lblNacionalidad = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblRut = new Label();
            lblComuna = new Label();
            txtComuna = new TextBox();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(491, 100);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(301, 238);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(184, 23);
            txtDireccion.TabIndex = 20;
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(301, 208);
            txtNacionalidad.Margin = new Padding(3, 2, 3, 2);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.ReadOnly = true;
            txtNacionalidad.Size = new Size(184, 23);
            txtNacionalidad.TabIndex = 19;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(301, 171);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(184, 23);
            txtApellido.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(301, 137);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(184, 23);
            txtNombre.TabIndex = 17;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(301, 100);
            txtRut.Margin = new Padding(3, 2, 3, 2);
            txtRut.Name = "txtRut";
            txtRut.PlaceholderText = "11.222.333-K";
            txtRut.Size = new Size(184, 23);
            txtRut.TabIndex = 16;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(235, 241);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 15;
            lblDireccion.Text = "Dirección:";
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(215, 211);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(80, 15);
            lblNacionalidad.TabIndex = 14;
            lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(241, 174);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 13;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(241, 140);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre:";
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(139, 103);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(156, 15);
            lblRut.TabIndex = 11;
            lblRut.Text = "Ingresar RUT Contribuyente:";
            // 
            // lblComuna
            // 
            lblComuna.AutoSize = true;
            lblComuna.Location = new Point(235, 276);
            lblComuna.Name = "lblComuna";
            lblComuna.Size = new Size(56, 15);
            lblComuna.TabIndex = 22;
            lblComuna.Text = "Comuna:";
            // 
            // txtComuna
            // 
            txtComuna.Location = new Point(301, 273);
            txtComuna.Margin = new Padding(3, 2, 3, 2);
            txtComuna.Name = "txtComuna";
            txtComuna.ReadOnly = true;
            txtComuna.Size = new Size(184, 23);
            txtComuna.TabIndex = 23;
            // 
            // FrmConsultarContribuyente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtComuna);
            Controls.Add(lblComuna);
            Controls.Add(btnBuscar);
            Controls.Add(txtDireccion);
            Controls.Add(txtNacionalidad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtRut);
            Controls.Add(lblDireccion);
            Controls.Add(lblNacionalidad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblRut);
            Name = "FrmConsultarContribuyente";
            Text = "FrmConsultarContribuyente1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtDireccion;
        private TextBox txtNacionalidad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtRut;
        private Label lblDireccion;
        private Label lblNacionalidad;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblRut;
        private Label lblComuna;
        private TextBox txtComuna;
    }
}