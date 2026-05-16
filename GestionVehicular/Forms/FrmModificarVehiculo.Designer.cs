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
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(338, 324);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(170, 36);
            btnGuardarCambios.TabIndex = 25;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // txtRutContribuyente
            // 
            txtRutContribuyente.Location = new Point(319, 276);
            txtRutContribuyente.Name = "txtRutContribuyente";
            txtRutContribuyente.Size = new Size(206, 27);
            txtRutContribuyente.TabIndex = 24;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(319, 233);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(206, 27);
            txtAnio.TabIndex = 23;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(319, 193);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(206, 27);
            txtColor.TabIndex = 22;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(319, 153);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(206, 27);
            txtModelo.TabIndex = 21;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(319, 110);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(206, 27);
            txtMarca.TabIndex = 20;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(319, 68);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(206, 27);
            txtPatente.TabIndex = 19;
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(114, 276);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(128, 20);
            lblRut.TabIndex = 18;
            lblRut.Text = "Rut Contribuyente";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(184, 233);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(36, 20);
            lblAño.TabIndex = 17;
            lblAño.Text = "Año";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(184, 196);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(45, 20);
            lblColor.TabIndex = 16;
            lblColor.Text = "Color";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(184, 153);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(61, 20);
            lblModelo.TabIndex = 15;
            lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(184, 110);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 14;
            lblMarca.Text = "Marca";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(184, 71);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(58, 20);
            lblPatente.TabIndex = 13;
            lblPatente.Text = "Patente";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(557, 63);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(137, 36);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmModificarVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
        private Button btnBuscar;
    }
}