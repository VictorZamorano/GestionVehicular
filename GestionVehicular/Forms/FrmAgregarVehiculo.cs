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
    public partial class FrmAgregarVehiculo : Form
    {
        public FrmAgregarVehiculo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
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

            var data = new VehiculoData();

            if (data.Agregar(v))
            {
                MessageBox.Show("Vehículo agregado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar vehículo");
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtPatente.Text))
            {
                MessageBox.Show("La patente es obligatoria");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("La marca es obligatoria");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("El modelo es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("El color es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAnio.Text))
            {
                MessageBox.Show("El año es obligatorio");
                return false;
            }

            if (!int.TryParse(txtAnio.Text, out int anio))
            {
                MessageBox.Show("El año debe ser un número válido");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRutContribuyente.Text))
            {
                MessageBox.Show("El RUT del contribuyente es obligatorio");
                return false;
            }

            return true;
        }
    }
}


