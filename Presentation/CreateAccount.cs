using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class CreateAccount : Form
    {

        private ClsBusiness _clsBusiness;

        public CreateAccount()
        {
            _clsBusiness = new ClsBusiness();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.FormClosed += (s, args) => this.Close();
            frmLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = TxtUser.Text;
            string pass = TxtPass.Text;
            string confirmPass = TxtConfirmPass.Text;

            if (user.Length < 6) 
            {
                MessageBox.Show("El usuario debe contar con mínimo 6 caracteres");
                return;
            }

            if (pass.Length < 6)
            {
                MessageBox.Show("La contraseña debe contar con mínimo 6 caracteres");
                return;
            }

            if (_clsBusiness.CreateAccount(user, pass, confirmPass)) 
            {
                MessageBox.Show("El usuario "+user+" fue creado con éxito!");
                this.Hide();
                Login frmLogin = new Login();
                frmLogin.FormClosed += (s, args) => this.Close();
                frmLogin.Show();
            }
            else
            {
                MessageBox.Show("Error al insertar al usuario");
            }

        }
    }
}
