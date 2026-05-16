namespace GestionVehicular.Forms
{
    partial class FrmConsultarVehiculo
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
            txtPatente = new TextBox();
            lblRut = new Label();
            lblAño = new Label();
            lblColor = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            lblPatente = new Label();
            txtRut = new TextBox();
            txtAnio = new TextBox();
            txtColor = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(499, 94);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 27);
            btnBuscar.TabIndex = 54;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(309, 94);
            txtPatente.Margin = new Padding(3, 2, 3, 2);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(184, 23);
            txtPatente.TabIndex = 47;
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(196, 261);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(107, 15);
            lblRut.TabIndex = 46;
            lblRut.Text = "Rut Contribuyente:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(271, 226);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(32, 15);
            lblAño.TabIndex = 45;
            lblAño.Text = "Año:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(264, 199);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(39, 15);
            lblColor.TabIndex = 44;
            lblColor.Text = "Color:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(252, 167);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 43;
            lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(260, 133);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 42;
            lblMarca.Text = "Marca:";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(253, 103);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(50, 15);
            lblPatente.TabIndex = 41;
            lblPatente.Text = "Patente:";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(309, 258);
            txtRut.Margin = new Padding(3, 2, 3, 2);
            txtRut.Name = "txtRut";
            txtRut.ReadOnly = true;
            txtRut.Size = new Size(184, 23);
            txtRut.TabIndex = 64;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(309, 226);
            txtAnio.Margin = new Padding(3, 2, 3, 2);
            txtAnio.Name = "txtAnio";
            txtAnio.ReadOnly = true;
            txtAnio.Size = new Size(184, 23);
            txtAnio.TabIndex = 63;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(309, 196);
            txtColor.Margin = new Padding(3, 2, 3, 2);
            txtColor.Name = "txtColor";
            txtColor.ReadOnly = true;
            txtColor.Size = new Size(184, 23);
            txtColor.TabIndex = 62;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(309, 159);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.ReadOnly = true;
            txtModelo.Size = new Size(184, 23);
            txtModelo.TabIndex = 61;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(309, 125);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.ReadOnly = true;
            txtMarca.Size = new Size(184, 23);
            txtMarca.TabIndex = 60;
            // 
            // FrmConsultarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRut);
            Controls.Add(txtAnio);
            Controls.Add(txtColor);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(btnBuscar);
            Controls.Add(txtPatente);
            Controls.Add(lblRut);
            Controls.Add(lblAño);
            Controls.Add(lblColor);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(lblPatente);
            Name = "FrmConsultarVehiculo";
            Text = "FrmConsultarVehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtPatente;
        private Label lblRut;
        private Label lblAño;
        private Label lblColor;
        private Label lblModelo;
        private Label lblMarca;
        private Label lblPatente;
        private TextBox txtRut;
        private TextBox txtAnio;
        private TextBox txtColor;
        private TextBox txtModelo;
        private TextBox txtMarca;
    }
}