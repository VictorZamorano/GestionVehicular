using System;
using System.Collections.Generic;
using System.Text;
using static GestionVehicular.Data.StringHelper.Formateador;
using static GestionVehicular.Data.StringHelper.RutFormateador;

namespace GestionVehicular.Models
{
    public class Contribuyente
    {
        private string _rut;
        private string _nombre;
        private string _apellido;
        private string _nacionalidad;
        private string _direccion;
        private string _comuna;

        public string Rut
        {
            get => _rut;
            set => _rut = FormatearRut(value ?? string.Empty);
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = Capitalizar(value ?? string.Empty);
        }

        public string Apellido
        {
            get => _apellido;
            set => _apellido = Capitalizar(value ?? string.Empty);
        }

        public string Nacionalidad
        {
            get => _nacionalidad;
            set => _nacionalidad = Capitalizar(value ?? string.Empty);
        }

        public string Direccion
        {
            get => _direccion;
            set => _direccion = Capitalizar(value ?? string.Empty);
        }

        public string Comuna
        {
            get => _comuna;
            set => _comuna = Capitalizar(value ?? string.Empty);
        }
    }
}


