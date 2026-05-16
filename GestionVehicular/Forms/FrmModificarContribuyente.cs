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
            string rut = txtRut.Text.Trim();
            if (string.IsNullOrEmpty(rut))
            {
                MessageBox.Show("Por favor, ingrese el RUT del contribuyente.");
                return;
            }

            Contribuyente contribuyente = new Contribuyente
            {
                Rut = rut,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Nacionalidad = txtNacionalidad.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Comuna = txtComuna.Text.Trim()
            };

            ContribuyenteData contribuyenteData = new ContribuyenteData();
            contribuyenteData.Modificar(contribuyente);

            MessageBox.Show("Contribuyente modificado exitosamente.");

            txtRut.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNacionalidad.Clear();
            txtDireccion.Clear();
            txtComuna.Clear();
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