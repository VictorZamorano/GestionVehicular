using GestionVehicular.Data;
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
    public partial class FrmConsultarContribuyente : Form
    {
        public FrmConsultarContribuyente()
        {
            InitializeComponent();
        }

        // Evento para buscar contribuyente por RUT
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text.Trim();
            // Validar que el RUT no esté vacío
            if (string.IsNullOrEmpty(rut))
            {
                MessageBox.Show("Por favor, ingrese un RUT para buscar.");
                return;
            }

            // Obtener el contribuyente por RUT utilizando el método BuscarContribuyentePorRut
            ContribuyenteData contribuyenteData = new ContribuyenteData();
            DataTable dt = contribuyenteData.ObtenerContribuyentesYVehiculos();

            // Filtrar el DataTable por el RUT ingresado
            DataRow[] rows = dt.Select($"[RUT Contribuyente] = '{rut}'");

            if (rows.Length > 0)
            {
                // Si se encuentra el contribuyente, mostrar su información
                DataRow row = rows[0];
                txtNombre.Text = row["Nombre"].ToString();
                txtApellido.Text = row["Apellido"].ToString();
                txtNacionalidad.Text = row["Nacionalidad"].ToString();
                txtDireccion.Text = row["Dirección"].ToString();
                txtComuna.Text = row["Comuna"].ToString();
            }
            else
            {
                // Si no se encuentra el contribuyente, mostrar un mensaje
                MessageBox.Show("No se encontró un contribuyente con ese RUT.");
            }

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
