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
            btnGuardar = new Button();
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
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(341, 284);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 29);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtComuna
            // 
            txtComuna.Location = new Point(298, 239);
            txtComuna.Margin = new Padding(3, 2, 3, 2);
            txtComuna.Name = "txtComuna";
            txtComuna.Size = new Size(194, 23);
            txtComuna.TabIndex = 24;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(298, 212);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(194, 23);
            txtDireccion.TabIndex = 23;
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(298, 181);
            txtNacionalidad.Margin = new Padding(3, 2, 3, 2);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(194, 23);
            txtNacionalidad.TabIndex = 22;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(298, 152);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 23);
            txtApellido.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(298, 122);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 20;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(298, 92);
            txtRut.Margin = new Padding(3, 2, 3, 2);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(194, 23);
            txtRut.TabIndex = 19;
            // 
            // lblComuna
            // 
            lblComuna.AutoSize = true;
            lblComuna.Location = new Point(183, 245);
            lblComuna.Name = "lblComuna";
            lblComuna.Size = new Size(53, 15);
            lblComuna.TabIndex = 18;
            lblComuna.Text = "Comuna";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(183, 215);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 17;
            lblDireccion.Text = "Dirección";
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(183, 189);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(77, 15);
            lblNacionalidad.TabIndex = 16;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(183, 157);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 15;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(183, 125);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre";
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(183, 95);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(25, 15);
            lblRut.TabIndex = 13;
            lblRut.Text = "Rut";
            // 
            // FrmAgregarContribuyente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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

        private Button btnGuardar;
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
    }
}