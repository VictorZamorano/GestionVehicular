using System;
using System.Data;
using MySql.Data.MySqlClient;
using GestionVehicular.Models;

namespace GestionVehicular.Data
{
    public class VehiculoData
    {
        private readonly ConnectionHelper _connectionHelper;

        public VehiculoData()
        {
            _connectionHelper = new ConnectionHelper();
        }

        // ---------------------------------------------------------
        // 1) AGREGAR VEHÍCULO
        // ---------------------------------------------------------
        public bool Agregar(Vehiculo v)
        {
            try
            {
                using (var conn = _connectionHelper.ObtenerConexion())
                {
                    string sql = @"INSERT INTO vehiculo 
                                   (patente, marca, modelo, color, anio, rut_contribuyente)
                                   VALUES (@patente, @marca, @modelo, @color, @anio, @rut)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@patente", v.Patente);
                        cmd.Parameters.AddWithValue("@marca", v.Marca);
                        cmd.Parameters.AddWithValue("@modelo", v.Modelo);
                        cmd.Parameters.AddWithValue("@color", v.Color);
                        cmd.Parameters.AddWithValue("@anio", v.Anio);
                        cmd.Parameters.AddWithValue("@rut", v.RutContribuyente);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar vehículo: " + ex.Message);
            }
        }

        // ---------------------------------------------------------
        // 2) LISTAR TODOS LOS VEHÍCULOS
        // ---------------------------------------------------------
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM vehiculo";

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
                throw new Exception("Error al listar vehículos: " + ex.Message);
            }

            return dt;
        }

        // ---------------------------------------------------------
        // 3) LISTAR VEHÍCULOS POR RUT (para consultas)
        // ---------------------------------------------------------
        public DataTable ListarPorRut(string rut)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM vehiculo WHERE rut_contribuyente = @rut";

            try
            {
                using (var conn = _connectionHelper.ObtenerConexion())
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@rut", rut);

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener vehículos del contribuyente: " + ex.Message);
            }

            return dt;
        }

        public Vehiculo ObtenerPorPatente(string patente)
        {
            Vehiculo v = null;

            string query = "SELECT * FROM vehiculo WHERE patente = @patente";

            try
            {
                using (var conn = _connectionHelper.ObtenerConexion())
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patente", patente);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            v = new Vehiculo
                            {
                                Patente = reader.GetString("patente"),
                                Marca = reader.GetString("marca"),
                                Modelo = reader.GetString("modelo"),
                                Color = reader.GetString("color"),
                                Anio = reader.GetInt32("anio"),
                                RutContribuyente = reader.GetString("rut_contribuyente")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener vehículo: " + ex.Message);
            }

            return v;
        }

        public bool Modificar(Vehiculo v)
        {
            string query = @"UPDATE vehiculo SET 
                        marca = @marca,
                        modelo = @modelo,
                        color = @color,
                        anio = @anio,
                        rut_contribuyente = @rut
                     WHERE patente = @patente";

            try
            {
                using (var conn = _connectionHelper.ObtenerConexion())
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patente", v.Patente);
                    cmd.Parameters.AddWithValue("@marca", v.Marca);
                    cmd.Parameters.AddWithValue("@modelo", v.Modelo);
                    cmd.Parameters.AddWithValue("@color", v.Color);
                    cmd.Parameters.AddWithValue("@anio", v.Anio);
                    cmd.Parameters.AddWithValue("@rut", v.RutContribuyente);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar vehículo: " + ex.Message);
            }
        }
    }
}

