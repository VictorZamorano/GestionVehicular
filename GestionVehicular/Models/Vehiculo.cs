using System;
using System.Collections.Generic;
using System.Text;
using static GestionVehicular.Data.StringHelper;

namespace GestionVehicular.Models
{
    public class Vehiculo
    {

        private string _patente = string.Empty;
        private string _marca = string.Empty;
        private string _modelo = string.Empty;
        private string _color = string.Empty;
        private int _anio = 0;
        private string _rutContribuyente = string.Empty;

        public string Patente
        {
            get => _patente;
            set => _patente = Mayusculizador.Mayusculas(value ?? string.Empty);
        }
        public string Marca { 
            get => _marca;
            set => _marca = value ?? string.Empty; }
        public string Modelo { 
            get => _modelo;
            set => _modelo = value ?? string.Empty; }
        public string Color { 
            get => _color;
            set => _color = value ?? string.Empty; }
        public int Anio { 
            get => _anio;
            set => _anio = value; }
        public string RutContribuyente { 
            get => _rutContribuyente;
            set => _rutContribuyente = value ?? string.Empty; }
    }
}

