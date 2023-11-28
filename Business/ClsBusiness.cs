using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

        public string CreateEmployee(string acNo, string name, string gender, string no, string nacionality,
            string telephone, string cargo, string rol, string birthdate, string dischargeDate,
            string codTar, string phone, string address, string pathImage, bool createEmployee) 
        {
            //Validaciones de los campos
            if (string.IsNullOrWhiteSpace(acNo) 
                || string.IsNullOrWhiteSpace(name)
                || birthdate == null
                || dischargeDate == null
                || string.IsNullOrWhiteSpace(gender)
                || string.IsNullOrWhiteSpace(no)
                || string.IsNullOrWhiteSpace(nacionality)
                || string.IsNullOrWhiteSpace(telephone)
                || string.IsNullOrWhiteSpace(cargo)
                || string.IsNullOrWhiteSpace(rol)
                || string.IsNullOrWhiteSpace(codTar)
                || string.IsNullOrWhiteSpace(phone)
                || string.IsNullOrWhiteSpace(address))
            {
                return "Los campos para insertar al Empleado no estan completos";
            }
            //Validación de ruta de imagen
            if (string.IsNullOrWhiteSpace(pathImage)) 
            {
                return "Seleccione una imagen para el perfil...";
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

                return _dbEmployee.CreateEmployee(acNo, name, gender, no, nacionality,
                    telephone, cargo, rol, birthdate, dischargeDate,
                    codTar, phone, address, pathImage, createEmployee);
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

        public ClsModelEmployee searchEmployee(string no)
        {
            return _dbEmployee.searchEmployee(no);
        }
    }
}
