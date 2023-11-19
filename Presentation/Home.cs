using Business;
using ModelEmployee;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
            ShowEmployees();
        }

        private void ShowEmployees() 
        {
            List<ClsModelEmployee> listEmployees = _clsBusiness.GetEmployeeList();

            DtgEmployees.DataSource = null;
            DtgEmployees.Rows.Clear();

            DtgEmployees.DataSource = listEmployees;
            this.DtgEmployees.Columns[3].ReadOnly = true;
            DtgEmployees.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DtgEmployees.SelectedRows.Count == 1)
            {
                ClsModelEmployee editedEmployee = DtgEmployees.SelectedRows[0].DataBoundItem as ClsModelEmployee;
                BtnAdd.Visible = false;
                BtnUpdate.Visible = true;
                BtnClearEdit.Visible = true;
                TxtIdentification.Enabled = false;

                TxtName.Text = editedEmployee.Nombres;
                TxtSurname.Text = editedEmployee.Apellidos;
                TxtTypeIdentification.Text = editedEmployee.TipoIdentificacion;
                TxtIdentification.Text = editedEmployee.Identificacion;
                TxtBirthDate.Text = editedEmployee.FechaNacimiento;
                TxtGender.Text = editedEmployee.Genero;

                _pathImageSelected = _clsBusiness.GetProfileImage(editedEmployee.Identificacion);
                if (File.Exists(_pathImageSelected))
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
            else if(DtgEmployees.SelectedRows.Count > 1)
            {
                ClearData();
                ResetButtons();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
            string typeIdentification = "";
            string gender = "";
            try 
            {
                typeIdentification = TxtTypeIdentification.SelectedItem.ToString();
                gender = TxtGender.SelectedItem.ToString();
            }
            catch (Exception ex){}

            if (typeIdentification != "" && gender != "") 
            {
                try
                {
                    string message = this._clsBusiness.CreateEmployee(TxtName.Text, TxtSurname.Text, TxtBirthDate.Text,
                        TxtIdentification.Text, typeIdentification, gender, _pathImageSelected, true);
                    if (message == "0")
                    {
                        MessageBox.Show("Acción realizada con éxito");
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
                MessageBox.Show("Tipo identificación o género vacíos");
            }
            ShowEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DtgEmployees.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar los registros seleccionados?", "Confirmar eliminación",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow fila in DtgEmployees.SelectedRows)
                    {
                        _clsBusiness.DeleteEmployee(""+fila.Cells[3].Value);
                    }
                    MessageBox.Show("Registros eliminados con éxito");
                    ClearData();
                    ResetButtons();
                    this.ShowEmployees();
                }     
            }
            else
            {
                MessageBox.Show("Para eliminar un empleado, seleccione un registro en la tabla...");
            }
        }

        private void ClearData() 
        {
            TxtName.Clear();
            TxtSurname.Clear();
            TxtTypeIdentification.SelectedIndex = -1;
            TxtIdentification.Clear();
            TxtIdentification.Enabled = true;
            TxtBirthDate.Clear();
            TxtGender.SelectedIndex = -1;
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
            TxtIdentification.Enabled = true;
            foreach (DataGridViewRow row in DtgEmployees.SelectedRows)
            {
                row.Selected = false;
            }
            ClearData();
        }

        private void ResetButtons() 
        {
            BtnAdd.Visible = true;
            BtnUpdate.Visible = false;
            BtnClearEdit.Visible = false;
            PictureEmployee.Image = null;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string result = this._clsBusiness.CreateEmployee(TxtName.Text,
                TxtSurname.Text, TxtBirthDate.Text, TxtIdentification.Text, TxtTypeIdentification.Text,
                TxtGender.Text, _pathImageSelected, false);

            if (result == "0") 
            {
                MessageBox.Show("Perfil actualizado correctamente");
                ClearEdition();
                ShowEmployees();
            }
            else
            {
                MessageBox.Show(result);
            }
        }
    }
}
