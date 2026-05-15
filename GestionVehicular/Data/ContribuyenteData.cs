using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace GestionVehicular.Data
{
    public class ContribuyenteData
    {
        private readonly ConnectionHelper _connectionHelper;

        public ContribuyenteData()
        {
            _connectionHelper = new ConnectionHelper();
        }

        // Método que devuelve un DataTable con la información unificada
        public DataTable ObtenerContribuyentesYVehiculos()
        {
            DataTable dt = new DataTable();

            // Consulta SQL con JOIN para unir ambas tablas usando el RUT
            string query = @"
                SELECT 
                    c.rut AS 'RUT Contribuyente',
                    c.nombre AS 'Nombre',
                    c.apellido AS 'Apellido',
                    c.nacionalidad AS 'Nacionalidad',
                    c.direccion AS 'Dirección',
                    c.comuna AS 'Comuna',
                    v.patente AS 'Patente Vehículo',
                    v.marca AS 'Marca',
                    v.modelo AS 'Modelo',
                    v.color AS 'Color',
                    v.anio AS 'Año'
                FROM Contribuyente c
                LEFT JOIN Vehiculo v ON c.rut = v.rut_contribuyente;";

            try
            {
                using (MySqlConnection conn = _connectionHelper.ObtenerConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            // Llena el DataTable con los resultados de la consulta
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores en caso de fallo de conexión
                throw new Exception("Error al obtener los datos: " + ex.Message);
            }

            return dt;
        }
    }
}
