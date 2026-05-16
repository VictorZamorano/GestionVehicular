namespace GestionVehicular.Forms
{
    partial class FrmModificarVehiculo
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
            btnGuardarCambios = new Button();
            txtRutContribuyente = new TextBox();
            txtAnio = new TextBox();
            txtColor = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtPatente = new TextBox();
            lblRut = new Label();
            lblAño = new Label();
            lblColor = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            lblPatente = new Label();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(508, 101);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 27);
            btnBuscar.TabIndex = 40;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(317, 297);
            btnGuardarCambios.Margin = new Padding(3, 2, 3, 2);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(149, 27);
            btnGuardarCambios.TabIndex = 39;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // txtRutContribuyente
            // 
            txtRutContribuyente.Location = new Point(300, 261);
            txtRutContribuyente.Margin = new Padding(3, 2, 3, 2);
            txtRutContribuyente.Name = "txtRutContribuyente";
            txtRutContribuyente.Size = new Size(181, 23);
            txtRutContribuyente.TabIndex = 38;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(300, 229);
            txtAnio.Margin = new Padding(3, 2, 3, 2);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(181, 23);
            txtAnio.TabIndex = 37;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(300, 199);
            txtColor.Margin = new Padding(3, 2, 3, 2);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(181, 23);
            txtColor.TabIndex = 36;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(300, 169);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(181, 23);
            txtModelo.TabIndex = 35;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(300, 136);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(181, 23);
            txtMarca.TabIndex = 34;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(300, 105);
            txtPatente.Margin = new Padding(3, 2, 3, 2);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(181, 23);
            txtPatente.TabIndex = 33;
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(121, 261);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(104, 15);
            lblRut.TabIndex = 32;
            lblRut.Text = "Rut Contribuyente";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(182, 229);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(29, 15);
            lblAño.TabIndex = 31;
            lblAño.Text = "Año";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(182, 201);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 30;
            lblColor.Text = "Color";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(182, 169);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 29;
            lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(182, 136);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 28;
            lblMarca.Text = "Marca";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(182, 107);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(47, 15);
            lblPatente.TabIndex = 27;
            lblPatente.Text = "Patente";
            // 
            // FrmModificarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(txtRutContribuyente);
            Controls.Add(txtAnio);
            Controls.Add(txtColor);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(txtPatente);
            Controls.Add(lblRut);
            Controls.Add(lblAño);
            Controls.Add(lblColor);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(lblPatente);
            Name = "FrmModificarVehiculo";
            Text = "FrmModificarVehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnGuardarCambios;
        private TextBox txtRutContribuyente;
        private TextBox txtAnio;
        private TextBox txtColor;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtPatente;
        private Label lblRut;
        private Label lblAño;
        private Label lblColor;
        private Label lblModelo;
        private Label lblMarca;
        private Label lblPatente;
    }
}