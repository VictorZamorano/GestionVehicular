using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionVehicular.Data
{
    public class ConnectionHelper
    {
        private readonly string connectionString =
            "Server=127.0.0.1;Port=3306;Database=gestionpermisos;Uid=root;Pwd=;";

        public MySqlConnection ObtenerConexion()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
