using System;
using System.Data;
using GestionVehicular.Models;
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

        // Método para buscar un contribuyente por su RUT
        public Contribuyente BuscarContribuyentePorRut(string rut)
        {
            Contribuyente contribuyente = new Contribuyente();
            string query = "SELECT * FROM Contribuyente WHERE rut = @rut;";
            try
            {
                using (MySqlConnection conn = _connectionHelper.ObtenerConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rut", rut);
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                contribuyente = new Contribuyente
                                {
                                    Rut = reader["rut"].ToString(),
                                    Nombre = reader["nombre"].ToString(),
                                    Apellido = reader["apellido"].ToString(),
                                    Nacionalidad = reader["nacionalidad"].ToString(),
                                    Direccion = reader["direccion"].ToString(),
                                    Comuna = reader["comuna"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el contribuyente: " + ex.Message);
            }
            if (contribuyente == null)
            {
                throw new Exception("Contribuyente no encontrado.");
            }
            // Devuelve el contribuyente encontrado
            return contribuyente;
        }

        // Metodo para modificar un contribuyente
        public void ModificarContribuyente(string rut, string nombre, string apellido, string nacionalidad, string direccion, string comuna)
        {
            string query = @"
                UPDATE Contribuyente 
                SET nombre = @nombre, apellido = @apellido, nacionalidad = @nacionalidad, direccion = @direccion, comuna = @comuna
                WHERE rut = @rut;";
            try
            {
                using (MySqlConnection conn = _connectionHelper.ObtenerConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rut", rut);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@comuna", comuna);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el contribuyente: " + ex.Message);
            }
        }
    }
}
