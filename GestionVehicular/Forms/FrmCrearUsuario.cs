using GestionVehicular.Data;
using GestionVehicular.Models;
using System;
using System.Windows.Forms;

namespace GestionVehicular.Forms
{
    public partial class FrmCrearUsuario : Form
    {
        UsuarioData usuarioData = new UsuarioData();

        public FrmCrearUsuario()
        {
            InitializeComponent();
            cmbRol.Items.Add("admin");
            cmbRol.Items.Add("usuario");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text;
            string confirm = txtConfirm.Text;
            string rol = cmbRol.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(user) ||
                string.IsNullOrEmpty(pass) ||
                string.IsNullOrEmpty(confirm) ||
                rol == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (pass != confirm)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(pass);

            Usuario nuevo = new Usuario
            {
                Username = user,
                PasswordHash = hash,
                Rol = rol
            };

            if (usuarioData.InsertUsuario(nuevo))
            {
                MessageBox.Show("Usuario creado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al crear el usuario.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
