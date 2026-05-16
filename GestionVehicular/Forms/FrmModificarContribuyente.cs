using GestionVehicular.Data;
using GestionVehicular.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionVehicular.Forms
{
    public partial class FrmModificarContribuyente : Form
    {
        private ContribuyenteData data = new ContribuyenteData();

        public FrmModificarContribuyente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var c = data.ObtenerPorRut(txtRut.Text);

            if (c == null)
            {
                MessageBox.Show("Contribuyente no encontrado");
                return;
            }

            txtNombre.Text = c.Nombre;
            txtApellido.Text = c.Apellido;
            txtNacionalidad.Text = c.Nacionalidad;
            txtDireccion.Text = c.Direccion;
            txtComuna.Text = c.Comuna;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
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

            if (data.Modificar(c))
            {
                MessageBox.Show("Datos modificados correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al modificar los datos.");
            }
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtRut.Text))
            {
                MessageBox.Show("Debe buscar un contribuyente primero.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNacionalidad.Text))
            {
                MessageBox.Show("La nacionalidad es obligatoria.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtComuna.Text))
            {
                MessageBox.Show("La comuna es obligatoria.");
                return false;
            }

            return true;
        }
    }
}