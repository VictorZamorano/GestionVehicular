using GestionVehicular.Models;
using MySql.Data.MySqlClient;
using System.Data;

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

        public bool Agregar(Contribuyente c)
        {
            try
            {
                using (var conn = _connectionHelper.ObtenerConexion())
                {
                    string sql = @"INSERT INTO contribuyente 
                           (rut, nombre, apellido, nacionalidad, direccion, comuna)
                           VALUES (@rut, @nombre, @apellido, @nacionalidad, @direccion, @comuna)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@rut", c.Rut);
                        cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", c.Apellido);
                        cmd.Parameters.AddWithValue("@nacionalidad", c.Nacionalidad);
                        cmd.Parameters.AddWithValue("@direccion", c.Direccion);
                        cmd.Parameters.AddWithValue("@comuna", c.Comuna);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar contribuyente: " + ex.Message);
            }
        }
          

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM contribuyente";

            try
            {
                using (var conn = _connectionHelper.ObtenerConexion())
                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar contribuyentes: " + ex.Message);
            }

            return dt;
        }

        public Contribuyente ObtenerPorRut(string rut)
        {
            Contribuyente c = null;

            string query = "SELECT * FROM contribuyente WHERE rut = @rut";

            try
            {
                using (var conn = _connectionHelper.ObtenerConexion())
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@rut", rut);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            c = new Contribuyente
                            {
                                Rut = reader.GetString("rut"),
                                Nombre = reader.GetString("nombre"),
                                Apellido = reader.GetString("apellido"),
                                Nacionalidad = reader.GetString("nacionalidad"),
                                Direccion = reader.GetString("direccion"),
                                Comuna = reader.GetString("comuna")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener contribuyente: " + ex.Message);
            }

            return c;
        }

        public bool Modificar(Contribuyente c)
        {
            string query = @"UPDATE contribuyente SET 
                        nombre = @nombre,
                        apellido = @apellido,
                        nacionalidad = @nacionalidad,
                        direccion = @direccion,
                        comuna = @comuna
                     WHERE rut = @rut";

            try
            {
                using (var conn = _connectionHelper.ObtenerConexion())
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@rut", c.Rut);
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", c.Apellido);
                    cmd.Parameters.AddWithValue("@nacionalidad", c.Nacionalidad);
                    cmd.Parameters.AddWithValue("@direccion", c.Direccion);
                    cmd.Parameters.AddWithValue("@comuna", c.Comuna);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar contribuyente: " + ex.Message);
            }
        }

    }
}
