using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionVehicular.Data;

namespace GestionVehicular.Forms
{
    public partial class FrmList : Form
    {
        private readonly ContribuyenteData _contribuyenteData;

        public FrmList()
        {
            InitializeComponent();
            _contribuyenteData = new ContribuyenteData();
        }

        // Carga los datos de empleados y departamentos al abrir el formulario
        private void FrmList_Load_1(object sender, EventArgs e)
        {
            CargarDatos();
        }

        // Método encargado de refrescar el DataGridView
        private void CargarDatos()
        {
            try
            {
                // Llamamos al método que creamos en ContribuyenteData
                DataTable datos = _contribuyenteData.ObtenerContribuyentesYVehiculos();

                // Asignamos el DataTable directamente como origen de datos del DataGridView
                dgvData.DataSource = datos;

                // Ajustamos el tamaño de las columnas para que se adapten al contenido
                dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
