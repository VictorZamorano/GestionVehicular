using GestionVehicular.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionVehicular.Forms
{
    public partial class FrmLogin : Form
    {
        UsuarioData usuarioData = new UsuarioData();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string pass = txtPassword.Text.Trim();

            var usuario = usuarioData.Login(user, pass);

            if (usuario == null)
            {
                lblError.Text = "Usuario o contraseña incorrectos";
                lblError.Visible = true;
                return;
            }

            // Login correcto → abrir menú principal
            FrmMain main = new FrmMain(usuario);
            main.Show();
            this.Hide();
        }
    }
}
