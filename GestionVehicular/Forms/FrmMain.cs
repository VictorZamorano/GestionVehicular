using GestionVehicular.Data;
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
    }
}
