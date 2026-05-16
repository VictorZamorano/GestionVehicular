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
            btnGuardar = new Button();
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
            // btnGuardar
            // 
            btnGuardar.Location = new Point(358, 301);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 30);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtRutContribuyente
            // 
            txtRutContribuyente.Location = new Point(318, 254);
            txtRutContribuyente.Margin = new Padding(3, 2, 3, 2);
            txtRutContribuyente.Name = "txtRutContribuyente";
            txtRutContribuyente.Size = new Size(181, 23);
            txtRutContribuyente.TabIndex = 24;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(318, 221);
            txtAnio.Margin = new Padding(3, 2, 3, 2);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(181, 23);
            txtAnio.TabIndex = 23;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(318, 191);
            txtColor.Margin = new Padding(3, 2, 3, 2);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(181, 23);
            txtColor.TabIndex = 22;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(318, 161);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(181, 23);
            txtModelo.TabIndex = 21;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(318, 129);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(181, 23);
            txtMarca.TabIndex = 20;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(318, 98);
            txtPatente.Margin = new Padding(3, 2, 3, 2);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(181, 23);
            txtPatente.TabIndex = 19;
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(139, 254);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(104, 15);
            lblRut.TabIndex = 18;
            lblRut.Text = "Rut Contribuyente";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(200, 221);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(29, 15);
            lblAño.TabIndex = 17;
            lblAño.Text = "Año";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(200, 194);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 16;
            lblColor.Text = "Color";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(200, 161);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 15;
            lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(200, 129);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 14;
            lblMarca.Text = "Marca";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(200, 100);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(47, 15);
            lblPatente.TabIndex = 13;
            lblPatente.Text = "Patente";
            // 
            // FrmAgregarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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

        private Button btnGuardar;
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