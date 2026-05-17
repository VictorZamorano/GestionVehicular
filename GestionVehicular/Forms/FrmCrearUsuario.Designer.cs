namespace GestionVehicular.Forms
{
    partial class FrmCrearUsuario
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
            lblUsuario = new Label();
            lblPass = new Label();
            lblConfirm = new Label();
            lblRol = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            txtConfirm = new TextBox();
            cmbRol = new ComboBox();
            btnCrear = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(173, 111);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(109, 165);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(135, 20);
            lblPass.TabIndex = 1;
            lblPass.Text = "Ingrese Contraseña";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(96, 213);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(148, 20);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "Confirme Contraseña";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(144, 274);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(88, 20);
            lblRol.TabIndex = 3;
            lblRol.Text = "Eliga un Rol";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(260, 108);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(151, 27);
            txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(260, 158);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(151, 27);
            txtPass.TabIndex = 5;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(260, 213);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(151, 27);
            txtConfirm.TabIndex = 6;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "admin", "usuario" });
            cmbRol.Location = new Point(260, 274);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(151, 28);
            cmbRol.TabIndex = 7;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(248, 336);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(174, 38);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear Nuevo Usuario";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(638, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 40);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(cmbRol);
            Controls.Add(txtConfirm);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblRol);
            Controls.Add(lblConfirm);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            Name = "FrmCrearUsuario";
            Text = "FrmCrearUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblPass;
        private Label lblConfirm;
        private Label lblRol;
        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtConfirm;
        private ComboBox cmbRol;
        private Button btnCrear;
        private Button btnCancelar;
    }
}