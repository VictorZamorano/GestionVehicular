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
    public partial class FrmModificarVehiculo : Form
    {
        private VehiculoData data = new VehiculoData();

        public FrmModificarVehiculo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var v = data.ObtenerPorPatente(txtPatente.Text);

            if (v == null)
            {
                MessageBox.Show("Vehículo no encontrado");
                return;
            }

            txtMarca.Text = v.Marca;
            txtModelo.Text = v.Modelo;
            txtColor.Text = v.Color;
            txtAnio.Text = v.Anio.ToString();
            txtRutContribuyente.Text = v.RutContribuyente;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var v = new Vehiculo
            {
                Patente = txtPatente.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Color = txtColor.Text,
                Anio = int.Parse(txtAnio.Text),
                RutContribuyente = txtRutContribuyente.Text
            };

            if (data.ModificarVehiculo(v))
            {
                MessageBox.Show("Vehículo modificado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al modificar el vehículo.");
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtPatente.Text))
            {
                MessageBox.Show("Debe buscar un vehículo primero.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("La marca es obligatoria.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("El modelo es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("El color es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAnio.Text))
            {
                MessageBox.Show("El año es obligatorio.");
                return false;
            }

            if (!int.TryParse(txtAnio.Text, out int anio))
            {
                MessageBox.Show("El año debe ser un número válido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRutContribuyente.Text))
            {
                MessageBox.Show("El RUT del contribuyente es obligatorio.");
                return false;
            }

            return true;
        }
    }
}