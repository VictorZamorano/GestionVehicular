using System;
using System.Data;
using MySql.Data.MySqlClient;
using GestionVehicular.Models;

namespace GestionVehicular.Data
{
    public class ContribuyenteData
    {
        private readonly ConnectionHelper _connectionHelper;

        public ContribuyenteData()
        {
            _connectionHelper = new ConnectionHelper();
        }

        // ============================================================
        // 1. OBTENER CONTRIBUYENTES + VEHÍCULOS (JOIN)
        // ============================================================
        public DataTable ObtenerContribuyentesYVehiculos()
        {
            DataTable dt = new DataTable();

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
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos: " + ex.Message);
            }

            return dt;
        }

        // ============================================================
        // 2. BUSCAR CONTRIBUYENTE POR RUT
        // ============================================================
        public Contribuyente BuscarContribuyentePorRut(string rut)
        {
            string query = @"
            SELECT rut, nombre, apellido, nacionalidad, direccion, comuna
            FROM Contribuyente
            WHERE rut = @rut;";

            try
            {
                using (MySqlConnection conn = _connectionHelper.ObtenerConexion())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@rut", rut);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Contribuyente
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
                throw new Exception("Error al buscar contribuyente: " + ex.Message);
            }

            return null;
        }

        // ============================================================
        // 3. MODIFICAR CONTRIBUYENTE
        // ============================================================
        public void ModificarContribuyente(string rut, string nombre, string apellido,
                                           string nacionalidad, string direccion, string comuna)
        {
            string query = @"
            UPDATE Contribuyente
            SET nombre = @nombre,
                apellido = @apellido,
                nacionalidad = @nacionalidad,
                direccion = @direccion,
                comuna = @comuna
            WHERE rut = @rut;";

            try
            {
                using (MySqlConnection conn = _connectionHelper.ObtenerConexion())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@rut", rut);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@comuna", comuna);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar contribuyente: " + ex.Message);
            }
        }

        public void Agregar(Contribuyente contribuyente)
        {
            string query = @"
    INSERT INTO Contribuyente (rut, nombre, apellido, nacionalidad, direccion, comuna)
    VALUES (@rut, @nombre, @apellido, @nacionalidad, @direccion, @comuna);";

            try
            {
                using (MySqlConnection conn = _connectionHelper.ObtenerConexion())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@rut", contribuyente.Rut);
                    cmd.Parameters.AddWithValue("@nombre", contribuyente.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", contribuyente.Apellido);
                    cmd.Parameters.AddWithValue("@nacionalidad", contribuyente.Nacionalidad);
                    cmd.Parameters.AddWithValue("@direccion", contribuyente.Direccion);
                    cmd.Parameters.AddWithValue("@comuna", contribuyente.Comuna);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar contribuyente: " + ex.Message);
            }
        }

        public Contribuyente ObtenerPorRut(string rut)
        {
            string query = @"
    SELECT rut, nombre, apellido, nacionalidad, direccion, comuna
    FROM Contribuyente
    WHERE rut = @rut;";

            try
            {
                using (MySqlConnection conn = _connectionHelper.ObtenerConexion())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@rut", rut);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Contribuyente
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

            return null;
        }

        public void Modificar(Contribuyente contribuyente)
        {
            string query = @"
    UPDATE Contribuyente
    SET nombre = @nombre,
        apellido = @apellido,
        nacionalidad = @nacionalidad,
        direccion = @direccion,
        comuna = @comuna
    WHERE rut = @rut;";

            try
            {
                using (MySqlConnection conn = _connectionHelper.ObtenerConexion())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@rut", contribuyente.Rut);
                    cmd.Parameters.AddWithValue("@nombre", contribuyente.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", contribuyente.Apellido);
                    cmd.Parameters.AddWithValue("@nacionalidad", contribuyente.Nacionalidad);
                    cmd.Parameters.AddWithValue("@direccion", contribuyente.Direccion);
                    cmd.Parameters.AddWithValue("@comuna", contribuyente.Comuna);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar contribuyente: " + ex.Message);
            }
        }

    }
}

