using System;

namespace ModelEmployee
{
    public class ClsModelEmployee
    {

        public ClsModelEmployee() { }

        public ClsModelEmployee(string nombres, string apellidos, string fechaNacimiento, string identificacion, string tipoIdentificacion, string genero)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Identificacion = identificacion;
            TipoIdentificacion = tipoIdentificacion;
            Genero = genero;
        }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string FechaNacimiento { get; set; }
        public string Identificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Genero { get; set; }
    }
}
