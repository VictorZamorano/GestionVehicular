using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionVehicular.Data;
using GestionVehicular.Models;

namespace GestionVehicular.Forms
{
    public partial class FrmModifContribuyente : Form
    {
        public FrmModifContribuyente()
        {
            InitializeComponent();
        }

        // Evento del botón Buscar para cargar los datos del contribuyente en los campos de texto
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text.Trim();
            if (string.IsNullOrEmpty(rut))
            {
                MessageBox.Show("Por favor, ingrese el RUT del contribuyente.");
                return;
            }

            try
            {
                ContribuyenteData contribuyenteData = new ContribuyenteData();
                Contribuyente contribuyente = contribuyenteData.BuscarContribuyentePorRut(rut);

                // Cargar los datos en los campos de texto
                txtNombre.Text = contribuyente.Nombre;
                txtApellido.Text = contribuyente.Apellido;
                txtNacionalidad.Text = contribuyente.Nacionalidad;
                txtDireccion.Text = contribuyente.Direccion;
                txtComuna.Text = contribuyente.Comuna;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Evento del botón Guardar para actualizar los datos del contribuyente en la base de datos
        private void btnGuardar_Click(object sender, EventArgs e)
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
            try
            {
                ContribuyenteData contribuyenteData = new ContribuyenteData();
                contribuyenteData.ModificarContribuyente(
                    contribuyente.Rut,
                    contribuyente.Nombre,
                    contribuyente.Apellido,
                    contribuyente.Nacionalidad,
                    contribuyente.Direccion,
                    contribuyente.Comuna
                );
                MessageBox.Show("Contribuyente actualizado exitosamente.");

                //limpiar los campos después de guardar
                txtRut.Clear(); txtNombre.Clear(); txtApellido.Clear(); txtNacionalidad.Clear(); txtDireccion.Clear(); txtComuna.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }
    }
}
