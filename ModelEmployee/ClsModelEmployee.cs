using System;

namespace ModelEmployee
{
    public class ClsModelEmployee
    {

        public ClsModelEmployee() { }

        public ClsModelEmployee(string nombres, string apellidos, string fechaNacimiento, string identificacion, string tipoIdentificacion, string genero, string cargo, string nacionalidad, string codigo, string celular, string telefonoFijo)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Identificacion = identificacion;
            TipoIdentificacion = tipoIdentificacion;
            Genero = genero;
            Cargo = cargo;
            Nacionalidad = nacionalidad;
            Codigo = codigo;
            Celular = celular;
            TelefonoFijo = telefonoFijo;
        }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string FechaNacimiento { get; set; }
        public string Identificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Genero { get; set; }
        public string Cargo { get; set; }
        public string Nacionalidad { get; set; }
        public string Codigo { get; set; }
        public string Celular { get; set; }
        public string TelefonoFijo { get; set; }
    }
}
