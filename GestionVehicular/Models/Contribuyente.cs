using System;
using System.Collections.Generic;
using System.Text;
using static GestionVehicular.Data.StringHelper;

namespace GestionVehicular.Models
{
    public class Contribuyente
    {
        private string _rut = string.Empty;
        private string _nombre = string.Empty;
        private string _apellido = string.Empty;
        private string _nacionalidad = string.Empty;
        private string _direccion = string.Empty;
        private string _comuna = string.Empty;

        public string Rut
        {
            get => _rut;
            set => _rut = RutFormateador.FormatearRut(value ?? string.Empty);
        }
        public string Nombre
        {
            get => _nombre;
            set => _nombre = Formateador.Capitalizar(value ?? string.Empty);
        }
        public string Apellido
        {
            get => _apellido;
            set => _apellido = Formateador.Capitalizar(value ?? string.Empty);
        }
        public string Nacionalidad
        {
            get => _nacionalidad;
            set => _nacionalidad = Formateador.Capitalizar(value ?? string.Empty);
        }
        public string Direccion
        {
            get => _direccion;
            set => _direccion = Formateador.Capitalizar(value ?? string.Empty);
        }
        public string Comuna
        {
            get => _comuna;
            set => _comuna = Formateador.Capitalizar(value ?? string.Empty);
        }

    }
}
