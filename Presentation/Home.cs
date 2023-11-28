using Business;
using ModelEmployee;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Presentation
{
    public partial class Home : Form
    {

        private ClsBusiness _clsBusiness;
        private string _pathImageSelected;

        public Home()
        {
            _clsBusiness = new ClsBusiness();
            _pathImageSelected = "";
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.FormClosed += (s, args) => this.Close();
            frmLogin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rol = "";
            string gender = "";
            try 
            {
                rol = TxtRol.SelectedItem.ToString();
                gender = TxtGender.SelectedItem.ToString();
            }
            catch (Exception ex){}

            if (rol != "" && gender != "") 
            {
                try
                {
                    string message = this._clsBusiness.CreateEmployee(TxtAcNo.Text,
                        TxtName.Text, TxtGender.Text, TxtNo.Text, TxtNacionality.Text,
                        TxtTelephone.Text, TxtCargo.Text, TxtRol.Text, TxtBirthdate.Text,
                        TxtDischargeDate.Text, TxtCodTar.Text, TxtPhone.Text, TxtAddress.Text,
                        _pathImageSelected, true);

                    if (message == "0")
                    {
                        MessageBox.Show("Empleado creado con éxito!");
                        ClearData();
                    }
                    else 
                    {
                        MessageBox.Show(message);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Los campos para insertar al Empleado no estan completos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar los registros seleccionados?", "Confirmar eliminación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _clsBusiness.DeleteEmployee("" + TxtNo.Text);
                MessageBox.Show($"Empleado con No. {TxtNo.Text} eliminado con éxito.");
                ClearData();
                ResetButtons();
            }
        }

        private void ClearData() 
        {
            TxtAcNo.Clear();
            TxtName.Clear();
            TxtGender.SelectedIndex = -1;
            TxtNo.Clear();
            TxtNacionality.Clear();
            TxtTelephone.Clear();
            TxtCargo.Clear();
            TxtRol.SelectedIndex = -1;
            TxtBirthdate.Clear();
            TxtDischargeDate.Clear();
            TxtCodTar.Clear();
            TxtPhone.Clear();
            TxtAddress.Clear();
            PictureEmployee.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _pathImageSelected = openFileDialog.FileName;

                Image originalImage = Image.FromFile(_pathImageSelected);

                int lado = Math.Min(originalImage.Width, originalImage.Height);
                int x = (originalImage.Width - lado) / 2;
                int y = (originalImage.Height - lado) / 2;

                Rectangle rect = new Rectangle(x, y, lado, lado);
                Bitmap imagenRecortada = new Bitmap(lado, lado);

                using (Graphics g = Graphics.FromImage(imagenRecortada))
                {
                    g.DrawImage(originalImage, new Rectangle(0, 0, lado, lado), rect, GraphicsUnit.Pixel);
                }

                PictureEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureEmployee.Image = imagenRecortada;
            }
        }

        private void BtnClearEdit_Click(object sender, EventArgs e)
        {
            ClearEdition();
        }

        private void ClearEdition() 
        {
            ResetButtons();
            TxtNo.Enabled = true;
            ClearData();
        }

        private void ResetButtons() 
        {
            BtnAdd.Visible = true;
            BtnUpdate.Visible = false;
            BtnClearEdit.Visible = false;
            BtnDelete.Visible = false;
            PictureEmployee.Image = null;
            BtnSearch.Visible = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string result = this._clsBusiness.CreateEmployee(TxtAcNo.Text,
                TxtName.Text, TxtGender.Text, TxtNo.Text, TxtNacionality.Text,
                TxtTelephone.Text, TxtCargo.Text, TxtRol.Text, TxtBirthdate.Text,
                TxtDischargeDate.Text, TxtCodTar.Text, TxtPhone.Text, TxtAddress.Text,
                _pathImageSelected, false);

            if (result == "0") 
            {
                MessageBox.Show("Perfil actualizado correctamente");
                ClearEdition();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNo.Text)) {
                ClsModelEmployee employee = _clsBusiness.searchEmployee(TxtNo.Text);
                if (employee != null)
                {
                    TxtAcNo.Text = employee.AcNo;
                    TxtName.Text = employee.Name;
                    TxtGender.Text = employee.Gender;
                    TxtNo.Text = employee.No;
                    TxtNo.Enabled = false;
                    TxtNacionality.Text = employee.Nacionality;
                    TxtTelephone.Text = employee.Telephone;
                    TxtCargo.Text = employee.Cargo;
                    TxtRol.Text = employee.Rol;
                    TxtBirthdate.Text = employee.Birthdate;
                    TxtDischargeDate.Text = employee.DischargeDate;
                    TxtCodTar.Text = employee.CodTar;
                    TxtPhone.Text = employee.Phone;
                    TxtAddress.Text = employee.Address;

                    BtnAdd.Visible = false;
                    BtnSearch.Visible = false;
                    BtnUpdate.Visible = true;
                    BtnClearEdit.Visible = true;
                    BtnDelete.Visible = true;
                    PictureEmployee.Image = null;

                    _pathImageSelected = _clsBusiness.GetProfileImage(employee.No);
                    if (System.IO.File.Exists(_pathImageSelected))
                    {
                        using (FileStream fs = new FileStream(_pathImageSelected, FileMode.Open, FileAccess.Read))
                        {
                            PictureEmployee.Image = Image.FromStream(fs);
                            PictureEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No fue posible cargar la imagen del empleado");
                    }
                }
                else 
                {
                    MessageBox.Show($"El empleado con el No. {TxtNo.Text} no existe...");
                }



            }
            else {
                MessageBox.Show("Para buscar, ingrese el No. de un empleado...");
            }
        }
    }
}
