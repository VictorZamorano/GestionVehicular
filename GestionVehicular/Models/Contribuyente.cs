using System;
using System.Collections.Generic;
using System.Text;
using static GestionVehicular.Data.StringHelper;

namespace GestionVehicular.Models
{
    public class Contribuyente
    {
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
