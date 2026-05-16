namespace GestionVehicular.Forms
{
    partial class FrmAgregarVehiculo
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
            lblPatente = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            lblColor = new Label();
            lblAño = new Label();
            lblRut = new Label();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtColor = new TextBox();
            txtAnio = new TextBox();
            txtRutContribuyente = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(213, 124);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(58, 20);
            lblPatente.TabIndex = 0;
            lblPatente.Text = "Patente";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(213, 163);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(213, 206);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(61, 20);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(213, 249);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(45, 20);
            lblColor.TabIndex = 3;
            lblColor.Text = "Color";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(213, 286);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(36, 20);
            lblAño.TabIndex = 4;
            lblAño.Text = "Año";
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(143, 329);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(128, 20);
            lblRut.TabIndex = 5;
            lblRut.Text = "Rut Contribuyente";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(348, 121);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(206, 27);
            txtPatente.TabIndex = 6;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(348, 163);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(206, 27);
            txtMarca.TabIndex = 7;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(348, 206);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(206, 27);
            txtModelo.TabIndex = 8;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(348, 246);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(206, 27);
            txtColor.TabIndex = 9;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(348, 286);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(206, 27);
            txtAnio.TabIndex = 10;
            // 
            // txtRutContribuyente
            // 
            txtRutContribuyente.Location = new Point(348, 329);
            txtRutContribuyente.Name = "txtRutContribuyente";
            txtRutContribuyente.Size = new Size(206, 27);
            txtRutContribuyente.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(393, 392);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 40);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmAgregarVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 531);
            Controls.Add(btnGuardar);
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
            Name = "FrmAgregarVehiculo";
            Text = "FrmAgregarVehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPatente;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblColor;
        private Label lblAño;
        private Label lblRut;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtColor;
        private TextBox txtAnio;
        private TextBox txtRutContribuyente;
        private Button btnGuardar;
    }
}