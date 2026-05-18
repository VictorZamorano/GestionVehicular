namespace GestionVehicular.Forms
{
    partial class FrmLogin
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
            lblPassword = new Label();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            lblError = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(201, 133);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(201, 181);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(315, 243);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(106, 41);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(296, 133);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(175, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(296, 181);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(272, 339);
            lblError.Name = "lblError";
            lblError.Size = new Size(227, 20);
            lblError.TabIndex = 5;
            lblError.Text = "Usuario o Contraseña Incorrectos";
            lblError.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 339);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 6;
            label1.Text = "Usuario: admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 359);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 7;
            label2.Text = "Pass: admin123";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 319);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 8;
            label3.Text = "Cuenta de prueba:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(669, 370);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(106, 38);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnSalir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblError);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Name = "FrmLogin";
            Text = "FrmLogin";
            FormClosing += FrmLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblPassword;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label lblError;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSalir;
    }
}