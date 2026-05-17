using GestionVehicular.Data;
using GestionVehicular.Forms;
using GestionVehicular.Models;
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
            using MySqlConnection conn = ConnectionHelper.ObtenerConexion();
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

        // Evento para consultar por contribuyente
        private void consultarPorContribuyenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarContribuyente ventana = new FrmConsultarContribuyente();
            ventana.ShowDialog();
        }

        // Evento para consultar por vehículo
        private void consultarPorVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarVehiculo ventana = new FrmConsultarVehiculo();
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

        private Usuario _usuario;

        public FrmMain(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;

            lblUsuarioActual.Text = $"Bienvenido, {_usuario.Username}";
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frm = new FrmCrearUsuario();
            frm.ShowDialog();
        }

        private void salirDeLaAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "¿Desea cerrar la aplicación?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Cerrando aplicación...", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show(
            "¿Desea cerrar sesión?",
            "Cerrar sesión",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close();
            }
        }
    }
}
