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
            btnIngresar.Location = new Point(315, 242);
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
            lblError.Location = new Point(272, 338);
            lblError.Name = "lblError";
            lblError.Size = new Size(227, 20);
            lblError.TabIndex = 5;
            lblError.Text = "Usuario o Contraseña Incorrectos";
            lblError.Visible = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Name = "FrmLogin";
            Text = "FrmLogin";
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
    }
}