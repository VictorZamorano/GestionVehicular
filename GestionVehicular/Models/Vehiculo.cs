using System;
using System.Collections.Generic;
using System.Text;

namespace GestionVehicular.Models
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string RutContribuyente { get; set; }
    }
}

