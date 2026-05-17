using GestionVehicular.Data;
using GestionVehicular.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static GestionVehicular.Data.StringHelper;

namespace GestionVehicular.Forms
{
    public partial class FrmAgregarContribuyente : Form
    {
        public FrmAgregarContribuyente()
        {
            InitializeComponent();
        }

        // Evento del botón Guardar contribuyente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var c = new Contribuyente
            {
                Rut = txtRut.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Nacionalidad = txtNacionalidad.Text,
                Direccion = txtDireccion.Text,
                Comuna = txtComuna.Text
            };

            var data = new ContribuyenteData();

            if (data.AgregarContribuyente(c))
            {
                MessageBox.Show("Contribuyente agregado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar contribuyente");
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtRut.Text))
            {
                MessageBox.Show("El RUT es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNacionalidad.Text))
            {
                MessageBox.Show("La nacionalidad es obligatoria");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtComuna.Text))
            {
                MessageBox.Show("La comuna es obligatoria");
                return false;
            }

            return true;
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRut.Text))
            {
                // El formato (puntos y guion) solo se aplica al salir del campo
                txtRut.Text = RutFormateador.FormatearRut(txtRut.Text);
            }
        }

        // Evento para permitir solo números, guiones y la letra 'k' en el campo de texto del RUT
        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != 'k' && e.KeyChar != 'K')
            {
                e.Handled = true;
            }
        }

        private void txtRut_Enter(object sender, EventArgs e)
        {
            txtRut.Text = txtRut.Text.Replace(".", "").Replace("-", "");
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            // Limpiamos temporalmente para contar cuántos números reales hay
            string soloNumeros = txtRut.Text.Replace(".", "").Replace("-", "");

            // Si tiene menos de 8 o 9 caracteres (un RUT normal), se pone rojo
            if (soloNumeros.Length < 8)
            {
                txtRut.ForeColor = Color.Red;
            }
            else
            {
                txtRut.ForeColor = SystemColors.WindowText; // Color negro normal
            }
        }
    }
}

