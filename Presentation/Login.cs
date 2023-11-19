using Business;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Login : Form
    {

        private ClsBusiness _clsBussiness;

        public Login()
        {
            _clsBussiness = new ClsBusiness();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sPass = Business.ClsBusiness.GetSHA256(TxtPassword.Text.Trim());
            if (_clsBussiness.ValidateLogin(TxtUser.Text, sPass)) 
            {
                this.Hide();
                Home frmHome = new Home();
                frmHome.FormClosed += (s, args) => this.Close();
                frmHome.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña no coinciden en la base de datos");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount frmCrtAccount = new CreateAccount();
            frmCrtAccount.FormClosed += (s, args) => this.Close();
            frmCrtAccount.Show();
        }
    }
}
