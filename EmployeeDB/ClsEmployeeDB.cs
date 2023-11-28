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

        public string CreateEmployee(string acNo, string name, string gender, string no, string nacionality,
            string telephone, string cargo, string rol, string birthdate, string dischargeDate,
            string codTar, string phone, string address, string pathImage, bool createEmployee) 
        {
            if (createEmployee) 
            {
                string filePath = $"{pathEmployeeDB}\\{no}.txt";

                if (!File.Exists(filePath))
                {
                    using (StreamWriter writer = File.CreateText(filePath))
                    {
                        writer.WriteLine($"AcNo; {acNo}");
                        writer.WriteLine($"Name; {name}");
                        writer.WriteLine($"Gender;  {gender}");
                        writer.WriteLine($"No;  {no}");
                        writer.WriteLine($"Nacionality;  {nacionality}");
                        writer.WriteLine($"Telephone;  {telephone}");
                        writer.WriteLine($"Cargo;  {cargo}");
                        writer.WriteLine($"Rol;  {rol}");
                        writer.WriteLine($"Birthdate;  {birthdate}");
                        writer.WriteLine($"DischargeDate;  {dischargeDate}");
                        writer.WriteLine($"CodTar;  {codTar}");
                        writer.WriteLine($"Phone;  {phone}");
                        writer.WriteLine($"Address;  {address}");
                    }

                    //Guardar imagen del empleado
                    string fileName = no + ".jpg";
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
                    return "Ya existe un empleado con el mismo Número (No.)";
                }
            }
            else
            {
                string filePath = $"{pathEmployeeDB}\\{no}.txt";
                string imagePath = $"{pathEmployeeDB}\\EmployeeImage\\{no}.jpg";

                if (File.Exists(filePath) && File.Exists(imagePath))
                {
                    File.Delete(filePath);
                    return CreateEmployee(acNo, name, gender, no, nacionality,
                    telephone, cargo, rol, birthdate, dischargeDate,
                    codTar, phone, address, pathImage, true);
                }
                else
                {
                    return "Error al actualizar al empleado";
                }
            }


        }

        public string DeleteEmployee(string no)
        {
            string filePath = $"{pathEmployeeDB}\\{no}.txt";
            string imagePath = $"{pathEmployeeDB}\\EmployeeImage\\{no}.jpg";

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

            string path = "ruta/a/tu/archivo.txt";

            // Leer todas las líneas del archivo
            string[] lines = File.ReadAllLines(path);

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
                            case "AcNo":
                                empleado.AcNo = valor;
                                break;
                            case "Name":
                                empleado.Name = valor;
                                break;
                            case "Gender":
                                empleado.Gender = valor;
                                break;
                            case "No":
                                empleado.No = valor;
                                break;                           
                            case "Nacionality":
                                empleado.Nacionality = valor;
                                break;
                            case "Telephone":
                                empleado.Telephone = valor;
                                break;
                            case "Cargo":
                                empleado.Cargo = valor;
                                break;
                            case "Rol":
                                empleado.Rol = valor;
                                break;
                            case "Birthdate":
                                empleado.Birthdate = valor;
                                break;
                            case "DischargeDate":
                                empleado.DischargeDate = valor;
                                break;
                            case "CodTar":
                                empleado.CodTar = valor;
                                break;
                            case "Phone":
                                empleado.Phone = valor;
                                break;
                            case "Address":
                                empleado.Address = valor;
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

        public string GetProfileImage(string no)
        {
            return Path.Combine(pathEmployeeDB + "\\EmployeeImage", no + ".jpg");
        }

        public ClsModelEmployee searchEmployee(string no)
        {
            string employeePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"..\\..\\..\\EmployeeDB\\DataEmployees\\{no}.txt");

            string[] lineas = new string[0];

            try {
                lineas = File.ReadAllLines(employeePath);
            }
            catch (Exception err) 
            {
                return null;
            }
            
            ClsModelEmployee empleado = new ClsModelEmployee();

            

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(';');

                if (partes.Length == 2)
                {
                    string propiedad = partes[0].Trim();
                    string valor = partes[1].Trim();

                    switch (propiedad)
                    {
                        case "AcNo":
                            empleado.AcNo = valor;
                            break;
                        case "Name":
                            empleado.Name = valor;
                            break;
                        case "Gender":
                            empleado.Gender = valor;
                            break;
                        case "No":
                            empleado.No = valor;
                            break;
                        case "Nacionality":
                            empleado.Nacionality = valor;
                            break;
                        case "Telephone":
                            empleado.Telephone = valor;
                            break;
                        case "Cargo":
                            empleado.Cargo = valor;
                            break;
                        case "Rol":
                            empleado.Rol = valor;
                            break;
                        case "Birthdate":
                            empleado.Birthdate = valor;
                            break;
                        case "DischargeDate":
                            empleado.DischargeDate = valor;
                            break;
                        case "CodTar":
                            empleado.CodTar = valor;
                            break;
                        case "Phone":
                            empleado.Phone = valor;
                            break;
                        case "Address":
                            empleado.Address = valor;
                            break;
                        default:
                            break;
                    }
                }
            }

            return empleado;

        }
    }
}
