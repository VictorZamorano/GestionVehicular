using GestionVehicular.Data;
using GestionVehicular.Forms;
using MySql.Data.MySqlClient;


namespace GestionVehicular
{
    public partial class FrmMain : Form
    {
        // Instancia del helper de conexión a la base de datos
        readonly ConnectionHelper connecHelper = new();

        public FrmMain()
        {
            InitializeComponent();
        }

        // Evento para probar la conexión a la base de datos
        private void TestConnection_Click(object sender, EventArgs e)
        {
            using MySqlConnection conn = connecHelper.ObtenerConexion();
            try
            {
                conn.Open();
                MessageBox.Show("Conexión exitosa a la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        // Evento para agregar contribuyente
        private void agregarContribuyenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgregarContribuyente ventana = new FrmAgregarContribuyente();
            ventana.ShowDialog();
        }

        // Evento para agregar vehículo
        private void agregarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarVehiculo ventana = new FrmAgregarVehiculo();
            ventana.ShowDialog();
        }

        // Evento para modificar contribuyente
        private void modificarContribuyenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModifContribuyente ventana = new FrmModifContribuyente();
            ventana.ShowDialog();
        }

        // Evento para modificar vehículo
        private void modificarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarVehiculo ventana = new FrmModificarVehiculo();
            ventana.ShowDialog();
        }

        // Evento para mostrar listado de contribuyentes y vehículos
        private void listadoDeContribuyenteYVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmList ventana = new FrmList();
            ventana.ShowDialog();

        }
    }
}
