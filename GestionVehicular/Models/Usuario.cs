using System;
using System.Collections.Generic;
using System.Text;

namespace GestionVehicular.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Rol { get; set; }
    }
}
