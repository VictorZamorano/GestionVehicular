namespace GestionVehicular.Forms
{
    partial class FrmAgregarContribuyente
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
            lblRut = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblNacionalidad = new Label();
            lblDireccion = new Label();
            lblComuna = new Label();
            txtRut = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNacionalidad = new TextBox();
            txtDireccion = new TextBox();
            txtComuna = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(165, 99);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(31, 20);
            lblRut.TabIndex = 0;
            lblRut.Text = "Rut";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(165, 138);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombres";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(165, 182);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(72, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellidos";
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(165, 224);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(98, 20);
            lblNacionalidad.TabIndex = 3;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(165, 259);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección";
            // 
            // lblComuna
            // 
            lblComuna.AutoSize = true;
            lblComuna.Location = new Point(165, 298);
            lblComuna.Name = "lblComuna";
            lblComuna.Size = new Size(64, 20);
            lblComuna.TabIndex = 5;
            lblComuna.Text = "Comuna";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(319, 99);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(182, 27);
            txtRut.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(319, 138);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(319, 179);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(182, 27);
            txtApellido.TabIndex = 8;
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(319, 217);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(182, 27);
            txtNacionalidad.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(319, 259);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(182, 27);
            txtDireccion.TabIndex = 10;
            // 
            // txtComuna
            // 
            txtComuna.Location = new Point(319, 295);
            txtComuna.Name = "txtComuna";
            txtComuna.Size = new Size(182, 27);
            txtComuna.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(344, 353);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 39);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmAgregarContribuyente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
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
            Name = "FrmAgregarContribuyente";
            Text = "FrmAgregarContribuyente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRut;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblNacionalidad;
        private Label lblDireccion;
        private Label lblComuna;
        private TextBox txtRut;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNacionalidad;
        private TextBox txtDireccion;
        private TextBox txtComuna;
        private Button btnGuardar;
    }
}