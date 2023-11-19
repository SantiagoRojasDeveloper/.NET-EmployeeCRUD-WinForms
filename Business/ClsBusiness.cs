using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using EmployeeDB;
using ModelEmployee;

namespace Business
{
    public class ClsBusiness
    {

        private ClsEmployeeDB _dbEmployee;

        public ClsBusiness() 
        {
            _dbEmployee = new ClsEmployeeDB();
        }

        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public bool ValidateLogin(string user, string sPass)
        {
            //Realiza las validaciones para el login de la aplicación
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(sPass))
            {
                return false;
            }

            return _dbEmployee.login(user, sPass);
        }

        public bool CreateAccount(string user, string pass, string confirmPass) 
        {

            // Validaciones para crear la cuenta

            //Valida que los campos no vengan nulos
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(confirmPass)) 
            {
                return false;
            }

            // Valida que las contraseñas coincidan
            if (!pass.Equals(confirmPass)) 
            {
                return false;
            }

            return _dbEmployee.createAccount(user, GetSHA256(pass));

        }

        public string CreateEmployee(string name, string surname, string birthdate,
            string identification, string typeIdentification, string gender, string pathImage,
            bool createEmployee) 
        {
            //Validaciones de los campos
            if (string.IsNullOrWhiteSpace(name) 
                || string.IsNullOrWhiteSpace(surname)
                || birthdate == null
                || string.IsNullOrWhiteSpace(identification)
                || string.IsNullOrWhiteSpace(typeIdentification)
                || string.IsNullOrWhiteSpace(gender)
                || string.IsNullOrWhiteSpace(pathImage))
            {
                return "Los campos para insertar al Empleado no estan completos";
            }

            //Validacion de empleado mayor de edad
            string fechaString = birthdate;
            DateTime fechaNacimiento;

            if (DateTime.TryParseExact(fechaString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaNacimiento))
            {
                DateTime fechaActual = DateTime.Today;
                int edad = fechaActual.Year - fechaNacimiento.Year;

                if (fechaNacimiento > fechaActual.AddYears(-edad))
                {
                    edad--;
                }

                if (edad < 18)
                {
                    return "El empleado es menor de edad";
                }

                return _dbEmployee.CreateEmployee(name, surname, birthdate,
                    identification, typeIdentification, gender, pathImage, createEmployee);
            }
            else
            {
                return "La fecha ingresada no es válida";
            }
        }

        public void UpdateEmployee(ClsModelEmployee editedEmployee) {
            /*_dbEmployee.UpdateEmployee(editedEmployee.Nombres, editedEmployee.Apellidos,
                editedEmployee.FechaNacimiento, editedEmployee.Identificacion,
                editedEmployee.TipoIdentificacion, editedEmployee.Genero);*/
        }

        public List<ClsModelEmployee> GetEmployeeList() 
        { 
            return _dbEmployee.GetEmployeeList();
        }

        public void DeleteEmployee(string id) 
        {
            _dbEmployee.DeleteEmployee(id);
        }

        public string GetProfileImage(string identificacion)
        {
            return _dbEmployee.GetProfileImage(identificacion);
        }
    }
}
