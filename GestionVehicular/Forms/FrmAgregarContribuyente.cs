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
    public partial class FrmAgregarContribuyente : Form
    {
        public FrmAgregarContribuyente()
        {
            InitializeComponent();
        }

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

            if (data.Agregar(c))
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

    }
}
