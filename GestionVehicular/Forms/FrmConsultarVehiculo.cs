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
    public partial class FrmConsultarVehiculo : Form
    {
        public FrmConsultarVehiculo()
        {
            InitializeComponent();
        }
        private VehiculoData data = new VehiculoData();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string patente = txtPatente.Text.Trim();
            // Validar que la patente no esté vacía
            if (string.IsNullOrEmpty(patente))
            {
                MessageBox.Show("Por favor, ingrese una patente para buscar.");
                return;
            }

            // Obtener el vehículo por patente utilizando el método BuscarVehiculoPorPatente
            VehiculoData vehiculoData = new VehiculoData();


            // Filtrar el DataTable para encontrar el vehículo con la patente ingresada
            var v = data.ObtenerPorPatente(txtPatente.Text);

            if (v == null)
            {
                MessageBox.Show("No se encontró ningún vehículo con la patente ingresada.");
                // Limpiar los TextBox
                txtMarca.Clear();
                txtModelo.Clear();
                txtAnio.Clear();
                txtColor.Clear();
                txtRut.Clear();
            }

            txtMarca.Text = v.Marca;
            txtModelo.Text = v.Modelo;
            txtColor.Text = v.Color;
            txtAnio.Text = v.Anio.ToString();
            txtRut.Text = v.RutContribuyente;
        }
    }
}
