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

        private void listadoDeContribuyenteYVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmList ventana = new FrmList();
            ventana.ShowDialog();

        }

        private void modificarContribuyenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModifContribuyente ventana = new FrmModifContribuyente();
            ventana.ShowDialog();
        }
    }
}
