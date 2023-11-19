using System;
using System.Data.SqlClient;
using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using ModelEmployee;

namespace EmployeeDB
{
    public class ClsEmployeeDB
    {

        //Variables privadas
        private SqlConnection conn;
        private string pathEmployeeDB;

        //Cadena de conexión a la base de datos
        private string _dbConnection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EmployeeManager;Integrated Security=True;TrustServerCertificate=True";

        //Variables de consultas
        private string _queryLogin = "IF EXISTS (SELECT 1 FROM [dbo].[LoginApp] WHERE [email] = @User AND [password] = @Password) SELECT 1 ELSE SELECT 0";
        private string _queryCreateAccount = "INSERT INTO [dbo].[LoginApp]([email],[password]) VALUES (@User, @Password)";

        public ClsEmployeeDB() { 
            conn = new SqlConnection(_dbConnection);

            pathEmployeeDB = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\EmployeeDB\\DataEmployees");

            if (!Directory.Exists(pathEmployeeDB))
            {
                Directory.CreateDirectory(pathEmployeeDB);
            }
        }

        public bool login(string user, string password) 
        {
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand(_queryLogin, conn);
            sqlCommand.Parameters.AddWithValue("@User", user);
            sqlCommand.Parameters.AddWithValue("@Password", password);

            bool exists = false;

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    exists = reader.GetInt32(0) == 1;
                }
            }
            conn.Close();
            return exists;
        }

        public bool createAccount(string user, string password) 
        {  
            this.conn.Open();

            SqlCommand sqlCommand = new SqlCommand(_queryCreateAccount, this.conn);
            sqlCommand.Parameters.AddWithValue("@User", user);
            sqlCommand.Parameters.AddWithValue("@Password", password);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            this.conn.Close();

            return rowsAffected > 0;
        }

        public string CreateEmployee(string name, string surname, string birthdate,
            string identification, string typeIdentification, string gender, string pathImage,
            bool createImage) 
        {
            if (createImage) 
            {
                string filePath = $"{pathEmployeeDB}\\{identification}.txt";

                if (!File.Exists(filePath))
                {
                    using (StreamWriter writer = File.CreateText(filePath))
                    {
                        writer.WriteLine($"Name; {name}");
                        writer.WriteLine($"Surname;  {surname}");
                        writer.WriteLine($"BirthDate;  {birthdate}");
                        writer.WriteLine($"Identification;  {identification}");
                        writer.WriteLine($"TypeIdentification;  {typeIdentification}");
                        writer.WriteLine($"Gender;  {gender}");
                    }

                    //Guardar imagen del empleado
                    string fileName = identification + ".jpg";
                    string imagePath = Path.Combine(pathEmployeeDB + "\\EmployeeImage", fileName);

                    if (!pathImage.Equals(imagePath)) 
                    {
                        File.Delete(imagePath);
                        File.Copy(pathImage, imagePath, true);
                    }

                    return "0";
                }
                else
                {
                    return "Ya existe un empleado con la misma identificación";
                }
            }
            else
            {
                string filePath = $"{pathEmployeeDB}\\{identification}.txt";
                string imagePath = $"{pathEmployeeDB}\\EmployeeImage\\{identification}.jpg";

                if (File.Exists(filePath) && File.Exists(imagePath))
                {
                    File.Delete(filePath);
                    return CreateEmployee(name, surname, birthdate,
                            identification, typeIdentification, gender, pathImage, true);
                }
                else
                {
                    return "Error al actualizar al empleado";
                }
            }


        }

        public string DeleteEmployee(string identification)
        {
            string filePath = $"{pathEmployeeDB}\\{identification}.txt";
            string imagePath = $"{pathEmployeeDB}\\EmployeeImage\\{identification}.jpg";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                File.Delete(imagePath);
                return "Empleado eliminado exitosamente";
            }
            else
            {
                return "El empleado no existe.";
            }
        }

        public List<ClsModelEmployee> GetEmployeeList() 
        {
            string rutaDataEmployees = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\EmployeeDB\\DataEmployees");

            List<ClsModelEmployee> listEmployess = new List<ClsModelEmployee>();

            foreach (string archivo in Directory.GetFiles(rutaDataEmployees))
            {
                ClsModelEmployee empleado = new ClsModelEmployee();

                string[] lineas = File.ReadAllLines(archivo);

                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(';');

                    if (partes.Length == 2)
                    {
                        string propiedad = partes[0].Trim();
                        string valor = partes[1].Trim();

                        switch (propiedad)
                        {
                            case "Name":
                                empleado.Nombres = valor;
                                break;
                            case "Surname":
                                empleado.Apellidos = valor;
                                break;
                            case "BirthDate":
                                empleado.FechaNacimiento = valor;
                                break;
                            case "Identification":
                                empleado.Identificacion = valor;
                                break;                           
                            case "TypeIdentification":
                                empleado.TipoIdentificacion = valor;
                                break;
                            case "Gender":
                                empleado.Genero = valor;
                                break;
                            default:
                                break;
                        }
                    }
                }

                listEmployess.Add(empleado);
            }
            return listEmployess;
        }

        public string GetProfileImage(string identificacion)
        {
            return Path.Combine(pathEmployeeDB + "\\EmployeeImage", identificacion +".jpg");
        }
    }
}
