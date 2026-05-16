using GestionVehicular.Data;
using GestionVehicular.Forms;
using MySql.Data.MySqlClient;


namespace GestionVehicular
{
    public partial class FrmMain : Form
    {
        readonly ConnectionHelper connecHelper = new();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void TestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new ConnectionHelper().ObtenerConexion())
                {
                    MessageBox.Show("Conexión exitosa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void listadoDeContribuyenteYVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmList ventana = new FrmList();
            ventana.ShowDialog();

        }

        private void agregarContribuyentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAgregarContribuyente().ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmAgregarVehiculo().ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarContribuyente().ShowDialog();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmModificarVehiculo().ShowDialog();
        }
    }
}
