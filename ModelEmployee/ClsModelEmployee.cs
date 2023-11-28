using System;

namespace ModelEmployee
{
    public class ClsModelEmployee
    {

        public ClsModelEmployee() { }

        public ClsModelEmployee(string acNo, string name, string gender, string no, string nacionality, string telephone, string cargo, string rol, string birthdate, string dischargeDate, string codTar, string phone, string address)
        {
            this.acNo = acNo;
            this.name = name;
            this.gender = gender;
            this.no = no;
            this.nacionality = nacionality;
            this.telephone = telephone;
            this.cargo = cargo;
            this.rol = rol;
            this.birthdate = birthdate;
            this.dischargeDate = dischargeDate;
            this.codTar = codTar;
            this.phone = phone;
            this.address = address;
        }

        private string acNo;
        private string name;
        private string gender;
        private string no;
        private string nacionality;
        private string telephone;
        private string cargo;
        private string rol;
        private string birthdate;
        private string dischargeDate;
        private string codTar;
        private string phone;
        private string address;

        public string AcNo { get => acNo; set => acNo = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string No { get => no; set => no = value; }
        public string Nacionality { get => nacionality; set => nacionality = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string DischargeDate { get => dischargeDate; set => dischargeDate = value; }
        public string CodTar { get => codTar; set => codTar = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }
}
