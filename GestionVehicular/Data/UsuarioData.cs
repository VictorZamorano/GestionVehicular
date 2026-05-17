using GestionVehicular.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Text;
using BCrypt.Net;


namespace GestionVehicular.Data
{
    public class UsuarioData
    {
        public Usuario Login(string username, string password)
        {
            using (var conn = ConnectionHelper.ObtenerConexion())
            {
                conn.Open();

                string sql = @"SELECT Id, Username, PasswordHash, Rol 
                               FROM Usuarios 
                               WHERE Username = @user";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        string hash = reader.GetString("PasswordHash");

                        // Validar contraseña
                        if (!BCrypt.Net.BCrypt.Verify(password, hash))
                            return null;

                        return new Usuario
                        {
                            Id = reader.GetInt32("Id"),
                            Username = reader.GetString("Username"),
                            PasswordHash = hash,
                            Rol = reader.GetString("Rol")
                        };
                    }
                }
            }
        }
            public bool InsertUsuario(Usuario usuario)
        {
            using (var conn = ConnectionHelper.ObtenerConexion())
            {
                conn.Open();

                string sql = @"INSERT INTO Usuarios (Username, PasswordHash, Rol)
                       VALUES (@user, @hash, @rol)";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", usuario.Username);
                    cmd.Parameters.AddWithValue("@hash", usuario.PasswordHash);
                    cmd.Parameters.AddWithValue("@rol", usuario.Rol);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}